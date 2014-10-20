#region

using System;
using System.Web.UI;

#endregion

namespace WebService的使用_DEMO
{
	public partial class InvokeAddWebService : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			AddService.AddWebService service = new AddService.AddWebService();
			int result = service.Add(Convert.ToInt32(txtX.Text), Convert.ToInt32(txtY.Text));
			Response.Write(result);
		}
	}
}