<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateObjectsFromXmlDocument.aspx.cs" Inherits="LINQ2XML.CreateObjectsFromXmlDocument" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnConvert" runat="server" Text="得到所有书的信息（对象数组形式）" OnClick="btnConvert_OnClick"/>
        <br />
        <br />
        <asp:GridView ID="gdvBooks" runat="server">
        </asp:GridView>
        <br/>
    </div>
    </form>
</body>
</html>
