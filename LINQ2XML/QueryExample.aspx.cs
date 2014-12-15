using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML
{
	public partial class QueryExample : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnGetTitles_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var titles = from t in xdoc.Descendants("title")
							 select (t.Value as string).ToUpper();

				foreach (var title in titles)
				{
					Response.Write(title + "<br/>");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnGetChildrenTitles_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var titles = from book in xdoc.Descendants("book")
							 where book.Attribute("genre").Value == "children"
							 select book.Element("title").Value;

				foreach (var title in titles)
				{
					Response.Write(title + "<br/>");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnGetMaxPrice_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var maxPrice = (from price in xdoc.Descendants("price")
								let p = Convert.ToSingle(price.Value)
								select p).Max();

				Response.Write(maxPrice);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnOrderByPrice_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var titles = from book in xdoc.Descendants("book")
							 let price = Convert.ToSingle(book.Element("price").Value)
							 orderby price descending
							 select book.Element("title").Value;

				foreach (var title in titles)
				{
					Response.Write(title + "<br/>");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnGroupByGenre_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var groups = from book in xdoc.Descendants("book")
							 let genre = book.Attribute("genre").Value
							 let title = book.Element("title").Value
							 group title by genre;

				foreach (var g in groups)
				{
					Response.Write("<h2>" + g.Key + "</h2><br/>");
					foreach (var title in g)
					{
						Response.Write(title + "<br/>");
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnGetAveragePrice_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var maxPrice = (from price in xdoc.Descendants("price")
								let p = Convert.ToSingle(price.Value)
								select p).Average();

				Response.Write(maxPrice);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnGetAveragePriceGroupByGenre_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				var groups = from book in xdoc.Descendants("book")
							 let genre = book.Attribute("genre").Value
							 let price = Convert.ToSingle(book.Element("price").Value)
							 group price by genre;

				foreach (var g in groups)
				{
					Response.Write("<h2>" + g.Key + "</h2><br/>");
					Response.Write(g.Average() + "<br/>");
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}