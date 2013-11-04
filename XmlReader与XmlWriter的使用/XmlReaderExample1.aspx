<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlReaderExample1.aspx.cs" Inherits="XmlReader与XmlWriter的使用.XmlReaderExample1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click"
                Text="显示节点" />
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>

