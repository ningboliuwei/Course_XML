#region

using System;
using System.Web.UI;

#endregion

namespace WebService的使用
{
	public partial class CreateWebServiceExample_HelloWorld : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnInvoke_Click(object sender, EventArgs e)
		{
			HelloWorldService.HelloWorldWebService helloWorldService = new HelloWorldService.HelloWorldWebService();

			Response.Write(helloWorldService.HelloWorld());
		}
	}
}