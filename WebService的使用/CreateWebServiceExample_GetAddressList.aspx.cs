using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService的使用
{
	public partial class CreateWebServiceExample_GetAddressList : System.Web.UI.Page
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