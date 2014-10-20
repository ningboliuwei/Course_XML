<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="XmlReader的使用_实验_VS2012.Default2" ValidateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div align="center">
                <table width="80%">
                    <tr>
                        <td>
                            <asp:TextBox runat="server" ID="txtDoc" TextMode="MultiLine" Height="600px" Width="100%" Text="请在此处输入要验证的XML文档"></asp:TextBox></td>
                        <td>
                            <asp:TextBox runat="server" ID="txtSchema" TextMode="MultiLine" Height="600px" Width="100%" Text="请在此处输入用于验证的XML Schema文档"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button runat="server" ID="btnValidate" Text="有效性验证" OnClick="btnValidate_Click" /><asp:Label runat="server" ID="lblInfo"></asp:Label></td>
                    </tr>
                </table>

            </div>
        </form>
    </body>
</html>