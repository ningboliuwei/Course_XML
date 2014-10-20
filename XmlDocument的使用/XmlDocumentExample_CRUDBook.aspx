<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDocumentExample_CRUDBook.aspx.cs" Inherits="XmlDocument的使用.XmlDocumentExample_CRUDBook" %>

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
                    Genre:
                    <asp:DropDownList runat="server" ID="dplGenre">
                        <asp:ListItem>autobiography</asp:ListItem>
                        <asp:ListItem>novel</asp:ListItem>
                        <asp:ListItem>philosophy</asp:ListItem>
                    </asp:DropDownList>
                </p>
                <p>
                    Title:
                    <asp:TextBox runat="server" ID="txtTitle"></asp:TextBox>
                </p>
                <p>
                    First Name:
                    <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
                </p>
                <p>
                    Last Name:
                    <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>
                </p>
                <p>
                    Price:
                    <asp:TextBox runat="server" ID="txtPrice"></asp:TextBox>
                </p>
                <p>
                    <asp:Label ID="lblResult" runat="server" />
                </p>
                <p>
                    <asp:Button ID="btnSave" runat="server" Text="保存记录" OnClick="btnSave_Click" />
                    <asp:Button ID="btnPreviousRecord" runat="server" Text="上一条记录" OnClick="btnPreviousRecord_Click" />
                    <asp:Button ID="btnNextRecord" runat="server" Text="下一条记录" OnClick="btnNextRecord_Click" />
                    <asp:Button ID="btnDeleteRecord" runat="server" Text="删除记录" OnClick="btnDeleteRecord_Click" />
                </p>
            </div>
        </form>
    </body>
</html>