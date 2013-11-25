using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlDocument的使用_使用XmlDocument读取XML文档_实验
{
	using System.Xml;

	public partial class _Default : System.Web.UI.Page
	{
		private static int index;//声明索引变量（静态变量）

		private const string fileName = "Cellphone.xml";//指定要读取的XML文档的文件名

		private void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack) //如果是第一次加载页面
			{
				#region 简版不需要的代码

				//if (GetRecordCount() == 0)//如果记录数为0
				//{
				//	ClearForm();//清空页面
				//}
				//else
				//{
				//	DisplayRecord(0);//显示第一条记录
				//}

				#endregion

				this.DisplayRecord(index);
			}
		}

		#region Web 窗体设计器生成的代码

		protected override void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}

		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnPreviousRecord.Click += new System.EventHandler(this.btnPreviousRecord_Click);
			this.btnNextRecord.Click += new System.EventHandler(this.btnNextRecord_Click);
			this.Load += new System.EventHandler(this.Page_Load);
		}

		#endregion

		protected void btnPreviousRecord_Click(object sender, EventArgs e)
		{
			DisplayRecord(--index);//显示上一条记录（并同时修改索引值）
		}

		protected void btnNextRecord_Click(object sender, EventArgs e)
		{
			DisplayRecord(++index);//显示下一条记录（并同时修改索引值）
		}

		//用于获取XML文档中记录的条数
		private int GetRecordCount()
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();//创建一个XmlDocument对象
			XmlNodeList nodeList;//声明一个XmlNodeList类型的变量，用于保存一系列XmlNode节点

			try
			{
				doc.Load(filePath);

				nodeList = doc.SelectNodes("/手机信息/手机");//获得所有的名为“手机”的节点的集合
				if (nodeList != null)
				{
					return nodeList.Count;
				}

				return 0;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

		}

		//用于显示指定索引的记录
		private void DisplayRecord(int index)
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();
			XmlNode node;
			XmlNodeList nodeList;

			dplType.Text = "直板";

			try
			{
				doc.Load(filePath);

				nodeList = doc.SelectNodes("/手机信息/手机/品牌");
				txtBrand.Text = nodeList[index].FirstChild.Value;
				txtModel.Text = nodeList[index].Attributes["型号"].Value;

				nodeList = doc.GetElementsByTagName("手机类型");
				dplType.SelectedValue = nodeList[index].FirstChild.Value;

				nodeList = doc.GetElementsByTagName("兼容网络制式");//得到所有名为“兼容网络制式”的节点的集合
				node = nodeList[index];//利用一个XmlNode对象保存当前记录的“兼容网络制式”节点
				nodeList = node.ChildNodes;//用NodeList对象保存“兼容网络制式”节点的所有子节点

				for (int i = 0; i < cblNetwork.Items.Count; i++)//先将所有的复选框设置为非选中状态
				{
					cblNetwork.Items[i].Selected = false;
				}

				for (int j = 0; j < nodeList.Count; j++)//遍历XML文档中“兼容网络制式”下的所有子节点（即在当前记录中出现所有的制式）
				{
					for (int i = 0; i < cblNetwork.Items.Count; i++)//遍历复选框中“兼容网络制式”下的所有项目，
					{
						if (nodeList[j].InnerText == cblNetwork.Items[i].Text)//如果当前“网络制式”节点文本与当前复选框的文本相同
						{
							cblNetwork.Items[i].Selected = true;//设置为选中状态
						}
					}
				}

				nodeList = doc.GetElementsByTagName("长");
				txtLength.Text = nodeList[index].FirstChild.Value;

				nodeList = doc.GetElementsByTagName("宽");
				txtWidth.Text = nodeList[index].FirstChild.Value;

				nodeList = doc.GetElementsByTagName("厚");
				txtThickness.Text = nodeList[index].FirstChild.Value;

				nodeList = doc.GetElementsByTagName("重量");
				txtWeight.Text = nodeList[index].FirstChild.Value;

				nodeList = doc.GetElementsByTagName("售价");
				txtPrice.Text = nodeList[index].FirstChild.Value;

				lblInfo.Text = "共有 " + this.GetRecordCount() + " 条记录，当前是第 " + (index + 1) + " 条记录";
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			SetButtonEnable();//改变页面上所有按钮的可用状态
		}

		private void SetButtonEnable()
		{
			int recordCount = GetRecordCount();

			#region 简版不需要的代码
			if (recordCount == 0)
			{
				#region 简版不需要的代码
				//btnDelete.Enabled = false;
				#endregion
				btnNextRecord.Enabled = false;
				btnPreviousRecord.Enabled = false;
			}
			else
			{
				#region 简版不需要的代码
				//btnDelete.Enabled = true;
				#endregion
				btnNextRecord.Enabled = true;
				btnPreviousRecord.Enabled = true;
			}
			#endregion

			if (index == 0)//当前处于第一条记录
			{
				btnPreviousRecord.Enabled = false;
			}
			else
			{
				btnPreviousRecord.Enabled = true;
			}

			if (index == recordCount - 1)//当前处于最后一条记录
			{
				btnNextRecord.Enabled = false;
			}
			else
			{
				btnNextRecord.Enabled = true;
			}
		}

		#region 此简版不需要的代码

		//private void AddRecord()
		//{
		//	string filePath = Server.MapPath(fileName);
		//	XmlDocument doc = new XmlDocument();
		//	XmlNode node;
		//	XmlNode parentNode;
		//	XmlAttribute attr;

		//	try
		//	{
		//		doc.Load(filePath);

		//		parentNode = doc.DocumentElement;
		//		node = doc.CreateElement("手机");
		//		parentNode.AppendChild(node);
		//		parentNode = node;
		//		node = doc.CreateElement("品牌");
		//		attr = doc.CreateAttribute("型号");
		//		attr.Value = txtModel.Text.Trim();
		//		node.Attributes.Append(attr);
		//		node.InnerText = txtBrand.Text.Trim();
		//		parentNode.AppendChild(node);

		//		node = doc.CreateElement("部分技术参数");
		//		parentNode.AppendChild(node);

		//		parentNode = node;
		//		node = doc.CreateElement("手机类型");
		//		node.InnerText = dplType.SelectedValue;
		//		parentNode.AppendChild(node);

		//		node = doc.CreateElement("兼容网络制式");
		//		parentNode.AppendChild(node);
		//		parentNode = node;

		//		for (int i = 0; i < cblNetwork.Items.Count; i++)
		//		{
		//			if (cblNetwork.Items[i].Selected)
		//			{
		//				node = doc.CreateElement("网络制式");
		//				node.InnerText = cblNetwork.Items[i].Text;
		//				parentNode.AppendChild(node);
		//			}
		//		}

		//		parentNode = parentNode.ParentNode;

		//		node = doc.CreateElement("体积");
		//		parentNode.AppendChild(node);

		//		parentNode = node;
		//		node = doc.CreateElement("长");
		//		node.InnerText = txtLength.Text.Trim();
		//		parentNode.AppendChild(node);

		//		node = doc.CreateElement("宽");
		//		node.InnerText = txtWidth.Text.Trim();
		//		parentNode.AppendChild(node);

		//		node = doc.CreateElement("厚");
		//		node.InnerText = txtThickness.Text.Trim();
		//		parentNode.AppendChild(node);

		//		parentNode = parentNode.ParentNode;

		//		node = doc.CreateElement("重量");
		//		node.InnerText = txtWeight.Text.Trim();
		//		parentNode.AppendChild(node);

		//		parentNode = parentNode.ParentNode;

		//		node = doc.CreateElement("售价");
		//		node.InnerText = txtPrice.Text.Trim();
		//		parentNode.AppendChild(node);

		//		doc.Save(filePath);
		//	}
		//	catch (Exception ex)
		//	{
		//		throw new Exception(ex.Message);
		//	}
		//}

		//private void DeleteRecord(int index)
		//{
		//	string filePath = Server.MapPath(fileName);
		//	XmlDocument doc = new XmlDocument();
		//	XmlNodeList nodeList;
		//	XmlNode node;

		//	try
		//	{
		//		doc.Load(filePath);
		//		nodeList = doc.SelectNodes("/手机信息/手机");
		//		node = nodeList[index];

		//		node.ParentNode.RemoveChild(node);
		//		doc.Save(filePath);

		//		if (this.GetRecordCount() > 0)
		//		{
		//			DisplayRecord(--index);
		//		}
		//		this.SetButtonEnable();//删除记录后，重新设置按钮的可用性
		//	}
		//	catch (Exception err)
		//	{
		//		lblInfo.Text = err.Message;
		//	}
		//}

		//protected void btnDelete_Click(object sender, EventArgs e)
		//{
		//	DeleteRecord(index);
		//	if (GetRecordCount() != 0)
		//	{
		//		DisplayRecord(--index);
		//	}
		//	else
		//	{
		//		ClearForm();
		//	}
		//}

		//private void ClearForm()
		//{
		//	txtBrand.Text = "";
		//	txtModel.Text = "";
		//	dplType.SelectedIndex = 0;

		//	for (int i = 0; i < cblNetwork.Items.Count; i++)
		//	{
		//		cblNetwork.Items[i].Selected = false;
		//	}

		//	txtLength.Text = "";
		//	txtWidth.Text = "";
		//	txtThickness.Text = "";
		//	txtWeight.Text = "";
		//	txtPrice.Text = "";
		//}

		//protected void btnClear_Click(object sender, EventArgs e)
		//{
		//	ClearForm();
		//}

		//protected void btnAdd_Click(object sender, EventArgs e)
		//{
		//	AddRecord();
		//	DisplayRecord(GetRecordCount() - 1);
		//	this.SetButtonEnable();
		//}

		#endregion
	}
}