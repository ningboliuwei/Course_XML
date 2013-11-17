using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用
{
	using System.Xml;

	public partial class XmlDocumentExample_LoadFromString : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			XmlDocument empDoc = new XmlDocument();
			Response.ContentType = "text/xml";
			try
			{
				//Load the XML from a String
				empDoc.LoadXml("<?xml version=\"1.0\" ?>" +
							   "<employees>" +
							   "<employee id='1'>" +
							   "<name><firstName>Nancy</firstName>" +
							   "<lastName>Davolio</lastName>" +
							   "</name><city>Seattle</city>" +
							   "<state>WA</state><zipCode>98122</zipCode>" +
							   "</employee></employees>");

				empDoc.Save(Server.MapPath("Employees.xml"));//调用XmlDocument的Save()方法，将内存中的XML文档保存到磁盘上
			}
			catch (Exception ex)
			{
				Response.Write("Exception: " + ex.Message);
			}
		}
	}
}