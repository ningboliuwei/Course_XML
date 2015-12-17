<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperationTest.aspx.cs" Inherits="WebService上课演示.OperationTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p><asp:TextBox runat="server" id="txtX"></asp:TextBox></p>
        <p><asp:TextBox runat="server" id="txtY"></asp:TextBox></p>
        <p><asp:Button runat="server" id="btnOK" Text="+" OnClick="btnOK_Click"/></p>
         <p><asp:Button runat="server" id="btnSub" Text="-" OnClick="btnSub_OnClick"/></p>
        <p><asp:Label runat="server" ID="lblResult"></asp:Label></p>
    </div>
    </form>
</body>
</html>
