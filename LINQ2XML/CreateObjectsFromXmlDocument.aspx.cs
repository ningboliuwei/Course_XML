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
					select new
					{
						Title = book.Element("title").Value,
						//另一种写法
						//Author = book.Descendants("first-name").ToList()[0].Value + book.Descendants("last-name").ToList()[0].Value,
						Author = author.Element("first-name").Value + " " + author.Element("last-name"),
						Price = book.Element("price")
					};

				foreach (var v in books)
				{
					Response.Write(v.Title + ", " + v.Author + ", " + v.Price + "<br/>");
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}