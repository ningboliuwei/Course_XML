using System;
using System.Linq;
using System.Web.UI;
using System.Xml.Linq;

namespace LINQ2XML
{
    public partial class QueryExample : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected XDocument GetXDoc()
        {
            var filePath = Server.MapPath("books.xml");

            try
            {
                return XDocument.Load(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected void btnGetTitles_OnClick(object sender, EventArgs e)
        {
            gdvResult.DataSource = from t in GetXDoc().Descendants("title")
                select t.Value.ToUpper();
            gdvResult.DataBind();
        }

        protected void btnGetChildrenTitles_OnClick(object sender, EventArgs e)
        {
            gdvResult.DataSource = from b in GetXDoc().Descendants("book")
                where b.Attribute("genre")?.Value == "children"
                select b.Element("title")?.Value;

            gdvResult.DataBind();
        }

        protected void btnGetMaxPrice_OnClick(object sender, EventArgs e)
        {
            Response.Write((from p in GetXDoc().Descendants("price")
                select Convert.ToSingle(p.Value)).Max());
            gdvResult.DataBind();
        }

        protected void btnOrderByPrice_OnClick(object sender, EventArgs e)
        {
            gdvResult.DataSource = from b in GetXDoc().Descendants("book")
                let p = Convert.ToSingle(b.Element("price")?.Value)
                orderby p descending
                select new {b.Element("title")?.Value, p};
            gdvResult.DataBind();
        }

        protected void btnGroupByGenre_OnClick(object sender, EventArgs e)
        {
            gdvResult.DataSource = from b in GetXDoc().Descendants("book")
                let n = b.Attribute("genre")?.Value
                let t = b.Element("title")?.Value
                group t by n
                into g
                select new {g.Key, Count = g.Count()};

            gdvResult.DataBind();
        }

        protected void btnGetAveragePrice_OnClick(object sender, EventArgs e)
        {
            gdvResult.DataSource = (from p in GetXDoc().Descendants("price")
                select Convert.ToSingle(p.Value)).ToList().Average();
            gdvResult.DataBind();
        }

        protected void btnGetAveragePriceGroupByGenre_OnClick(object sender, EventArgs e)
        {
            var q = from b in GetXDoc().Descendants("book")
                group b by b.Attribute("genre")?.Value
                into g
                select new {g.Key, AveragePrice = g.Average(b => Convert.ToDouble(b.Element("price")?.Value))};

            gdvResult.DataSource = q;

            gdvResult.DataBind();
        }
    }
}