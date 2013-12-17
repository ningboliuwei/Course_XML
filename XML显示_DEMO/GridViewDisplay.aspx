<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewDisplay.aspx.cs" Inherits="XML显示_DEMO.GridViewDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1" EnableModelValidation="True">
            <Columns>
                <asp:BoundField DataField="ISBN" HeaderText="ISBN" SortExpression="ISBN" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
            </Columns>
        </asp:GridView>
        <asp:XmlDataSource ID="XmlDataSource2" runat="server" DataFile="Bookstore.xml" XPath="/bookstore/genre"></asp:XmlDataSource>
        <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Bookstore.xml" XPath="/bookstore/genre/book"></asp:XmlDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="XmlDataSource2" DataTextField="name" DataValueField="name">
        </asp:DropDownList>
        <br />
        <asp:TextBox runat="server" ID="txtGenre"></asp:TextBox>
        <asp:Button runat="server" ID="btnSearch" Text="搜索" OnClick="btnSearch_Click"/>
    </div>
    </form>
</body>
</html>
