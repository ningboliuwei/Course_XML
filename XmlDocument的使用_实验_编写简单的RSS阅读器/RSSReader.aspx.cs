using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用_实验_编写简单的RSS阅读器
{
	using System.Xml;

	public partial class RSSReader : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				gdvRss.DataBind();
			}
		}

		private void ShowRSS(string feedUrl)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(feedUrl); //将RSS加载为XmlDocument对象

			rssXml.Document = doc;
			rssXml.TransformSource = "RSS.xsl"; //指定将RSS显示为Web的XSLT文件
			rssXml.DataBind();
		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("RSSFeed.xml");

			XmlDocument doc = new XmlDocument();
			doc.Load(xmlPath);

			XmlNode feed = doc.CreateElement("Feed");
			XmlAttribute attribute = doc.CreateAttribute("Title");
			attribute.Value = txtTitle.Text.Trim();
			feed.Attributes.Append(attribute);

			attribute = doc.CreateAttribute("Category");
			attribute.Value = drpCategory.Text.Trim();
			feed.Attributes.Append(attribute);

			attribute = doc.CreateAttribute("URL");
			attribute.Value = txtUrl.Text.Trim();
			feed.Attributes.Append(attribute);

			doc.DocumentElement.AppendChild(feed);
			doc.Save(xmlPath);

			Response.Redirect("RSSReader.aspx");
		}

		protected void gdvRss_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (gdvRss.SelectedIndex != -1)
			{
				string feedUrl = gdvRss.Rows[gdvRss.SelectedIndex].Cells[2].Text;

				ShowRSS(feedUrl); //得到网格第3列的值（即URL）);
			}
		}
	}
}