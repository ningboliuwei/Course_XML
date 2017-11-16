#region

using System;
using System.Data;
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

			gdvResult.DataSource = service.GetDataTable(txtTableName.Text.Trim());
			gdvResult.DataBind();
		}
	}
}