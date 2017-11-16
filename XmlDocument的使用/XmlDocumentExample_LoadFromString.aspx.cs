#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_LoadFromString : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			XmlDocument empDoc = new XmlDocument();

			try
			{
				//Load the XML from a String
				empDoc.LoadXml("<?xml version=\"1.0\" ?>" +
				               "<employees>" +
				               "<employee id='2'>" +
				               "<name><firstName>Nancy</firstName>" +
				               "<lastName>Davolio</lastName>" +
				               "</name><city>Seattle</city>" +
				               "<state>WA</state><zipCode>98122</zipCode>" +
				               "</employee></employees>");
				//调用XmlDocument的Save()方法，将内存中的XML文档保存到磁盘上
				empDoc.Save(Server.MapPath("Employees.xml")); 
			}
			catch (Exception ex)
			{
				Response.Write("Exception: " + ex.Message);
			}
		}
	}
}