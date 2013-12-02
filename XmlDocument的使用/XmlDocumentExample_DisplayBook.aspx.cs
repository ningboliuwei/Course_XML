using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用
{
	using System.Xml;

	public partial class XmlDocumentExample_DisplayBook : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			XmlDocument doc = new XmlDocument();
			doc.Load(xmlPath);

			//Get all job titles in the XML file
			//XmlNodeList titleList = doc.GetElementsByTagName("title");
			//Response.Write("Titles: " + "<br>");
			/*foreach (XmlNode node in titleList)
			{
				Response.Write("Title : " + node.InnerText + "<br>");
			}*/
			//Get reference to the first author node in the XML file
			//XmlNode authorNode = doc.GetElementsByTagName("author")[0];
			/*foreach (XmlNode child in authorNode.ChildNodes)
			{
				if ((child.Name == "first-name") && (child.NodeType == XmlNodeType.Element))
				{
					Response.Write("First Name : " + child.FirstChild.Value + "<br>");
				}
				if ((child.Name == "last-name") && (child.NodeType == XmlNodeType.Element))
				{
					Response.Write("Last Name : " + child.FirstChild.Value + "<br>");
				}
			}*/

			//XmlNode node2 = doc.SelectNodes("/bookstore/book")[0];
			//XmlNode node2 = doc.SelectSingleNode("/boostore/book[1]");
			//Response.Write(node2.Attributes[0].Value);

			XmlNode root = doc.DocumentElement;
			

		}
	}
}