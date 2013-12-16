using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XML的显示
{
	public partial class XmlDisplayExample_GridViewDataSource : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				xmlDataSource1.DataFile = Server.MapPath("Bookstore.xml");
				xmlDataSource1.XPath = "bookstore/genre/book";
				gridView1.DataSource = xmlDataSource1;
				gridView1.DataBind();
			}
		}
	}
}