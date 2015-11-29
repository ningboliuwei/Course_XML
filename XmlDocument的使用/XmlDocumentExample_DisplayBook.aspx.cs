#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_DisplayBook : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			XmlDocument doc = new XmlDocument();
			doc.Load(xmlPath);

			//得到所有名为 title 的元素节点的集合
//			XmlNodeList titleList = doc.GetElementsByTagName("author");
//			Response.Write("Titles: " + "<br>");
//			//输出所有 title 元素的文本值
////			
//			foreach (XmlNode node in titleList)
//			{
//				Response.Write("Title : " + node.InnerText + "<br>");
//			}
//
//			Response.Write("First Author<br/> : ");
//			//得到第一个名为 author 的元素节点
			XmlNode authorNode = doc.GetElementsByTagName("author")[0];
			//输出所有author节点的子节点
			foreach (XmlNode child in authorNode.ChildNodes)
			{
				//如果当前子节点名为 first-name 并且类型为元素节点
				if ((child.Name == "first-name") && (child.NodeType == XmlNodeType.Element))
				{
					//输出这个子节点的第一个子节点的值（即文本值）
					Response.Write("First Name : " + child.FirstChild.Value + "<br>");
				}
				if ((child.Name == "last-name") && (child.NodeType == XmlNodeType.Element))
				{
					Response.Write("Last Name : " + child.FirstChild.Value + "<br>");
				}
			}
//
//			XmlNode node2 = doc.SelectNodes("/bookstore/book")[0];
//			//上一行代码的另外一种写法
//			//XmlNode node2 = doc.SelectSingleNode("/boostore/book[1]");
//			//输出节点的第一个属性的值
//			Response.Write(node2.Attributes[0].Name + " : " + node2.Attributes[0].Value);
		}
	}
}