<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeExample_DomesticAirline.aspx.cs" Inherits="WebService的使用.InvokeExample_DomesticAirline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        始发地：<asp:TextBox runat="server" id="txtFrom"/><br/>
        目的地：<asp:TextBox runat="server" id="txtTo"/><br/>
        出发日期：<asp:TextBox runat="server" id="txtDate"/>
        <asp:Button runat="server" id="btnQuery" Text="查询" OnClick="btnQuery_Click"/><br/>
        <asp:GridView ID="grdAirlines" runat="server">
        </asp:GridView>
        <br />
    </div>
    </form>
</body>
</html>
