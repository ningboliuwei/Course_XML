#region

using System;
using System.Text;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlWriter的使用_实验
{
	public partial class CustomerWriter : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnWrite_Click(object sender, EventArgs e)
		{
			string xmlFilePath = Server.MapPath("Customers4WriteWithFormat.xml");
			XmlWriter writer = null;

			try
			{
				//zaici

				XmlWriterSettings settings = new XmlWriterSettings();
				settings.Indent = true;
				settings.IndentChars = "\t";
				settings.Encoding = Encoding.UTF8;

				writer = XmlWriter.Create(xmlFilePath, settings);

				writer.WriteStartDocument();
				writer.WriteStartElement("Customers");
				writer.WriteStartElement("Customer");
				writer.WriteAttributeString("CustomerID", txtCustomerID.Text);
				writer.WriteStartElement("CustomerInfo");
				writer.WriteElementString("Name", txtName.Text);
				writer.WriteElementString("Email", txtEmail.Text);
				writer.WriteStartElement("Address");
				writer.WriteElementString("Street", txtStreet.Text);
				writer.WriteElementString("City", txtCity.Text);
				writer.WriteElementString("State", txtState.Text);
				writer.WriteElementString("ZipCode", txtZipCode.Text);
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteStartElement("Orders");
				writer.WriteStartElement("Order");
				writer.WriteStartElement("OrderDetails");
				writer.WriteAttributeString("OrderNumber", txtOrderNumber.Text);
				writer.WriteAttributeString("OrderDate", txtOrderDate.Text);
				writer.WriteStartElement("OrderItems");
				writer.WriteStartElement("OrderItem");
				writer.WriteAttributeString("SKUNumber", txtSKUNumber.Text);
				writer.WriteAttributeString("ItemNumber", txtItemNumber.Text);
				writer.WriteElementString("ItemCost", txtItemCost.Text);
				writer.WriteElementString("ItemPrice", txtItemPrice.Text);
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndElement();
				writer.WriteEndDocument();

				writer.Flush();

				lblInfo.Text = "文件已写入成功";
			}
			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}
			finally
			{
				if (writer != null)
				{
					writer.Close();
				}
			}
		}
	}
}