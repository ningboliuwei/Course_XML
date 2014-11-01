<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RSSReader.aspx.cs" Inherits="XmlDocument的使用_实验_编写简单的RSS阅读器.RSSReader" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <b>添加RSS FEED：</b>
            </p>
            标题:
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br />
            类别:
                <asp:DropDownList runat="server" ID="drpCategory">
                    <asp:ListItem>博客</asp:ListItem>
                    <asp:ListItem>新闻</asp:ListItem>
                    <asp:ListItem>软件</asp:ListItem>
                    <asp:ListItem>数码</asp:ListItem>
                    <asp:ListItem>电商</asp:ListItem>
                </asp:DropDownList><br />
            URL:
            <asp:TextBox ID="txtUrl" runat="server" Width="250px"></asp:TextBox>
            <br />
            样式：
            <asp:DropDownList ID="ddlStyles" runat="server">
            </asp:DropDownList>
            <br />

            <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" />

            <p>
                <asp:GridView runat="server" ID="gdvRss" DataSourceID="dtsRss" EnableModelValidation="True" OnSelectedIndexChanged="gdvRss_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </p>
            <asp:XmlDataSource ID="dtsRss" runat="server" DataFile="RSSFeed.xml" XPath="Feeds/Feed"></asp:XmlDataSource>
            <asp:Xml ID="rssXml" runat="server"></asp:Xml>
        </div>
    </form>
</body>
</html>
