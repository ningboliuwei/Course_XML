using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用_DEMO
{
	using System.Xml;

	public partial class Default2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml("<?xml version=\"1.0\" ?><bookstore></bookstore>");

			doc.Save(Server.MapPath("newbooks.xml"));


		}
	}
}