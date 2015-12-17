using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService上课演示
{
	public partial class OperationTest : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
			OperationService.Operation operation = new OperationService.Operation();

			lblResult.Text = operation.Add(int.Parse(txtX.Text), int.Parse(txtY.Text)).ToString();

		}

		protected void btnSub_OnClick(object sender, EventArgs e)
		{
			OperationService.Operation operation = new OperationService.Operation();

			lblResult.Text = operation.Sub(int.Parse(txtX.Text), int.Parse(txtY.Text)).ToString();

		}
	}
}