using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlReader与XmlWriter的使用
{
	using System.Xml;

	public partial class XmlReaderExample1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnDisplay_Click(object sender, EventArgs e)
		{
			//利用Server.MapPath()获得要读取的XML文件所在磁盘位置的绝对路径
			string xmlFilePath = Server.MapPath(@"Customers.xml");

			try
			{
				//创建一个XMLReader对象
				//注意：XmlReader对象无法利用new关键字直接调用构造函数创建
				XmlReader reader = XmlReader.Create(xmlFilePath);

				string result = ""; //用于显示输出信息的字符串变量

				while (reader.Read()) //循环读取被解析的XML文档的每一个节点
				{
					//演示第一步开始
					//if (reader.NodeType == XmlNodeType.Element) //仅处理元素节点
					//{
					//	//result += reader.Name + "<br/>";//每输出一次元素节点的名称就换行
					//}
					//演示第一步结束


					//演示第二步开始
					//如何显示当前元素的值？reader.Value属性可以吗？
					if (reader.NodeType == XmlNodeType.Element) //仅处理元素节点
					{
						result += reader.Value + "<br/>";//每输出一次元素节点的元素值就换行
					}
					//演示第二步结束

					//演示第三步开始
					if (reader.NodeType == XmlNodeType.Text) //仅处理元素节点
					{
						result += reader.Value + "<br/>";//每输出一次文本节点的元素值就换行
					}
					//演示第三步结束


					//演示第三步

					//result = "";

					//for (int count = 1; count <= reader.Depth; count++)
					//{
					//	result += "===";
					//}

					//result += "=>" + reader.Name;
					//lblResult.Text += result;

					//lblResult.Text += "<br/>";

					lblResult.Text = result;
				}
			}
			catch (Exception ex)
			{
				lblResult.Text = "An Exception: " + ex.Message;
			}
		}
	}

}