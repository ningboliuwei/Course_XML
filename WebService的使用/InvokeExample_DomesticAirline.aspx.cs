using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebService的使用.WXDomesticAirlineService;

namespace WebService的使用
{
    public partial class InvokeExample_DomesticAirline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            WXDomesticAirlineService.DomesticAirline service = new DomesticAirline();

            string dateString = txtDate.Text == "" ? DateTime.Now.ToString("yyyy-MM-dd") : txtDate.Text;
            string fromCity = txtFrom.Text;
            string toCity = txtTo.Text;

            DataSet airlines = service.getDomesticAirlinesTime(fromCity, toCity, dateString, "");

            grdAirlines.DataSource = airlines;
            grdAirlines.DataBind();

        }
    }
}