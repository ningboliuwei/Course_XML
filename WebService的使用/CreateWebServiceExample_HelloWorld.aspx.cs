using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService的使用
{
	public partial class CreateWebServiceExample_HelloWorld : System.Web.UI.Page
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