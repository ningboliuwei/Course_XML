#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_Traversal : Page
	{
		private void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			
			XmlDocument doc = new XmlDocument();
			doc.Load(xmlPath);
			XmlNode rootNode = doc.DocumentElement;
			DisplayNodes(rootNode);
		}

		private void DisplayNodes(XmlNode node)
		{
			//输出节点的名称、类型与值 
			if (node.NodeType == XmlNodeType.Text)
			{
				Response.Write("Type= [" + node.NodeType + "] Value=" + node.Value + "<br>");
			}
			else
			{
				Response.Write("Type= [" + node.NodeType + "] Name=" + node.Name + "<br>");
			}


			//输出节点的属性
			if (node.Attributes != null)
			{
				XmlAttributeCollection attrs = node.Attributes;
				foreach (XmlAttribute attr in attrs)
				{
					Response.Write("Attribute Name =" + attr.Name + "Attribute Value =" + attr.Value);
				}
			}

			//输出节点的子节点（进入遍历）
			XmlNodeList children = node.ChildNodes;
			foreach (XmlNode child in children)
			{
				DisplayNodes(child);
			}
		}
	}
}