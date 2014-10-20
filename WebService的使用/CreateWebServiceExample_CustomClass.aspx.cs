#region

using System;
using System.Web.UI;

#endregion

namespace WebService的使用
{
	public partial class CreateWebServiceExample_CustomClass : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			CustomClassService.CustomClassWebService customClassService = new CustomClassService.CustomClassWebService();
			CustomClassService.Address address = customClassService.GetAddress(txtStreet.Text, txtCity.Text, txtCountry.Text,
				Convert.ToInt32(txtZIP.Text));

			lblResult.Text = address.Street + ", " + address.City + ", " + address.Country + "，" + address.ZIP;
		}
	}
}