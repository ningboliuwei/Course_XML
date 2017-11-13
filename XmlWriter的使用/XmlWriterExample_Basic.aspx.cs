#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlWriter的使用
{
    public partial class XmlWriterExample_Basic : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnWriter_OnClick(object sender, EventArgs e)
        {
            var xmlWriter = XmlWriter.Create(@"C:\XML_DEMO\basic.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Student");
            //以下三行代码可以用一行 xmlWriter.WriteAttributeString("ID", "95001"); 代替
            xmlWriter.WriteStartAttribute("ID");
            xmlWriter.WriteString("95001");
            xmlWriter.WriteEndAttribute();
            
            xmlWriter.WriteElementString("Name", "John Smith");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();

            xmlWriter.WriteElementString("city", "Seattle");

            xmlWriter.WriteStartElement("name");
            xmlWriter.WriteElementString("first_name", "Nancy");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartAttribute("Date");
            xmlWriter.WriteString("2014-10-25");
            xmlWriter.WriteEndAttribute();

            xmlWriter.WriteAttributeString("Date", "2014-10-25");
        }
    }
}