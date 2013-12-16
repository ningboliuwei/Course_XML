using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Xsl;

public partial class Default5 : System.Web.UI.Page
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
