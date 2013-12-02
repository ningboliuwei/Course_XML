<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InvokeWebServiceExample_StockQuote.aspx.cs" Inherits="WebService的使用.InvokeWebServiceExample_StockQuote" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	股票代码： <asp:TextBox ID="txtStock" runat=server></asp:TextBox><br />
		股票数据： <asp:TextBox ID="txtInfo" runat=server TextMode=MultiLine Width=500px Height=500px></asp:TextBox><br />
		<asp:Button ID="btnOK" runat=server onclick="btnOK_Click" Text="确定"/>
    </div>
    </form>
</body>
</html>
