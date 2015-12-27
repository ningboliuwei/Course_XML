using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML
{
    public partial class CreateDocumentExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreate_OnClick(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("books_1.xml");

            try
            {
                XDocument  bookstore = new XDocument("bookstore",
                    new XElement("book", new XAttribute("genre", "philosophy"),
                        new XElement("title", "Critique of Pure Reason"),
                        new XElement("author",
                            new XElement("first-name", "Immuanuel"),
                            new XElement("last-name", "Kant")),
                        new XElement("price", "9.99")));

                bookstore.Save(filePath);

                Response.Write("文档创建成功");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btnCreate2_OnClick(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("books2.xml");

            try
            {
               
                XElement book = new XElement("book");
                XAttribute bookAttr = new XAttribute("genre", "philosophy");
                book.Add(bookAttr);
                book.Add(new XElement("title", "Critique of Pure Reason"));

                XElement author = new XElement("author");
                author.Add(new XElement("first-name", "Immuanuel"));
                author.Add(new XElement("last-name", "Kant"));
                book.Add(author);
                book.Add(new XElement("price", "9.99"));

                XDocument bookstore = new XDocument("bookstore");
                bookstore.Add(book);
                bookstore.Save(filePath);

                Response.Write("文档创建成功");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btnCreateBasic_OnClick(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("empty.xml");

            try
            {
                XDocument xdoc = new XDocument(
                    new XDeclaration("1.0", "UTF-8", "yes"),
                    new XComment($"Created at {DateTime.Now}"),
                    new XElement("root"));

                xdoc.Save(filePath);

                Response.Write("文档创建成功");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}