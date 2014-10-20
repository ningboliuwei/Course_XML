#region

using System.ComponentModel;
using System.Web.Services;

#endregion

namespace WebService的使用_DEMO
{
	/// <summary>
	///     AddWebService 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class AddWebService : WebService
	{
		[WebMethod]
		public int Add(int x, int y)
		{
			return x + y;
		}
	}
}