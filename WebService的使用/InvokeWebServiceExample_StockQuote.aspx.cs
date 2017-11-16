#region

using System;
using System.Text;
using System.Web.UI;
using System.Xml;
using WebService的使用.XStockQuote;

#endregion

namespace WebService的使用
{
	public partial class InvokeWebServiceExample_StockQuote : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnOK_Click(object sender, EventArgs e)
		{
			StockQuote service = new StockQuote(); //创建Web Service代理类对象
			string result = service.GetQuote(txtStock.Text); //调用Web Service的GetQuote()方法

			XmlDocument doc = new XmlDocument();
			doc.LoadXml(result); //将返回的字符串加载到XmlDocument对象中（以便进行后续操作）

			//txtInfo.Text = doc.OuterXml;
   
			//第二步开始——用户友好
			string symbol = doc.GetElementsByTagName("Symbol")[0].InnerText;
			string last = doc.GetElementsByTagName("Last")[0].InnerText;
			string date = doc.GetElementsByTagName("Date")[0].InnerText;
			string open = doc.GetElementsByTagName("Open")[0].InnerText;
			string high = doc.GetElementsByTagName("High")[0].InnerText;
			string low = doc.GetElementsByTagName("Low")[0].InnerText;
			string change = doc.GetElementsByTagName("Change")[0].InnerText;
			string percentageChange = doc.GetElementsByTagName("PercentageChange")[0].InnerText;
			string previousClose = doc.GetElementsByTagName("PreviousClose")[0].InnerText;

			StringBuilder builder = new StringBuilder();
			builder.Append("股票代码：")
				.Append(symbol)
				.Append("\n")
				.Append("日期：")
				.Append(date)
				.Append("\n")
				.Append("今收：")
				.Append(last)
				.Append("\n")
				.Append("昨收：")
				.Append(previousClose)
				.Append("\n")
				.Append("今开：")
				.Append(open)
				.Append("\n")
				.Append("最高：")
				.Append(high)
				.Append("\n")
				.Append("最低：")
				.Append(low)
				.Append("\n")
				.Append("涨跌：")
				.Append(change)
				.Append("\n")
				.Append("涨幅：")
				.Append(percentageChange)
				.Append("\n");
			txtInfo.Text = builder.ToString();
			//第二步结束——用户友好
		}
	}
}