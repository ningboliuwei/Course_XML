using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebService的使用.WXMobileCodeService;

namespace WebService的使用
{
    public partial class InvokeExample_MobileCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnQuery_Click(object sender, EventArgs e)
        {
            WXMobileCodeService.MobileCodeWS service = new MobileCodeWS();

            lblResult.Text = service.getMobileCodeInfo(mobileCode.Text, "");
        }
    }
}