using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XML的显示
{
	using System.Xml.Xsl;

	public partial class XmlDisplayExample_MenuDataSource : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			XsltArgumentList argsList = new XsltArgumentList();
			argsList.AddParam("calories", "", TextBox1.Text);
			Xml1.TransformArgumentList = argsList;
			Xml1.Visible = true;
		}
	}
}