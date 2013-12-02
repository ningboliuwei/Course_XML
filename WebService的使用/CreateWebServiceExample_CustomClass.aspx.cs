using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService的使用
{
	public partial class CreateWebServiceExample_CustomClass : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			CustomClassService.CustomClassWebService customClassService = new CustomClassService.CustomClassWebService();
			CustomClassService.Address address = customClassService.GetAddress(txtStreet.Text, txtCity.Text, txtCountry.Text, Convert.ToInt32(txtZIP.Text));

			lblResult.Text = address.Street + ", " + address.City + ", " + address.Country + "，" + address.ZIP;

		}
	}
}