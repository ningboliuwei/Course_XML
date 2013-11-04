<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlReaderExample_DisplayDoc.aspx.cs" Inherits="XmlReader与XmlWriter的使用.XmlReaderExample_DisplayDoc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="显示节点" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
