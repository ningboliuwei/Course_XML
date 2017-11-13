#region

using System;
using System.Text;
using System.Web.UI;
using System.Xml;

#endregion

namespace XmlWriter的使用
{
    public partial class XmlWriterExample_Settings : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            var xmlFilePath = Server.MapPath("Employees4WriteWithFormat.xml"); //得到要写入的文件在服务器磁盘上的绝对路径
            XmlWriter writer = null; //声明一个XmlWriter类型的对象writer

            try
            {
                //创建一个XmlWriterSettings对象
                var settings = new XmlWriterSettings
                {
                    //设置编码为 UTF-8
                    Encoding = Encoding.UTF8,
                    //设置保留缩进
                    Indent = true,
                    //设置一致性级别，详见：http://msdn.microsoft.com/zh-cn/library/50f80zbz(v=vs.110).aspx
                    ConformanceLevel = ConformanceLevel.Auto,
                    //设置缩进字符为\t（Tab键）
                    IndentChars = "\t",
                    //设置自动编写XML声明
                    OmitXmlDeclaration = false
                };
                //创建XmlWriter对象，参数为要写入的文件路径
                writer = XmlWriter.Create(xmlFilePath, settings);
                //开始写XML文档
                //写入XML声明，其中参数控制standalone的值（true/false）
                writer.WriteStartDocument(false);
                //写入注释
                writer.WriteComment("This XML file represents the details of an employee");
                //从根节点开始
                //写入根元素employees的开始标签
                writer.WriteStartElement("employees");
                //写入元素employee的开始标签
                writer.WriteStartElement("employee");
                //在employee元素中写入属性：id="1"
                writer.WriteAttributeString("id", "1");
                //写入元素name的开始标签
                writer.WriteStartElement("name");
                //写入元素字符串<firstName>Nancy</firstName>
                writer.WriteElementString("firstName", "Nancy");
                //写入元素字符串<lastName>Davolio</lastName>
                writer.WriteElementString("lastName", "Davolio");
                //写入结束标签（name元素的）
                writer.WriteEndElement();
                //写入元素字符串<city>Seattle</city>
                writer.WriteElementString("city", "Seattle");
                //写入元素字符串<state>WA</state>
                writer.WriteElementString("state", "WA");
                //写入元素字符串<zipCode>98122</zipCode>
                writer.WriteElementString("zipCode", "98122");
                //写入结束标签（employee的）
                writer.WriteEndElement();
                //写入结束标签（根元素employees的）
                writer.WriteEndDocument();
                //将对象数据写入XML文档中
                writer.Flush();
                //在页面上输出成功信息
                Response.Write("文件写入成功");
            }
            catch (Exception ex) //捕捉异常
            {
                //输出异常信息
                Response.Write(ex.Message);
            }
            finally
            {
                //若writer对象不为null
                //关闭XmlWriter
                writer?.Close();
            }
        }
    }
}