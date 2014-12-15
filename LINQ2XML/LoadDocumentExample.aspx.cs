using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LINQ2XML
{
	public partial class LoadDocumentExample : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnLoadDocument_OnClick(object sender, EventArgs e)
		{
			string filePath = "r:\\books.xml";

			try
			{
				XElement xElement = XElement.Load(filePath);

				Response.Write(xElement);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}



		protected void btnLoadUrl_OnClick(object sender, EventArgs e)
		{
			string url = txtUrl.Text.Trim();

			try
			{
				XElement xElement = XElement.Load(url);

				Response.Write(xElement);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected void btnLoadString_OnClick(object sender, EventArgs e)
		{
			try
			{
				XElement xElement = XElement.Parse(txtString.Text);

				Response.Write(xElement);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}