#region

using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Xsl;

#endregion

namespace XML的显示
{
	public partial class XmlDisplayExample_MenuDataSource : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		    if (!Page.IsPostBack)
		    {
		        DropDownList1.Items.Add(new ListItem("GREEN","MenuGreen.xsl"));
                DropDownList1.Items.Add(new ListItem("BLUE", "MenuBlue.xsl"));
            }
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			XsltArgumentList argsList = new XsltArgumentList();
			argsList.AddParam("calories", "", TextBox1.Text);
			Xml1.TransformArgumentList = argsList;
			Xml1.Visible = true;
		}

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Xml1.TransformSource = DropDownList1.SelectedValue;
        }
    }
}