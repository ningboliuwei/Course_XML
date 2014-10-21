#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlReader的使用_实验_VS2012
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void LoadData()
		{
			string xmlFilePath = Server.MapPath(@"Customers.xml");

			XmlReader reader = null;

			try
			{
				reader = XmlReader.Create(xmlFilePath);

				//此处写使用Reader的代码
			}
			catch (Exception exception)
			{
				throw new Exception(exception.Message);
			}
			finally
			{
				if (reader != null)
				{
					reader.Close();
				}
			}


			//try
			//{
			//	XmlReader reader = XmlReader.Create(xmlFilePath);

			//	while (reader.Read())
			//	{
			//		if (reader.NodeType == XmlNodeType.Element)
			//		{
			//			switch (reader.Name)
			//			{
			//				case "Name":
			//					txtName.Text = reader.ReadString();
			//					break;
			//				case "Email":
			//					txtEmail.Text = reader.ReadString();
			//					break;
			//				case "Street":
			//					txtStreet.Text = reader.ReadString();
			//					break;
			//				case "City":
			//					txtCity.Text = reader.ReadString();
			//					break;
			//				case "State":
			//					txtState.Text = reader.ReadString();
			//					break;
			//				case "ZipCode":
			//					txtZipCode.Text = reader.ReadString();
			//					break;
			//				case "OrderNumber":
			//					txtOrderNumber.Text = reader.ReadString();
			//					break;
			//				case "OrderDate":
			//					txtOrderDate.Text = reader.ReadString();
			//					break;
			//				case "ItemCost":
			//					txtItemCost.Text = reader.ReadString();
			//					break;
			//				case "ItemPrice":
			//					txtItemPrice.Text = reader.ReadString();
			//					break;
			//				case "Customer":
			//					if (reader.HasAttributes)
			//					{
			//						txtCustomerID.Text = reader.GetAttribute("CustomerID");
			//					}
			//					break;
			//				case "OrderDetails":
			//					if (reader.HasAttributes)
			//					{
			//						txtOrderNumber.Text = reader.GetAttribute("OrderNumber");
			//						txtOrderDate.Text = reader.GetAttribute("OrderDate");
			//					}
			//					break;
			//				case "OrderItem":
			//					if (reader.HasAttributes)
			//					{
			//						txtSKUNumber.Text = reader.GetAttribute("SKUNumber");
			//						txtItemNumber.Text = reader.GetAttribute("ItemNumber");
			//					}
			//					break;
			//			}
			//		}
			//	}
			//	reader.Close();
			//}
			//catch (Exception ex)
			//{
			//	Response.Write(ex.Message);
			//}
		}
	}
}