<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateWebServiceExample_CustomClass.aspx.cs" Inherits="WebService的使用.CreateWebServiceExample_CustomClass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Street:
            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox><br />
            City:
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />
            Country:
            <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox><br />
            ZIP:
            <asp:TextBox ID="txtZIP" runat="server"></asp:TextBox><br />
            <asp:Label runat="server" ID="lblResult"></asp:Label><br />
            <asp:Button ID="btnAdd" runat="server" Text="确定" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>
