<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDocumentExample_AddBook.aspx.cs" Inherits="XmlDocument的使用.XmlDocumentExample_AddBook" %>

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
                    <asp:TextBox runat="server" ID="txtGenre"></asp:TextBox>
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
                    <asp:Button ID="btnSave" runat="server" Text="保存文档" OnClick="btnSave_Click" />
                </p>

            </div>
        </form>
    </body>
</html>