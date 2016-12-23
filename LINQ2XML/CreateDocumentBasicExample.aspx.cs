using System;
using System.Web.UI;
using System.Xml.Linq;

namespace LINQ2XML
{
    public partial class CreateDocumentExample : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreate_OnClick(object sender, EventArgs e)
        {
            var filePath = Server.MapPath("books_1.xml");

            try
            {
                var xdoc = new XDocument(
                    new XDeclaration("1.0", "UTF-8", "yes"),
                    new XElement("bookstore",
                        new XElement("book",
                            new XAttribute("genre", "philosophy"),
                            new XElement("title", "Critique of Pure Reason"),
                            new XElement("author",
                                new XElement("first-name", "Immanuel"),
                                new XElement("last-name", "Kant")),
                            new XElement("price", "9.99"))));

                xdoc.Save(filePath);

                Response.Write("文档创建成功");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btnCreate2_OnClick(object sender, EventArgs e)
        {
            var filePath = Server.MapPath("books_2.xml");

            try
            {
                var book = new XElement("book");
                var bookAttr = new XAttribute("genre", "philosophy");
                book.Add(bookAttr);
                book.Add(new XElement("title", "Critique of Pure Reason"));

                var author = new XElement("author");
                author.Add(new XElement("first-name", "Immuanuel"));
                author.Add(new XElement("last-name", "Kant"));
                book.Add(author);
                book.Add(new XElement("price", "9.99"));

                var bookstore = new XElement("bookstore");
                bookstore.Add(book);

                var declaration = new XDeclaration("1.0", "UTF-8", "yes");
                var xdoc = new XDocument(declaration, bookstore);

                xdoc.Save(filePath);

                Response.Write("文档创建成功");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btnCreateBasic_OnClick(object sender, EventArgs e)
        {
            var filePath = Server.MapPath("empty.xml");

            try
            {
                var xdoc = new XDocument(
                    new XDeclaration("1.0", "UTF-8", "yes"),
                    new XComment($"Created at {DateTime.Now}"),
                    new XElement("root")
                );

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