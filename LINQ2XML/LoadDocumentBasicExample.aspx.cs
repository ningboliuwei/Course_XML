using System;
using System.Web.UI;
using System.Xml.Linq;

namespace LINQ2XML
{
    public partial class LoadDocumentExample : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLoadDocument_OnClick(object sender, EventArgs e)
        {
            var filePath = Server.MapPath("books.xml");

            try
            {
                var xDocument = XDocument.Load(filePath);
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
                var xDocument = XDocument.Load(txtUrl.Text);
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
                var xDocument = XDocument.Parse(txtInput.Text);
                txtOutput.Text = xDocument.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}