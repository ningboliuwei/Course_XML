<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XSLTDisplay.aspx.cs" Inherits="XML显示_DEMO.XSLTDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/Menu.xml" TransformSource="~/Menu.xsl"></asp:Xml>
    
    </div>
    </form>
</body>
</html>
