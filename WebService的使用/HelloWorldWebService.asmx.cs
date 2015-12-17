#region

using System.ComponentModel;
using System.Web.Services;

#endregion

namespace WebService的使用
{
	/// <summary>
	///     HelloWorldWebService 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class HelloWorldWebService : WebService
	{
		//如果注释掉下面这行会导致什么结果？
		[WebMethod]
		public string HelloWorld()
		{
			return "Hello World";
		}
	}
}