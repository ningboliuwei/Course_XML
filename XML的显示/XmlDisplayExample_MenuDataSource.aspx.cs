#region

using System;
using System.Web.UI;
using System.Xml.Xsl;

#endregion

namespace XML的显示
{
	public partial class XmlDisplayExample_MenuDataSource : Page
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