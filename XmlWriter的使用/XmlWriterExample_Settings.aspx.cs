#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlWriter的使用
{
	public partial class XmlWriterExample_Settings : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnWrite_Click(object sender, EventArgs e)
		{
			string xmlFilePath = Server.MapPath("Employees4WriteWithFormat.xml"); //得到要写入的文件在服务器磁盘上的绝对路径
			XmlWriter writer = null; //声明一个XmlWriter类型的对象writer

			try
			{
				XmlWriterSettings settings = new XmlWriterSettings(); //创建一个XmlWriterSettings对象
				//设置保留缩进
				settings.Indent = true; //保留缩进
				settings.ConformanceLevel = ConformanceLevel.Auto;
					//设置一致性级别，详见：http://msdn.microsoft.com/zh-cn/library/50f80zbz(v=vs.110).aspx
				settings.IndentChars = "\t"; //设置缩进字符为\t（Tab键）
				settings.OmitXmlDeclaration = false; //设置自动编写XML声明

				writer = XmlWriter.Create(xmlFilePath, settings); //创建XmlWriter对象，参数为要写入的文件路径

				//开始写XML文档
				writer.WriteStartDocument(false); //写入XML声明，其中参数控制standalone的值（true/false）
				writer.WriteComment("This XML file represents the details of an employee"); //写入注释
				//从根节点开始
				writer.WriteStartElement("employees"); //写入根元素employees的开始标签
				writer.WriteStartElement("employee"); //写入元素employee的开始标签
				writer.WriteAttributeString("id", "1"); //在employee元素中写入属性：id="1"
				writer.WriteStartElement("name"); //写入元素name的开始标签
				writer.WriteElementString("firstName", "Nancy"); //写入元素字符串<firstName>Nancy</firstName>
				writer.WriteElementString("lastName", "Davolio"); //写入元素字符串<lastName>Davolio</lastName>
				writer.WriteEndElement(); //写入结束标签（name元素的）
				writer.WriteElementString("city", "Seattle"); //写入元素字符串<city>Seattle</city>
				writer.WriteElementString("state", "WA"); //写入元素字符串<state>WA</state>
				writer.WriteElementString("zipCode", "98122"); //写入元素字符串<zipCode>98122</zipCode>
				writer.WriteEndElement(); //写入结束标签（employee的）
				writer.WriteEndDocument(); //写入结束标签（根元素employees的）
				//将对象数据写入XML文档中
				writer.Flush();
				//在页面上输出成功信息
				Response.Write("文件写入成功");
			}
			catch (Exception ex) //捕捉异常
			{
				Response.Write(ex.Message); //输出异常消息
			}
			finally
			{
				if (writer != null) //若writer对象不为null
				{
					writer.Close(); //关闭XmlWriter
				}
			}
		}
	}
}