#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_LoadFromFile : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("Books.xml");
			//创建一个XmlDocument对象
			XmlDocument booksDoc = new XmlDocument();

			Response.ContentType = "text/xml";
			//保留空格
			booksDoc.PreserveWhitespace = false;

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
			Response.Write(booksDoc.OuterXml);
//            Response.Write(booksDoc.InnerXml);
        }
	}
}