using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML_DEMO
{
    public partial class BookCRUD : System.Web.UI.Page
    {
        private static int index;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowBook(index);
            }
        }

        private void CreateEmptyFile()
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("bookstore")
                );

            xdoc.Save(GetFilePath());
        }

        private string GetFilePath()
        {
            return Server.MapPath("bookdata.xml");
        }

        protected void btnAddRecord_OnClick(object sender, EventArgs e)
        {
            if (!File.Exists(GetFilePath()))
            {
                CreateEmptyFile();
            }
          
            AddBook();
        }

        private void AddBook()
        {
            XDocument xdoc = XDocument.Load(GetFilePath());

            XElement book =
               new XElement("book",
                   new XAttribute("genre", drpGenre.Text),
                   new XElement("title", txtTitle.Text),
                   new XElement("author",
                       new XElement("first-name", txtFirstName.Text),
                       new XElement("last-name", txtLastName.Text)),
                   new XElement("price", txtPrice.Text));
            xdoc.Root.Add(book);

            xdoc.Save(GetFilePath());
        }

        private void ShowBook(int index)
        {
            XDocument xdoc = XDocument.Load(GetFilePath());

            //            XElement book = xdoc.Root.Elements("book").ToList()[index];
            //            txtTitle.Text = book.Element("title").Value;
            //            drpGenre.Text = book.Attribute("genre").Value;
            //            txtFirstName.Text = book.Element("author").Element("first-name").Value;
            //            txtLastName.Text = book.Element("author").Element("last-name").Value;
            //            txtPrice.Text = book.Element("price").Value;

           
             txtTitle.Text = xdoc.Descendants("title").ToList()[index].Value;
            drpGenre.Text = xdoc.Descendants("genre").ToList()[index].Value;
            txtFirstName.Text = xdoc.Descendants("first-name").ToList()[index].Value;
            txtLastName.Text = xdoc.Descendants("last-name").ToList()[index].Value;
            txtPrice.Text = xdoc.Descendants("price").ToList()[index].Value;

        }

        protected void btnUpdate_OnClick(object sender, EventArgs e)
        {

        }

        protected void btnDelete_OnClick(object sender, EventArgs e)
        {

        }

        private int GetBookCount()
        {
            XDocument xdoc = XDocument.Load(GetFilePath());

            return xdoc.Root.Elements("book").Count();

        }

        protected void btnNextRecord_OnClick(object sender, EventArgs e)
        {
            if (index < GetBookCount() - 1)
            {
                ShowBook(++index);
            }
        }

        protected void btnPreviousRecord_OnClick(object sender, EventArgs e)
        {
            if (index > 0)
            {
                ShowBook(--index);
            }
        }
    }
}