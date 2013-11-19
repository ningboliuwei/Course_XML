using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用
{
	using System.Xml;

	public partial class XmlDocumentExample_LoadFromFile : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			XmlDocument booksDoc = new XmlDocument(); //创建一个XmlDocument对象

			Response.ContentType = "text/xml";
			try
			{
				booksDoc.PreserveWhitespace = true; //保留空格
				booksDoc.Load(xmlPath); //从指定路径加载XML文档到XmlDocument对象中
				Response.Write(booksDoc.InnerXml); //在浏览器中输出XML文档（利用InnerXml）

			}
			catch (Exception ex)
			{
				Response.Write("Exception: " + ex.Message);
			}
		}
	}
}
