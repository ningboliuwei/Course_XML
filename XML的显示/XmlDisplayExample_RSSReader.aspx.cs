#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XML的显示
{
	public partial class XmlDisplayExample_RSSReader : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void okButton_Click(object sender, EventArgs e)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(rssTextBox.Text.Trim());

            Xml1.DocumentContent = doc.OuterXml;
			Xml1.TransformSource = "RSS.xsl";
		}
	}
}