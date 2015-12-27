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
			string filePath = Server.MapPath("books.xml");

			try
			{
				XDocument xDocument = XDocument.Load(filePath);
				txtOutput.Text = xDocument.ToString();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}



		protected void btnLoadUrl_OnClick(object sender, EventArgs e)
		{
			try
			{
                XDocument xDocument = XDocument.Load(txtUrl.Text);
                txtOutput.Text = xDocument.ToString();
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
                XDocument xDocument = XDocument.Parse(txtInput.Text);
			    txtOutput.Text = xDocument.ToString();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}