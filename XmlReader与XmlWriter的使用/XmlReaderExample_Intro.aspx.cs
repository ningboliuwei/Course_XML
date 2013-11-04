using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace XmlReader与XmlWriter的使用
{
    using System.Threading;
    using System.Xml;

    public partial class XmlReaderExample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            //利用Server.MapPath()获得要读取的XML文件所在磁盘位置的绝对路径
            string xmlFilePath = Server.MapPath(@"Docs\Customers.xml");

            try
            {
                //创建一个XMLReader对象
                //注意：XmlReader对象无法利用new关键字直接调用构造函数创建
                XmlReader reader = XmlReader.Create(xmlFilePath);

                string result = ""; //用于显示输出信息的字符串变量


                //演示第一步开始——读取所有的元素名称
                //while (reader.Read()) //循环读取被解析的XML文档的每一个节点
                //{
                //    if (reader.NodeType == XmlNodeType.Element) //仅处理元素节点
                //    {
                //        //result += reader.Name + "<br/>";//每输出一次元素节点的名称就换行
                //    }
                //}
                //演示第一步结束


                //演示第二步开始——
                //如何显示当前元素的值？reader.Value属性可以吗？
                //while (reader.Read())
                //{
                //    if (reader.NodeType == XmlNodeType.Element) //仅处理元素节点
                //    {
                //        result += reader.Value + "<br/>"; //每输出一次元素节点的元素值就换行
                //    }
                //}
                //演示第二步结束

                //演示第三步开始——读取所有的文本值
                //while (reader.Read())
                //{
                //    if (reader.NodeType == XmlNodeType.Text) //仅处理文本节点
                //    {
                //        result += reader.Value + "<br/>"; //每输出一次文本节点的元素值就换行
                //    }
                //}
                //引出节点类型（NodeType）的具体概念（F1帮助）
                //可以用单步调试 + 监视观察每次读取的节点
                //演示第三步结束

                //演示第四步开始——读取所有的节点类型
                //while (reader.Read())
                //{
                //    result += reader.NodeType + "<br/>"; //输出每一个节点的NodeType
                //}
                //与对应的XML文档作对比
                //将要解析的文件改为：CustomersWithoutWhiteSpace.xml
                //演示第四步结束

                //演示第五步开始——读取指定节点的值
                //while (reader.Read())
                //{
                //    if (reader.Name == "Name")
                //    {
                //        result += "Customer's Name: " + reader.Value; //这么使用可以吗？
                //    }
                //}
                //演示第五步结束

                //演示第六步开始——读取指定节点的值
                //while (reader.Read())
                //{
                //    if (reader.Name == "Name" && reader.NodeType == XmlNodeType.Element)
                //    {
                //        result += "Customer's Name: " + reader.Value;//这么使用可以吗？
                //        //为什么没有显示值？
                //    }
                //}
                //演示第六步结束

                //演示第七步开始
                //while (reader.Read())
                //{
                //    if (reader.Name == "Name" && reader.NodeType == XmlNodeType.Element)
                //    {
                //        result += "Customer's Name: ";
                //        reader.Read(); //再往后读取一个节点
                //        result += reader.Value;
                //    }
                //}
                //演示第七步结束

                //演示第八步开始——利用XmlNode.ReadString()方法
                //while (reader.Read())
                //{
                //    if (reader.Name == "Name" && reader.NodeType == XmlNodeType.Element)
                //    {
                //        result += "Customer's Name: " + reader.ReadString();
                //    }
                //}
                //演示第八步结束


                //演示第九步开始——利用XmlNode.ReadStartElement()方法
                //reader.Read();
                //reader.Read();
                //reader.Read();
                //reader.Read();
                //reader.Read();
                //reader.ReadStartElement("Name");
                //result += "Customer's Name: " + reader.ReadString();
                //演示第九步结束

                //演示第十步开始——深度（Depth 属性）
                //while (reader.Read())
                //{
                //    result += reader.Depth + "<br/>";
                //}
                //演示第十步结束


                //演示第十一步开始——深度（Depth 属性）
                //while (reader.Read())
                //{
                //    string currentLine = "";

                //    for (int count = 1; count <= reader.Depth; count++)
                //    {
                //        currentLine += "===";
                //    }

                //    currentLine += "=>" + reader.Name + "<br/>";
                //    result += currentLine;


                //}

                //演示第十一步结束

                //演示第十二步开始——深度改进（对于文本节点的处理）
                //while (reader.Read())
                //{
                //    string currentLine = "";

                //    for (int count = 1; count <= reader.Depth; count++)
                //    {
                //        currentLine += "&nbsp;&nbsp;&nbsp;&nbsp;";
                //    }

                //    string nodeString = "";

                //    switch (reader.NodeType)
                //    {
                //        case XmlNodeType.Element:
                //            nodeString = "&lt;" + reader.Name + "&gt;";
                //            break;
                //        case XmlNodeType.EndElement:
                //            nodeString = "&lt;/" + reader.Name + "&gt;";
                //            break;
                //        case XmlNodeType.Text:
                //            nodeString = reader.Value;
                //            break;
                //    }
                //    currentLine += nodeString + "<br/>";
                //    result += currentLine;


                //}

                //演示第十二步结束

                //演示第十三步——HasAttribute属性
                //while (reader.Read())
                //{
                //    if (reader.HasAttributes)
                //    {
                //        reader.MoveToFirstAttribute();
                //        result += reader.Name + " = " + reader.Value + "<br/>";
                //    }
                //    //存在什么问题？
                //}
                //演示第十三步结束

                //演示第十四步——多个属性的处理
                //while (reader.Read())
                //{
                //    if (reader.HasAttributes)
                //    {
                //        while (reader.MoveToNextAttribute())
                //        {
                //            result += reader.Name + " = " + reader.Value + "<br/>";
                //        }
                //    }
                //    //存在什么问题？
                //}
                //演示第十四步结束

                //演示第十五步开始——多个Attribute的处理
                while (reader.Read())
                {
                    string currentLine = "";

                    for (int count = 1; count <= reader.Depth; count++)
                    {
                        currentLine += "&nbsp;&nbsp;&nbsp;&nbsp;";
                    }

                    string nodeString = "";

                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.HasAttributes)
                            {
                                nodeString += "&lt;" + reader.Name;

                                while (reader.MoveToNextAttribute())
                                {
                                    nodeString += " " + reader.Name + "=\"" + reader.Value + "\"";
                                }
                            }
                            else
                            {
                                nodeString += "&lt;" + reader.Name;
                            }
                            //nodeString += "&gt;";

                            //演示第十六步——对空元素的处理
                            if (reader.IsEmptyElement)
                            {
                                nodeString += "/&gt;";
                            }
                            else
                            {
                                nodeString += "&gt;";
                            }
                            //演示第十六步结束
                            break;
                        case XmlNodeType.EndElement:
                            nodeString = "&lt;/" + reader.Name + "&gt;";
                            break;
                        case XmlNodeType.Text:
                            nodeString = reader.Value;
                            break;
                    }
                    currentLine += nodeString + "<br/>";
                    result += currentLine;
                }

                //演示第十五步结束



                lblResult.Text = result; //将要输出的信息显示在页面上
                reader.Close(); //调用XmlReader.Close()方法，关闭对于文件的占用
            }
            catch (Exception ex)
            {
                lblResult.Text = "An Exception: " + ex.Message;
            }
            finally
            {
            }
        }
    }
}