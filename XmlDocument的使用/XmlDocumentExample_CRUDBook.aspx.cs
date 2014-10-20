#region

using System;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlDocument的使用
{
	public partial class XmlDocumentExample_CRUDBook : Page
	{
		private const string fileName = "books.xml"; //要读取的文件名
		public static int index = 0; //当前节点的索引值（下标）注意static

		protected void Page_Load(object sender, EventArgs e)
		{
			//第一次加载本页面时，显示XML文档中的第一条记录
			if (!Page.IsPostBack)
			{
				DisplayRecord(index);
			}
		}

		protected void btnPreviousRecord_Click(object sender, EventArgs e)
		{
			DisplayRecord(--index); //显示上一条记录
		}


		protected void btnNextRecord_Click(object sender, EventArgs e)
		{
			DisplayRecord(++index); //显示下一条记录
		}


		private void DeleteRecord(int index)
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();
			XmlNodeList nodeList;
			XmlNode node;

			try
			{
				doc.Load(filePath);
				nodeList = doc.SelectNodes("/bookstore/book");
				node = nodeList[index];

				node.ParentNode.RemoveChild(node);
				doc.Save(filePath);
				//此处有什么缺陷？如何解决？
			}
			catch (Exception err)
			{
				lblResult.Text = err.Message;
			}
		}

		protected void DisplayRecord(int index)
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();

			XmlNodeList nodeList;
			int recordCount;

			try
			{
				doc.Load(filePath);

				nodeList = doc.GetElementsByTagName("book"); //获得Xml文档中所有的名为"book"的节点的集合
				dplGenre.SelectedValue = nodeList[index].Attributes["genre"].Value; //获得第index个book节点中名为genre属性的属性值

				nodeList = doc.GetElementsByTagName("title");
				txtTitle.Text = nodeList[index].FirstChild.Value; //因为title元素中的文本值是单独作为一个子元素来处理，所以使用FirstChild属性

				nodeList = doc.GetElementsByTagName("author"); //获得名为"author"的节点集合

				txtFirstName.Text = nodeList[index].FirstChild.FirstChild.Value; //获得first-name节点的文本值
				txtLastName.Text = nodeList[index].FirstChild.NextSibling.FirstChild.Value; //获得last-name节点的文本值


				nodeList = doc.GetElementsByTagName("price"); //获得名为"price"的节点集合
				txtPrice.Text = nodeList[index].InnerText; //也可以通过XmlNode的InnerText获得元素的文本值


				recordCount = doc.SelectNodes(@"/bookstore/book").Count;
				//通过XmlDocument的SelectNodes方法，XPath作为参数，得到相应的节点（集合）

				lblResult.Text = "共有 " + recordCount + " 条记录，当前是第 " + (index + 1) + " 条记录";

				if (index == 0)
				{
					btnPreviousRecord.Enabled = false; //若当前处于第一条记录，设置“上一条记录”按钮不可用
				}
				else
				{
					btnPreviousRecord.Enabled = true; //若当前不处于第一条记录，设置“上一条记录”按钮可用
				}

				if (index == recordCount - 1)
				{
					btnNextRecord.Enabled = false; //若当前处于最后一条记录，设置“下一条记录”按钮不可用
				}
				else
				{
					btnNextRecord.Enabled = true; //若当前不处于最后一条记录，设置“下一条记录”按钮可用
				}
			}
			catch (Exception exception)
			{
				lblResult.Text = exception.Message;
			}
		}

		protected void btnSave_Click(object sender, EventArgs e)
		{
		}

		protected void btnDeleteRecord_Click(object sender, EventArgs e)
		{
			DeleteRecord(index);
		}
	}
}