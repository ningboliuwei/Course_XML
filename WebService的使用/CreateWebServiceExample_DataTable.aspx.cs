#region

using System;
using System.Web.UI;

#endregion

namespace WebService的使用
{
	public partial class CreateWebServiceExample_DataTable : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
			DataTableService.DataTableWebService service = new DataTableService.DataTableWebService();
			gdvResult.DataSource = service.GetDataSet(txtTableName.Text);
			gdvResult.DataBind();
		}
	}
}