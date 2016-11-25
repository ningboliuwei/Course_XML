#region

using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Services;
using System.Linq;

#endregion

namespace WebService的使用
{
    /// <summary>
    ///     CustomDataArrayWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class CustomDataArrayWebService : WebService
    {
        [WebMethod]
        public List<Address> GetAddresses()
        {
            List<Address> addresses = new List<Address>();
            Address address1 = new Address("解放路", "宁波", "中国", 315000);
            Address address2 = new Address("中山路", "杭州", "中国", 31000);
            Address address3 = new Address("人民路", "杭州", "中国", 31000);

            addresses.Add(address1);
            addresses.Add(address2);
            addresses.Add(address3);

            //返回全部地址
            return addresses;

//            返回杭州的地址
//            return (from a in addresses
//                    where a.City == "杭州"
//                    select a).ToList();

        }
    }
}