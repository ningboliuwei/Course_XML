using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlReader的使用_实验_VS2012
{
	using System.IO;
	using System.Threading;
	using System.Xml;
	using System.Xml.Schema;

	public partial class Default2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnValidate_Click(object sender, EventArgs e)
		{
			this.Validate();
		}

		private void Validate()
		{
			string docContent = txtDoc.Text; //得到左侧文本框中的文本（需要验证的XML文档）
			string schemaContent = txtSchema.Text; //得到右侧文本框中的文本（用于验证XML文档的Schema文档）

			XmlReaderSettings settings = new XmlReaderSettings(); //创建XmlReaderSettings对象（用于设置验证方式）
			settings.ValidationType = ValidationType.Schema;//设置验证方式为Schema

			TextReader schemaTextReader = new StringReader(schemaContent); //创建一个TextReader对象，用于读取右侧文本框中的文本值，并在创建XmlSchema对象时作为构造函数的参数传入

			XmlSchema schema = XmlSchema.Read(schemaTextReader, null);//创建一个XmlSchema对象，并从schemaTextReader对象中获取Schema文本
			settings.Schemas.Add(schema);//将上一行中创建的schema对象添加到settings对象的Schema集合中去

			TextReader docTextReader = new StringReader(docContent);//创建另一个TextReader对象，用于读取左侧侧文本框中的文本值，并在创建XmlReader对象时作为构造函数的参数传入

			XmlReader xmlReader = XmlReader.Create(docTextReader, settings);//创建XmlReader对象

			try
			{
				while (xmlReader.Read())
				{
				}//循环读取每一个XML节点（）
				lblInfo.Text = "验证成功！";//若循环结束时仍未抛出异常，表示验证成功
			}
			catch (Exception exception)
			{
				lblInfo.Text = exception.Message;//若验证时碰到错误，则抛出异常，并显示异常信息
			}
			finally
			{
				xmlReader.Close();
			}
		}
	}
}