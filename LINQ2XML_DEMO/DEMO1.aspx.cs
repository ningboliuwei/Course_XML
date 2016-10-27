using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML_DEMO
{
    public partial class DEMO1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XComment("by liuwei"),
                new XElement("root")
                );

            xdoc.Save(Server.MapPath("empty.xml"));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement("bookstore",
                    new XElement("book",
                        new XAttribute("genre", "philosophy"),
                        new XElement("title", "Critique of Pure Reason"),
                        new XElement("author",
                            new XElement("first-name", "Immanuel"),
                            new XElement("last-name", "Kant")),
                        new XElement("price", "9.99"))));
            xdoc.Save(Server.MapPath("book_1.xml"));



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Load(Server.MapPath("book_1.xml"));

            TextBox1.Text = xdoc.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            XDocument xdoc = XDocument.Parse(TextBox1.Text);

            xdoc.Save(Server.MapPath("output.xml"));
        }
    }
}