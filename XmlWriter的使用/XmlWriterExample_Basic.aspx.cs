﻿#region

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
			XmlWriter xmlWriter = XmlWriter.Create("D:\\basic.xml");

            xmlWriter.WriteStartDocument();

            //*************第一部分演示*************
            //            xmlWriter.WriteElementString("city", "Seattle");
            //*************第一部分演示*************

            //*************第二部分演示*************
            //            xmlWriter.WriteStartElement("name");
            //            xmlWriter.WriteString("John Smith");
            //            xmlWriter.WriteEndElement();
            //*************第二部分演示*************

            //*************第二部分演示*************
            //            xmlWriter.WriteStartElement("name");
            //            xmlWriter.WriteElementString("first_name", "Nancy");
            //            xmlWriter.WriteElementString("last_name", "Smith");
            //            xmlWriter.WriteEndElement();
            //*************第二部分演示*************

            //*************第三部分演示*************
            //            xmlWriter.WriteStartElement("Order");
            //            xmlWriter.WriteStartAttribute("Date");
            //            xmlWriter.WriteString("2016-11-10");
            //            xmlWriter.WriteEndAttribute();
            //*************第三部分演示*************

            //*************第四部分演示*************
            //            xmlWriter.WriteStartElement("Order");
            //            xmlWriter.WriteAttributeString("Date", "2016-11-11");
            //*************第四部分演示*************

            //*************第五部分演示*************
            xmlWriter.WriteStartElement("Student");
            
            //以下三行代码可以用一行 xmlWriter.WriteAttributeString("ID", "95001"); 代替
            xmlWriter.WriteStartAttribute("ID");
            xmlWriter.WriteString("95001");
            xmlWriter.WriteEndAttribute();
			xmlWriter.WriteElementString("Name", "John Smith");
			xmlWriter.WriteEndElement();
            //*************第五部分演示*************

			xmlWriter.WriteEndDocument();
			xmlWriter.Close();

            xmlWriter.WriteElementString("Name", "John Smith");
			xmlWriter.WriteAttributeString("Date", "2014-10-25");
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}