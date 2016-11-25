#region

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Services;

#endregion

namespace WebService的使用
{
	/// <summary>
	///     DataTableWebService 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class DataTableWebService : WebService
	{
		[WebMethod]
		public DataTable GetDataTable(string tableName)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection())
				{
					string connectionString = WebConfigurationManager.AppSettings["connectionString"];
					conn.ConnectionString = connectionString;
					SqlCommand command = new SqlCommand("SELECT * FROM " + tableName, conn);

					SqlDataAdapter adapter = new SqlDataAdapter(command);

					DataSet ds = new DataSet();

					adapter.Fill(ds, tableName);
//					return ds.Tables[tableName];
                    DataTable table = ds.Tables[0];

				    return table;
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}