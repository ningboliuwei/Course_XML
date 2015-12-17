using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML_DEMO
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void Button1_OnClick(object sender, EventArgs e)
		{
			int[] array = { 3, 5, 6, 9, 12, 4, 8 };

			var nums = from num in array where num >= 5 select num;


			foreach (var n in nums)
			{
				Response.Write(n + ",");
			}

		}
	}
}