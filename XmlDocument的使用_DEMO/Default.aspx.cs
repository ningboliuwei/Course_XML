using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace XmlDocument的使用_DEMO
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				XmlDocument doc = new XmlDocument();
				string fileName = "books.xml";

				doc.PreserveWhitespace = true;
				doc.Load(Server.MapPath(fileName));

				Response.ContentType = "text/xml"; 
				Response.Write(doc.InnerXml);

			}
		}
	}
}