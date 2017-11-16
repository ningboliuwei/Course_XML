<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookCRUD.aspx.cs" Inherits="LINQ2XML_DEMO.BookCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Title: <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br/>
        Genre: <asp:DropDownList ID="drpGenre" runat="server">
            <asp:ListItem Value="philosophy">philosophy</asp:ListItem>
            <asp:ListItem Value="children">children</asp:ListItem>
            <asp:ListItem Value="web">web</asp:ListItem>
        </asp:DropDownList>
        <br/>
        Author's first-name：<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br/>
        Author's last-name：<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br/>
        Price：<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br/>
        <asp:Button ID="btnPreviousRecord" runat="server" Text="Previous" OnClick="btnPreviousRecord_OnClick"></asp:Button>
        <asp:Button ID="btnNextRecord" runat="server" Text="Next" OnClick="btnNextRecord_OnClick"></asp:Button>
        <asp:Button ID="btnAddRecord" runat="server" Text="Add" OnClick="btnAddRecord_OnClick"></asp:Button>
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_OnClick"></asp:Button>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_OnClick"></asp:Button>

        <br/>
        <asp:Label ID="lblInfo" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
