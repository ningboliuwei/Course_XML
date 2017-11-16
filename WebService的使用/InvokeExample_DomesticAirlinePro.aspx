<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeExample_DomesticAirlinePro.aspx.cs" Inherits="WebService的使用.InvokeExample_DomesticAirlinePro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            始发地：<asp:DropDownList runat="server" ID="drpFrom"/><br />
            目的地：<asp:DropDownList runat="server" ID="drpTo"/><br />
            出发日期：<asp:Calendar ID="calDate" runat="server"></asp:Calendar>
            <asp:Button runat="server" ID="btnQuery" Text="查询" OnClick="btnQuery_Click" /><br />
            <asp:GridView ID="grdAirlines" runat="server">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
