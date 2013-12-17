using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XML显示_DEMO
{
	public partial class GridViewDisplay : System.Web.UI.Page
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