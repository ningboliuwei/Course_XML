<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeExample_GetAddressList.aspx.cs" Inherits="WebService的使用.CreateWebServiceExample_GetAddressList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:GridView ID="gdvAddress" runat="server">
                </asp:GridView>
                <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
            </div>
        </form>
    </body>
</html>