using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml.XPath;

namespace LINQ2XML
{
    public partial class BooksCRUDExample : System.Web.UI.Page
    {
        private static int _index;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowRecord(0);
            }
        }

        protected void btnPreviousRecord_OnClick(object sender, EventArgs e)
        {
            if (_index >= 1)
            {
                ShowRecord(--_index);
            }
        }

        private string GetFilePath()
        {
            return Server.MapPath("books.xml");
        }

        private void ShowRecord(int index)
        {
            XDocument xDoc = XDocument.Load(GetFilePath());


            //如果下列6行代码中的第2~6行最后使用的是 .ToString() 而不是 .Value 会出现什么结果？
            XElement book = xDoc.Root.Elements("book").ToList()[index];
            txtTitle.Text = book.Element("title").Value;
            drpGenre.Text = book.Attribute("genre").Value;
            txtFirstName.Text = book.Element("author").Element("first-name").Value;
            txtLastName.Text = book.Element("author").Element("last-name").Value;
            txtPrice.Text = book.Element("price").Value;

            //            也可以使用以下方式
            //            txtTitle.Text = xDoc.Descendants("title").ToList()[index].Value;
            //            注意属性处理方式不同
            //            drpGenre.Text = xDoc.DescendantNodes().ToList()[index].ToString();
            //            txtFirstName.Text = xDoc.Descendants("first-name").ToList()[index].Value;
            //            txtLastName.Text = xDoc.Descendants("last-name").ToList()[index].Value;
            //            txtPrice.Text = xDoc.Descendants("price").ToList()[index].Value;

            //还可以使用以下方式
//            txtTitle.Text = xDoc.XPathSelectElement($"/bookstore/book[{index + 1}]/title").Value;
//            //注意属性是如何获取的
//            drpGenre.Text = xDoc.XPathSelectElement($"/bookstore/book[{index + 1}]").Attribute("genre").Value;
//            txtFirstName.Text = xDoc.XPathSelectElement($"/bookstore/book[{index + 1}]/author/first-name").Value;
//            txtLastName.Text = xDoc.XPathSelectElement($"/bookstore/book[{index + 1}]/author/last-name").Value;
//            txtPrice.Text = xDoc.XPathSelectElement($"/bookstore/book[{index + 1}]/price").Value;
        }

        private int GetRecordsCount()
        {
            XDocument xDoc = XDocument.Load(GetFilePath());

            return xDoc.Root.Elements("book").ToList().Count;
        }

        protected void btnNextRecord_OnClick(object sender, EventArgs e)
        {
            if (_index < GetRecordsCount() - 1)
            {
                ShowRecord(++_index);
            }
        }

        protected void btnAddRecord_OnClick(object sender, EventArgs e)
        {
            AddRecord();
        }

        private void DeleteRecord(int index)
        {
            XDocument xDoc = XDocument.Load(GetFilePath());

            xDoc.Root.Elements("book").ToList()[index].Remove();
            xDoc.Save(GetFilePath());
        }

        private void AddRecord()
        {
            XDocument xDoc = XDocument.Load(GetFilePath());

            XElement book =
                new XElement(
                    new XElement("book", new XAttribute("genre", drpGenre.Text), new XElement("title", txtTitle.Text),
                        new XElement("author", new XElement("first-name", txtFirstName.Text),
                            new XElement("last-name", txtLastName.Text)), new XElement("price", txtPrice.Text)));

            xDoc.Root.Add(book);
            xDoc.Save(GetFilePath());
        }

        private void UpdateRecord(int index)
        {
            XDocument xDoc = XDocument.Load(GetFilePath());

            XElement book = xDoc.Root.Elements("book").ToList()[index];
            //以下5行如果最后使用的是 .ToString() 而不是 .Value 会出现什么结果？
            book.Element("title").Value = txtTitle.Text;
            book.Attribute("genre").Value = drpGenre.Text;
            book.Element("author").Element("first-name").Value = txtFirstName.Text;
            book.Element("author").Element("last-name").Value = txtLastName.Text;
            book.Element("price").Value = txtPrice.Text;

            //另一种做法
//            XElement book = new XElement("book", new XElement("title", txtTitle.Text),
//                new XAttribute("genre", drpGenre.Text),
//                new XElement("author", new XElement("first-name", txtFirstName.Text),
//                    new XElement("last-name", txtLastName.Text)), new XElement("price", txtPrice.Text));
//            xDoc.Root.Elements("book").ToList()[index].ReplaceWith(book);

            xDoc.Save(GetFilePath());
        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {
            UpdateRecord(_index);
        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {
            if (GetRecordsCount() != 0)
            {
                DeleteRecord(_index);
                ShowRecord(--_index);
            }
        }
    }
}