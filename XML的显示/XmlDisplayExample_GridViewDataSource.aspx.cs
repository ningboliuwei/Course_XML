﻿#region

using System;
using System.Web.UI;

#endregion

namespace XML的显示
{
    public partial class XmlDisplayExample_GridViewDataSource : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                xmlDataSource1.DataFile = Server.MapPath("Bookstore.xml");
                xmlDataSource1.XPath = "bookstore/genre/book";
                gridView1.DataBind();

            }
        }
    }
}