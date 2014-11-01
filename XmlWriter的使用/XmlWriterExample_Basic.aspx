<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlWriterExample_Basic.aspx.cs" Inherits="XmlWriter的使用.XmlWriterExample_Basic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button runat="server" ID="btnWriter" Text="写入XML文档" OnClick="btnWriter_OnClick"/>
    </div>
    </form>
</body>
</html>
