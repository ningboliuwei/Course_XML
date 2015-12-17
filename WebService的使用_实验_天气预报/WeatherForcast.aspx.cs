#region

using System;
using System.Web.UI;
using WebService的使用_实验_天气预报.weatherService;

#endregion

namespace WebService的使用_实验_天气预报
{
	public partial class WeatherForcast : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				LoadProvince();
				LoadCity(drpProvince.Text); //将省份下拉菜单中的选中项作为参数传入
			}
		}

		private void LoadProvince()
		{
			weatherService.WeatherWS service;
			string[] provinces; //此字符串数组用于保存支持的所有省份/洲名称

			try
			{
				service = new WeatherWS(); //创建Web服务代理对象
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			provinces = service.get();
			//通过调用Web服务的getSupportProvince()方法，得到所有支持的省份/洲名称，
			//并以字符串数组的形式存放在provinces中

			drpProvince.DataSource = provinces; //将字符串数组作为下拉菜单的数据源
			drpProvince.DataBind(); //调用省份下拉菜单的DataBind()方法，显示所有的省份/洲
		}

		private void LoadCity(string provinceName)
		{
			WeatherWS service;
			string[] cities; //此字符串数组用于保存支持的所有城市名称

			try
			{
				service = new WeatherWS(); //创建Web服务代理对象
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			cities = service.getSupportCityString(provinceName);
			//通过调用Web服务的getSupportCity()方法，传入省份/洲名，得到所有支持的城市名称，
			//并以字符串数组的形式存放在cities中

			drpCity.DataSource = cities; //将字符串数组作为下拉菜单的数据源
			drpCity.DataBind(); //调用城市下拉菜单的DataBind()方法，显示所有的省份/洲
		}

		protected void drpProvince_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadCity(drpProvince.Text);
		}

		private void DisplayWeather(string cityName)
		{
			weatherService.WeatherWS service;
			string[] weatherStatus; //此字符串数组用于保存各天气情况

			try
			{
				service = new WeatherWS(); //创建Web服务代理对象
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			weatherStatus = service.getSupportCityString(cityName);
			//通过调用Web服务的getWeatherbyCityName()方法，传入城市名，得到该城市的天气情况，
			//并以字符串数组的形式存放在weatherStatus中
			Label1.Text = weatherStatus[10];
			Label2.Text = weatherStatus[6] + "&nbsp;&nbsp;&nbsp;" + weatherStatus[5] + "&nbsp;&nbsp;&nbsp;"
			              + weatherStatus[7];
			Label3.Text = weatherStatus[13] + "&nbsp;&nbsp;&nbsp;" + weatherStatus[12] + "&nbsp;&nbsp;&nbsp;"
			              + weatherStatus[14];
			Label4.Text = weatherStatus[18] + "&nbsp;&nbsp;&nbsp;" + weatherStatus[17] + "&nbsp;&nbsp;&nbsp;"
			              + weatherStatus[19];
			Label5.Text = weatherStatus[11].Replace("\n", "<br />");
			//Label6.Text = weatherStatus[22].Replace(Chr[10], "<br />");
			Label7.Text = Convert.ToDateTime(weatherStatus[4]).ToString("yyyy年MM月dd日 dddd HH:mm");
			Label8.Text = weatherStatus[0] + " / " + weatherStatus[1];
			Image1.ImageUrl = "images/weather/" + weatherStatus[8];
			Image2.ImageUrl = "images/weather/" + weatherStatus[9];
			Image3.ImageUrl = "images/weather/" + weatherStatus[15];
			Image4.ImageUrl = "images/weather/" + weatherStatus[16];
			Image5.ImageUrl = "images/weather/" + weatherStatus[20];
			Image6.ImageUrl = "images/weather/" + weatherStatus[21];
		}

		protected void drpCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			string cityName = drpCity.Text.Split('(')[0];
			//由于城市下拉菜单中，所有的选项都是 “城市名（xxxx）”的形式，所以
			//只需要得到“（”前的城市名，利用String类的Split()方法可以分离出城市名
			//关于该方法的具体介绍，按F1，参见MSDN
			DisplayWeather(cityName); //将城市下拉菜单中的选项作为参数传入
		}
	}
}