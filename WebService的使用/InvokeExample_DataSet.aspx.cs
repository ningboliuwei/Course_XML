using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService的使用
{
	public partial class CreateWebServiceExample_DataSet : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				DataSetService.DataSetWebService service = new DataSetService.DataSetWebService();
				DataSet ds = service.GetDataSet();

				gdvStudent.DataSource = ds.Tables["Student"];
				gdvStudent.DataBind();

				gdvCourse.DataSource = ds.Tables["Course"];
				gdvCourse.DataBind();

				gdvSC.DataSource = ds.Tables["SC"];
				gdvSC.DataBind();
			}

		}
	}
}