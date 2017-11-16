<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDisplayExample_MenuDataSource.aspx.cs" Inherits="XML的显示.XmlDisplayExample_MenuDataSource" %>

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
                    Maximum Calories:
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:Button OnClick="Button1_Click" ID="Button1" runat="server" Text="Filter Menu"></asp:Button>
                </p>
                <p>
                    <asp:Xml ID="Xml1" runat="server" DocumentSource="Menu.xml" TransformSource="Menu.xsl"></asp:Xml>
                </p>
            </div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </form>
    </body>
</html>