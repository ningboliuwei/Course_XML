﻿#region

using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

#endregion

namespace XmlDocument的使用_实验_使用XmlDocument编辑XML文档
{
	public partial class _CellphoneEditor : Page
	{
		private const string fileName = "Cellphone.xml";
		public static int index = 0;

		private void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (GetRecordCount() == 0)
				{
					ClearForm();
				}
				else
				{
					DisplayRecord(0);
				}
			}
		}

		protected void btnPreviousRecord_Click(object sender, EventArgs e)
		{
			DisplayRecord(--index);
		}

		protected void btnNextRecord_Click(object sender, EventArgs e)
		{
			DisplayRecord(++index);
		}


		private void AddRecord()
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();
			XmlNode node;
			XmlNode parentNode;
			XmlAttribute attr;

			try
			{
				doc.Load(filePath);

				parentNode = doc.DocumentElement;
				node = doc.CreateElement("手机");
				parentNode.AppendChild(node);
				parentNode = node;
				node = doc.CreateElement("品牌");
				attr = doc.CreateAttribute("型号");
				attr.Value = txtModel.Text.Trim();
				node.Attributes.Append(attr);
				node.InnerText = txtBrand.Text.Trim();
				parentNode.AppendChild(node);

				node = doc.CreateElement("部分技术参数");
				parentNode.AppendChild(node);

				parentNode = node;
				node = doc.CreateElement("手机类型");
				node.InnerText = dplType.SelectedValue;
				parentNode.AppendChild(node);

				node = doc.CreateElement("兼容网络制式");
				parentNode.AppendChild(node);
				parentNode = node;

				for (int i = 0; i < cblNetwork.Items.Count; i++)
				{
					if (cblNetwork.Items[i].Selected)
					{
						node = doc.CreateElement("网络制式");
						node.InnerText = cblNetwork.Items[i].Text;
						parentNode.AppendChild(node);
					}
				}

				parentNode = parentNode.ParentNode;

				node = doc.CreateElement("体积");
				parentNode.AppendChild(node);

				parentNode = node;
				node = doc.CreateElement("长");
				node.InnerText = txtLength.Text.Trim();
				parentNode.AppendChild(node);

				node = doc.CreateElement("宽");
				node.InnerText = txtWidth.Text.Trim();
				parentNode.AppendChild(node);

				node = doc.CreateElement("厚");
				node.InnerText = txtThickness.Text.Trim();
				parentNode.AppendChild(node);

				parentNode = parentNode.ParentNode;

				node = doc.CreateElement("重量");
				node.InnerText = txtWeight.Text.Trim();
				parentNode.AppendChild(node);

				parentNode = parentNode.ParentNode;

				node = doc.CreateElement("售价");
				node.InnerText = txtPrice.Text.Trim();
				parentNode.AppendChild(node);

				doc.Save(filePath);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}


		private void UpdateRecord()
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();
			XmlNode node;
			XmlNode parentNode;
			XmlAttribute attr;

			try
			{
				doc.Load(filePath);

				parentNode = doc.DocumentElement;
				node = doc.GetElementsByTagName("品牌")[index];
				node.InnerText = txtBrand.Text.Trim();

				attr = node.Attributes[0];
				attr.Value = txtModel.Text.Trim();

				node = doc.GetElementsByTagName("手机类型")[index];
				node.InnerText = dplType.Text;

				parentNode = doc.GetElementsByTagName("兼容网络制式")[index]; ;
				parentNode.RemoveAll();
				foreach (ListItem listItem in cblNetwork.Items)
				{
					if (listItem.Selected)
					{
						node = doc.CreateElement("网络制式");
						node.InnerText = listItem.Text;
						parentNode.AppendChild(node);
					}
				}

		
				node = doc.GetElementsByTagName("长")[index];
				node.InnerText = txtLength.Text.Trim();

				node = doc.GetElementsByTagName("宽")[index];
				node.InnerText = txtWidth.Text.Trim();

				node = doc.GetElementsByTagName("厚")[index];
				node.InnerText = txtThickness.Text.Trim();

				node = doc.GetElementsByTagName("重量")[index];
				node.InnerText = txtWeight.Text.Trim();

				node = doc.GetElementsByTagName("售价")[index];
				node.InnerText = txtPrice.Text.Trim();

				doc.Save(filePath);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
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
				nodeList = doc.SelectNodes("/手机信息/手机");
				node = nodeList[index];

				node.ParentNode.RemoveChild(node);
				doc.Save(filePath);
			}
			catch (Exception err)
			{
				lblInfo.Text = err.Message;
			}
		}

		private int GetRecordCount()
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();
			XmlNodeList nodeList;
			int recordCount;

			try
			{
				doc.Load(filePath);

				nodeList = doc.SelectNodes("/手机信息/手机");
				recordCount = nodeList.Count;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return recordCount;
		}

		private void DisplayRecord(int index)
		{
			string filePath = Server.MapPath(fileName);
			XmlDocument doc = new XmlDocument();
			XmlNode node;
			XmlNodeList nodeList;
			int recordCount = GetRecordCount();


			try
			{
				doc.Load(filePath);

				nodeList = doc.SelectNodes("/手机信息/手机/品牌");
				txtBrand.Text = nodeList[index].FirstChild.Value;
				txtModel.Text = nodeList[index].Attributes["型号"].Value;

				nodeList = doc.GetElementsByTagName("手机类型");
				dplType.SelectedValue = nodeList[index].FirstChild.Value;

				nodeList = doc.GetElementsByTagName("兼容网络制式");
				node = nodeList[index];
				nodeList = node.ChildNodes;

				for (int i = 0; i < cblNetwork.Items.Count; i++)
				{
					cblNetwork.Items[i].Selected = false;
				}

				for (int j = 0; j < nodeList.Count; j++)
				{
					for (int i = 0; i < cblNetwork.Items.Count; i++)
					{
						if (nodeList[j].InnerText == cblNetwork.Items[i].Text)
						{
							cblNetwork.Items[i].Selected = true;
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

				//lblInfo.Text = "共有 " + recordCount + " 条记录，当前是第 " + (index + 1) + " 条记录";
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			SetButtonEnable();
		}

		private void SetButtonEnable()
		{
			int recordCount = GetRecordCount();

			if (recordCount == 0)
			{
				btnDelete.Enabled = false;
				btnNextRecord.Enabled = false;
				btnPreviousRecord.Enabled = false;
			}
			else
			{
				btnDelete.Enabled = true;
				btnNextRecord.Enabled = true;
				btnPreviousRecord.Enabled = true;
			}

			if (index == 0)
			{
				btnPreviousRecord.Enabled = false;
			}
			else
			{
				btnPreviousRecord.Enabled = true;
			}

			if (index == recordCount - 1)
			{
				btnNextRecord.Enabled = false;
			}
			else
			{
				btnNextRecord.Enabled = true;
			}
		}

		protected void btnDelete_Click(object sender, EventArgs e)
		{
			DeleteRecord(index);
			if (GetRecordCount() != 0)
			{
				DisplayRecord(--index);
			}
			else
			{
				ClearForm();
			}
		}

		private void ClearForm()
		{
			txtBrand.Text = "";
			txtModel.Text = "";
			dplType.SelectedIndex = 0;

			for (int i = 0; i < cblNetwork.Items.Count; i++)
			{
				cblNetwork.Items[i].Selected = false;
			}

			txtLength.Text = "";
			txtWidth.Text = "";
			txtThickness.Text = "";
			txtWeight.Text = "";
			txtPrice.Text = "";
		}

		protected void btnClear_Click(object sender, EventArgs e)
		{
			ClearForm();
		}

		protected void btnAdd_Click(object sender, EventArgs e)
		{
			AddRecord();
			DisplayRecord(GetRecordCount() - 1);
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
		///     设计器支持所需的方法 - 不要使用代码编辑器修改
		///     此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			btnPreviousRecord.Click += btnPreviousRecord_Click;
			btnNextRecord.Click += btnNextRecord_Click;
			Load += Page_Load;
		}

		#endregion

		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateRecord();
		}
	}
}