<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListDisplay.aspx.cs" Inherits="XML显示_DEMO.DataListDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>

                <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Bookstore.xml" XPath="/bookstore/genre/book"></asp:XmlDataSource>
                <asp:DataList ID="DataList1" runat="server" DataSourceID="XmlDataSource1" RepeatColumns="2">
                    <ItemTemplate>
                        <table width="300px" border="1">
                            <tr>
                                <td rowspan="2">
                                    <img src='<%# "images/" + XPath("@ISBN") + ".jpg" %>' /></td>
                                <td><font color="red">TITLE:<%# XPath("@Title") %>></font></td>
                            </tr>
                            <tr>
                                <td>ISBN:<%# XPath("@ISBN") %><br />
                                    Price:<%# "$" + XPath("@Price") %><asp:DataList ID="DataList2" runat="server" DataSource='<%# XPathSelect("chapter") %>'>
                                                                         <ItemTemplate>
                                                                             <br />
                                                                             <u>Chapter <%# XPath("@num") %> : <%# XPath("@name") %>

                                                                             </u>
                                                                             <br />
                                                                             <%# XPath(".") %>
                                                                         </ItemTemplate>
                                                                     </asp:DataList>



                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
                <br />

            </div>
        </form>
    </body>
</html>