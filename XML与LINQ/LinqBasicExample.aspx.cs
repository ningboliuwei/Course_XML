using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LinqBasicExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
	    string[] items = {"A", "B", "C", "D"};
	    var s = from item in items select item;
	    foreach (var item in items)
	    {
		    Response.Write(item.ToString() + "<br/>");
	    }


    }
}