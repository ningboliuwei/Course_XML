using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;

namespace XmlReader与XmlWriter的使用
{
    public partial class XmlReaderExample_Validation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            //XML文件所在位置
            string xmlFilePath = Server.MapPath(@"Docs\Books.xml");

            //创建XmlReaderSettings对象，并设置适合的属性
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add("Books.xsd");
            settings.IgnoreWhitespace = false;



            try
            {
                //引用XMLReader对象，并指定设置
                XmlReader reader = XmlReader.Create(xmlFilePath, settings);

                while (reader.Read())
                {
                    lblResult.Text += reader.Value;
                    lblResult.Text += "<br/>";

                }
            }
            catch (Exception ex)
            {
                lblResult.Text = "An Exception: " + ex.Message;
            }
        }
    }
}