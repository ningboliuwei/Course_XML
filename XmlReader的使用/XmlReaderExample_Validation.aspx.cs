#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlReader与XmlWriter的使用
{
	public partial class XmlReaderExample_Validation : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			//XML文件所在位置
			string xmlFilePath = Server.MapPath(@"Docs\Book2.xml");

			//创建XmlReaderSettings对象，并设置适合的属性
			XmlReaderSettings settings = new XmlReaderSettings();
			settings.IgnoreComments = true;

			settings.ValidationType = ValidationType.Schema;
			settings.Schemas.Add(null, Server.MapPath(@"Docs\Book.xsd"));
			settings.IgnoreWhitespace = false;

			try
			{
				//引用XMLReader对象，并指定设置
				XmlReader reader = XmlReader.Create(xmlFilePath, settings);

				while (reader.Read())
				{
					Response.Write(reader.Value + "<br/>");
				}
			}
			catch (Exception ex)
			{
				Response.Write("An Exception: " + ex.Message);
			}
		}
	}
}