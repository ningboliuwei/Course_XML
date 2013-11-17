using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用
{
	using System.Xml;

	public partial class XmlDocumentExample_Traversal : System.Web.UI.Page
	{
		void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			XmlDocument doc = new XmlDocument();
			doc.Load(xmlPath);
			XmlNode rootNode = doc.DocumentElement;
			DisplayNodes(rootNode);
		}

		void DisplayNodes(XmlNode node)
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