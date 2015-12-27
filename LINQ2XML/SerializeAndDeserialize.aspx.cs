using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Serialization;

namespace LINQ2XML
{
    public partial class SerializeAndDeserialize : System.Web.UI.Page
    {
        [Serializable]
        [XmlRoot("Book")] //这表明序列化xml文档时。自定义节点名
        public class Book
        {
            public string Title { get; set; }
            public string Genre { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Price { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSerialize_OnClick(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Title = "红楼梦",
                Genre = "小说",
                FirstName = "曹",
                LastName = "雪芹",
                Price = 9.99
            };


            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (XmlWriter writer = XmlWriter.Create(Server.MapPath("serialized.xml")))
            {
                serializer.Serialize(writer, book);
            }
        }

        protected void btnSerializeCollection_OnClick(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Title = "红楼梦",
                    Genre = "小说",
                    FirstName = "曹",
                    LastName = "雪芹",
                    Price = 9.99
                },
                new Book()
                {
                    Title = "西游记",
                    Genre = "小说",
                    FirstName = "吴",
                    LastName = "承恩",
                    Price = 20.13
                },
                new Book()
                {
                    Title = "三国演义",
                    Genre = "小说",
                    FirstName = "罗",
                    LastName = "贯中",
                    Price = 30.82
                }
            };


            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (XmlWriter writer = XmlWriter.Create(Server.MapPath("serializedList.xml")))
            {
                serializer.Serialize(writer, books);
            }
        }

        protected void btnDeserialize_OnClick(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Book));
            using (XmlReader reader = XmlReader.Create(Server.MapPath("serialized.xml")))
            {
                //can not display in gridview
                gdvResult.DataSource= serializer.Deserialize(reader) as Book;
                gdvResult.DataBind();
            }
        }

        protected void btnDeserializeCollection_OnClick(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (XmlReader reader = XmlReader.Create(Server.MapPath("serializedList.xml")))
            {
                gdvResult.DataSource = serializer.Deserialize(reader) as List<Book>;
                gdvResult.DataBind();
            }
        }
    }
}