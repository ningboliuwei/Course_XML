#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlReader与XmlWriter的使用
{
	public partial class XmlReaderExample_DisplayDoc : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			//XML文件所在位置
			string xmlFilePath = Server.MapPath(@"Docs\Employees.xml");
			string employeeID = "";

			try
			{
				//引用XMLReader对象
				XmlReader reader = XmlReader.Create(xmlFilePath);

				lblResult.Text = "<b>Employees</b>";
				lblResult.Text += "<ul/>";

				while (reader.Read())
				{
					//仅处理元素
					if (reader.NodeType == XmlNodeType.Element)
					{
						if (reader.Name == "employee")
						{
							employeeID = reader.GetAttribute("id");
						}

						//

						if (reader.Name == "name")
						{
							lblResult.Text += "<li>" + "Employee - " + employeeID;
							lblResult.Text += "<ul>";
							lblResult.Text += "<li>ID - " + employeeID + "</li>";
						}

						if (reader.Name == "firstName")
						{
							lblResult.Text += "<li>First Name - " + reader.ReadString() + "</li>";
						}

						if (reader.Name == "lastName")
						{
							lblResult.Text += "<li>Last Name - " + reader.ReadString() + "</li>";
						}

						if (reader.Name == "city")
						{
							lblResult.Text += "<li>City - " + reader.ReadString() + "</li>";
						}

						if (reader.Name == "State")
						{
							lblResult.Text += "<li>State - " + reader.ReadString() + "</li>";
						}

						if (reader.Name == "zipCode")
						{
							lblResult.Text += "<li>Zipcode - " + reader.ReadElementContentAsInt() + "</li>";
						}
					}
					else if (reader.NodeType == XmlNodeType.EndElement)
					{
						if (reader.Name == "employee")
						{
							//关闭开始标签
							lblResult.Text += "</ul>";
							lblResult.Text += "</li>";
						}
					}
				}
				lblResult.Text += "</ul>";
			}
			catch (Exception ex)
			{
				lblResult.Text = "An Exception: " + ex.Message;
			}
		}
	}
}