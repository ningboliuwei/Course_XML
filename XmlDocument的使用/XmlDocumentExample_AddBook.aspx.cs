#region

using System;
using System.IO;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_AddBook : Page
	{
		protected void btnSave_Click(object sender, EventArgs e)
		{
			string xmlPath = Server.MapPath("NewBooks.xml");
			XmlDocument doc = new XmlDocument();
			//检查要写入的文件是否存在，若存在，则加载此文档到 XmlDocument 对象中
			if (File.Exists(xmlPath))
			{
				try
				{
					doc.Load(xmlPath);
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
				//若不存在，则直接在 XmlDocument 对象中创建 XML 声明节点与根节点 bookstore。
			else
			{
				//创建声明节点
				XmlNode declarationNode = doc.CreateXmlDeclaration("1.0", "", "");
				//将声明节点添加到文档中
				doc.AppendChild(declarationNode);
				//创建 bookstore 节点
				XmlNode bookstoreNode = doc.CreateElement("bookstore");
				//将 bookestore 节点作为根节点添加到文档中
				doc.AppendChild(bookstoreNode);
			}

			XmlNode bookNode = CreateBookNode(doc);
			//创建一个 book 节点，并添加为 bookstore 节点的子节点
			XmlNode bookStoreNode = doc.SelectSingleNode("bookstore");
			bookStoreNode.AppendChild(bookNode);
			lblResult.Text = "XML 文档已被成功创建";

			try
			{
				//将 XmlDocument 对象以 XML 文档的形式保存
				doc.Save(xmlPath);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private XmlNode CreateBookNode(XmlDocument doc)
		{
			//创建 book 节点
			XmlNode bookNode = doc.CreateElement("book");
			//为 book 节点添加 genre 属性
			XmlAttribute genreAttribute = doc.CreateAttribute("genre");
			genreAttribute.Value = txtGenre.Text;
			bookNode.Attributes.Append(genreAttribute);

			//为 book 节点添加 titile 节点          
			XmlNode titleNode = doc.CreateElement("title");
			titleNode.InnerText = txtTitle.Text;
			bookNode.AppendChild(titleNode);

			//为 book 节点添加 author 节点及其子节点 first_name 和 last-name
			XmlNode authorNode = doc.CreateElement("author");
			XmlNode firstNameNode = doc.CreateElement("first-name");
			firstNameNode.InnerText = txtFirstName.Text;
			authorNode.AppendChild(firstNameNode);
			XmlNode lastNameNode = doc.CreateElement("last-name");
			lastNameNode.InnerText = txtLastName.Text;
			authorNode.AppendChild(lastNameNode);
			bookNode.AppendChild(authorNode);

			//为 book 节点添加 price 节点
			XmlNode priceNode = doc.CreateElement("price");
			priceNode.InnerText = txtPrice.Text;
			bookNode.AppendChild(priceNode);

			return bookNode;
		}
	}
}