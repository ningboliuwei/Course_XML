#region

using System;
using System.Web.UI;

#endregion

namespace XML显示_DEMO
{
	public partial class GridViewDisplay : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				GridView1.DataBind();
			}
		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			XmlDataSource1.XPath = "bookstore/genre[@name='" + DropDownList1.Text + "']/book";
			GridView1.DataBind();
		}
	}
}