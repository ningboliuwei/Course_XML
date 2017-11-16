using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebService的使用.WXDomesticAirlineService;

namespace WebService的使用
{
    public partial class InvokeExample_DomesticAirlinePro : System.Web.UI.Page
    {
        private WXDomesticAirlineService.DomesticAirline service = new DomesticAirline();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitializeControls();
            }
        }

        protected void InitializeControls()
        {
            calDate.SelectedDate = DateTime.Today;

            //将所有城市显示在出发地下拉菜单中
            drpFrom.DataSource = service.getDomesticCity();
            drpFrom.DataValueField = "Abbreviation";
            drpFrom.DataTextField = "cnCityName";
            drpFrom.DataBind();

            //将所有城市显示在目的地下拉菜单中
            drpTo.DataSource = service.getDomesticCity();
            drpTo.DataValueField = "Abbreviation";
            drpTo.DataTextField = "cnCityName";
            drpTo.DataBind();
        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            grdAirlines.DataSource = service.getDomesticAirlinesTime(drpFrom.Text, drpTo.Text, calDate.SelectedDate.ToString("yyyy-MM-dd"), "");
            grdAirlines.DataBind();
        }
    }
}