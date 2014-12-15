using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML
{
	public partial class CreateXmlDocumentFromObjects : System.Web.UI.Page
	{
		private class Book
		{
			public string Title { get; set; }
			public string Author { get; set; }
			public float Price { get; set; }
		}

		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnConvert_OnClick(object sender, EventArgs e)
		{
			List<Book> books = new List<Book>()
			{
				new Book() {Title = "H", Author = "b b", Price = 1},
				new Book() {Title = "D", Author = "c c", Price = 2}
			};

			XElement bookstore = new XElement("bookstore",
				books.Select(
					b => new XElement("book",
						new XElement("author",
							new XElement("first-name", b.Author.Split()[0]),
							new XElement("first-name", b.Author.Split()[1])),
						new XElement("price", b.Price))));

			if (bookstore != null)
			{
				bookstore.Save("r:\\ObjectsToXml.xml");
			}
		}
	}
}