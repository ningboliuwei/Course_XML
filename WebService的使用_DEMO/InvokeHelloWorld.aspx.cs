#region

using System;
using System.Web.UI;

#endregion

namespace WebService的使用_DEMO
{
	public partial class InvokeHelloWorld : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnInvoke_Click(object sender, EventArgs e)
		{
			HelloWorldService.HelloWorldWebService service = new HelloWorldService.HelloWorldWebService();

			string result = service.HelloWorld();
			Response.Write(result);
		}
	}
}