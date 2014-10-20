<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeAddWebService.aspx.cs" Inherits="WebService的使用_DEMO.InvokeAddWebService" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox runat="server" ID="txtX"></asp:TextBox>
                <asp:TextBox runat="server" ID="txtY"></asp:TextBox>
                <asp:Button runat="server" ID="btnAdd" Text="Add" OnClick="btnAdd_Click"/>
            </div>
        </form>
    </body>
</html>