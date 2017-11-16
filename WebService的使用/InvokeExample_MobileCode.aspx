<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeExample_MobileCode.aspx.cs" Inherits="WebService的使用.InvokeExample_MobileCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        手机号码：<asp:TextBox runat="server" id="mobileCode"/><br/>
        <asp:Button runat="server" id="btnQuery" Text="查询" OnClick="btnQuery_Click"/><br/>
        <asp:Label runat="server" ID="lblResult"></asp:Label>
    </div>
    </form>
</body>
</html>
