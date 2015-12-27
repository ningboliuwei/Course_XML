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
    public partial class CreateObjectsFromXmlDocument : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnConvert_OnClick(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("books.xml");

            try
            {
                XDocument xdoc = XDocument.Load(filePath);

                var books = from book in xdoc.Descendants("book")
                    let author = book.Element("author")
                    where  Convert.ToDouble(book.Element("price").Value)>20
                    orderby book.Element("title").Value descending
                    select new
                    {
                        Title = book.Element("title").Value,
                        //另一种写法
                        //Author = book.Descendants("first-name").ToList()[0].Value + book.Descendants("last-name").ToList()[0].Value,
                        Author = $"{author.Element("first-name").Value} {author.Element("last-name").Value}",
                        Price = book.Element("price").Value
                    };

                //通过循环遍历对象数组输出结果
                foreach (var b in books)
                {
                    Response.Write(b.Title + ", " + b.Author + ", " + b.Price + "<br/>");
                }

                //直接将对象数组作为 GridView 数据源输出结果
                gdvBooks.DataSource = books.ToList();
                gdvBooks.DataBind();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}