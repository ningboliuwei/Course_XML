using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		
    }
	protected void okButton_Click(object sender, EventArgs e)
	{
		XmlDocument doc = new XmlDocument();
		doc.Load(rssTextBox.Text.Trim());
		Xml1.Document = doc;
		Xml1.TransformSource = "RSS.xsl";
	}
}
