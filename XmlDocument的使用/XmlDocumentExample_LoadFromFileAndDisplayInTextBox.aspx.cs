using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_LoadFromFileAndDisplayInTextBox : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			//创建一个XmlDocument对象
			XmlDocument booksDoc = new XmlDocument();

			//保留空格
			booksDoc.PreserveWhitespace = true;

			try
			{
				//从指定路径加载XML文档到XmlDocument对象中
				booksDoc.Load(xmlPath);
			}
			catch (Exception ex)
			{
				Response.Write("Exception: " + ex.Message);
			}
			//在浏览器中输出XML文档（利用InnerXml）
			txtContent.Text = booksDoc.OuterXml;
		}
	}
}