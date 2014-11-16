using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;

namespace WebService的使用
{
	/// <summary>
	/// DataSetWebService 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class DataSetWebService : System.Web.Services.WebService
	{

		[WebMethod]
		public DataSet GetDataSet()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection())
				{
					string connectionString = WebConfigurationManager.AppSettings["connectionString"];
					conn.ConnectionString = connectionString;

					SqlDataAdapter adapter = new SqlDataAdapter();
					DataSet ds = new DataSet();
					adapter.SelectCommand = new SqlCommand("SELECT * FROM Student", conn);
					adapter.Fill(ds, "Student");
					adapter.SelectCommand = new SqlCommand("SELECT * FROM Course", conn);
					adapter.Fill(ds, "Course");
					adapter.SelectCommand = new SqlCommand("SELECT * FROM SC", conn);
					adapter.Fill(ds, "SC");
					return ds;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
