<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDocumentExample_AddBookWithoutExistingFile.aspx.cs" Inherits="XmlDocument的使用.XmlDocumentExample_AddBookWithoutExistingFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td colspan="2" style="width: 174px; height: 40px">
                        <b>Book Details:</b>
                    </td>
                </tr>
                <tr>
                    <td style="width: 101px; height: 44px">Genre:
                    </td>
                    <td style="width: 204px; height: 44px">
                        <asp:TextBox ID="txtGenre" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 101px; height: 44px">Title:
                    </td>
                    <td style="width: 204px; height: 44px">
                        <asp:TextBox ID="txtTitle" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 101px; height: 41px">First Name:
                    </td>
                    <td style="width: 204px; height: 41px">
                        <asp:TextBox ID="txtFirstName" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 101px; height: 41px">Last Name:
                    </td>
                    <td style="width: 204px; height: 41px">
                        <asp:TextBox ID="txtLastName" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 101px; height: 41px">Price:
                    </td>
                    <td style="width: 204px; height: 41px">
                        <asp:TextBox ID="txtPrice" runat="server" Width="201px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="width: 101px; height: 41px">
                        <asp:Button Text="Save" runat="server" ID="btnSave" Width="95px" OnClick="btnSave_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="width: 101px; height: 41px">
                        <asp:Label Text="Save" runat="server" ID="lblResult" Width="295px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
