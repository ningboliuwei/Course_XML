#region

using System;
using System.Web.UI;
using WebService的使用.XCurrencyConvertor;

#endregion

namespace WebService的使用
{
	public partial class InvokeWebServiceExample_CurrencyConvertor : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		}

		protected void btnConvert_Click(object sender, EventArgs e)
		{
			double fromAmount = Convert.ToDouble(txtFromAmount.Text);
			double toAmount;
			double converstionRate;
			Currency fromCurrency;
			Currency toCurrency;

			CurrencyConvertor currencyConvertor = new CurrencyConvertor();
			//string conversionRate = currencyConvertor.ConversionRate(Currency.)); 不能直接这么写
			fromCurrency = (Currency) Enum.Parse(typeof (Currency), drpFromCurrency.Text); //将选择的货币转换成相应的枚举型
			toCurrency = (Currency) Enum.Parse(typeof (Currency), drpToCurrency.Text);

			converstionRate = currencyConvertor.ConversionRate(fromCurrency, toCurrency); //调用Web服务的ConversionRate方法，得到汇率
			toAmount = fromAmount*converstionRate;
			txtToAmount.Text = toAmount.ToString("F2"); //输出转换后的数量
		}
	}
}