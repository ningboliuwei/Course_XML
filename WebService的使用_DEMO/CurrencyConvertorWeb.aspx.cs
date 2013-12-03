using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService的使用_DEMO
{
	using WebService的使用_DEMO.XCurrencyConvertor;

	public partial class CurrencyConvertorWeb : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

	

		protected void btnConvert_Click(object sender, EventArgs e)
		{
			double fromAmout = Convert.ToDouble(txtFromAmount.Text);
			double toAmount;
			double conversionRate;

			XCurrencyConvertor.Currency currencyFrom;
			XCurrencyConvertor.Currency currencyTo;

			XCurrencyConvertor.CurrencyConvertor currencyConvertor = new CurrencyConvertor();
			currencyFrom = (Currency)Enum.Parse(typeof(Currency), drpFromCurrency.Text);//将选择的货币转换成相应的枚举型
			currencyTo = (Currency)Enum.Parse(typeof(Currency), drpToCurrency.Text);//将选择的货币转换成相应的枚举型
			conversionRate = currencyConvertor.ConversionRate(currencyFrom, currencyTo);
			toAmount = fromAmout * conversionRate;
			txtToAmount.Text = toAmount.ToString("F2");
		}
	}
}