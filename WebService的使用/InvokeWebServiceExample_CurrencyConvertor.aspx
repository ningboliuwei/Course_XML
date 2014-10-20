<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeWebServiceExample_CurrencyConvertor.aspx.cs" Inherits="WebService的使用.InvokeWebServiceExample_CurrencyConvertor" %>

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
                    From:&nbsp;&nbsp;
                    <asp:DropDownList runat="server" ID="drpFromCurrency">
                        <asp:ListItem Text="CNY" />
                        <asp:ListItem Text="USD" />
                        <asp:ListItem Text="GBP" />
                        <asp:ListItem Text="EUR" />
                        <asp:ListItem Text="HKD" />
                    </asp:DropDownList><asp:TextBox runat="server" ID="txtFromAmount"></asp:TextBox>&nbsp;&nbsp;
                    <asp:Button runat="server" ID="btnConvert" Text="Convert" OnClick="btnConvert_Click" />&nbsp;&nbsp;
                    To:&nbsp;&nbsp;
                    <asp:DropDownList runat="server" ID="drpToCurrency">
                        <asp:ListItem Text="CNY" />
                        <asp:ListItem Text="USD" />
                        <asp:ListItem Text="GBP" />
                        <asp:ListItem Text="EUR" />
                        <asp:ListItem Text="HKD" />
                    </asp:DropDownList><asp:TextBox runat="server" ID="txtToAmount"></asp:TextBox>
                </p>
            </div>
        </form>
    </body>
</html>