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
			XDocument xdoc = new XDocument(
				new XDeclaration("1.0", "UTF-8", "yes"),
				new XElement("bookstore", 
					new XElement("book", 
						new XElement("author", "J. K")))
				);

			xdoc.Save("R:\\e1.xml");
		}
	}
}