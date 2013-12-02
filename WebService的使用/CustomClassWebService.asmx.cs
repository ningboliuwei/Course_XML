using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService的使用
{
	/// <summary>
	/// CustomClassWebService 的摘要说明
	/// </summary>
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
	// [System.Web.Script.Services.ScriptService]
	public class CustomClassWebService : System.Web.Services.WebService
	{

		[WebMethod]
		public Address GetAddress(string street, string city, string country, int ZIP)
		{
			Address address = new Address(street, city, country, ZIP);

			return address;
		}

	}
}
