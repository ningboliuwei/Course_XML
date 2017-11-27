#region

using System;
using System.Collections.Generic;
using System.Web.UI;

#endregion

namespace WebService的使用
{
	public partial class CreateWebServiceExample_GetAddressList : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
			CustomDataArrayService.CustomDataArrayWebService service = new CustomDataArrayService.CustomDataArrayWebService();

			gdvAddress.DataSource = service.GetAddresses();

			gdvAddress.DataBind();
		}
	}
}