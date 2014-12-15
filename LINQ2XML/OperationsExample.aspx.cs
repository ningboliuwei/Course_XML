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
	public partial class OperationsExample : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLoadDocument_OnClick(object sender, EventArgs e)
		{

		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");
			int index = Convert.ToInt32(txtNo.Text);

			try
			{
				XDocument xdoc = XDocument.Load(filePath);

				txtTitle.Text = xdoc.XPathSelectElement("/bookstore/book[1]/title").Value;
				//注意属性是如何获取的
				txtGenre.Text = xdoc.XPathSelectElement("/bookstore/book[1]").Attribute("genre").Value;
				txtFirstName.Text = xdoc.XPathSelectElement("/bookstore/book[1]/author/first-name").Value;
				txtLastName.Text = xdoc.XPathSelectElement("/bookstore/book[1]/author/last-name").Value;
				txtPrice.Text = xdoc.XPathSelectElement("/bookstore/book[1]/price").Value;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnDelete_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XElement xElement = XElement.Load(filePath);

				//删除第一个 book 节点
				//xElement.Element("book").Remove();

				//删除第二个 book 节点
				xElement.Elements("book").ToList()[1].Remove();

				//删除所有的 book 节点
				//xElement.Elements("book").Remove();
				

				xElement.Save(filePath);
				Response.Write("删除成功");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnUpdate_OnClick(object sender, EventArgs e)
		{
			string filePath = Server.MapPath("books.xml");

			try
			{
				XElement xElement = XElement.Load(filePath);

				//修改第一个 title 节点
				//注意用法，尤其是 ToList()
				//xElement.Descendants("title").ToList()[0].Value = "## MODIFIED! ##";

				//另外一种用法
				XElement newTitle = new XElement("title", new XElement("test"));
				xElement.Descendants("title").ToList()[0].ReplaceWith(newTitle);

				xElement.Save(filePath);
				Response.Write("修改成功");
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}