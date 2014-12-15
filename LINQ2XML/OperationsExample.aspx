<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperationsExample.aspx.cs" Inherits="LINQ2XML.OperationsExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		Title：<asp:TextBox ID="txtTitle" runat="server"></asp:TextBox><br/>
		Genre：<asp:TextBox ID="txtGenre" runat="server"></asp:TextBox><br/>
		First-Name：<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br/>
		Last-Name：<asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br/>
		Price:<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br/>
		<asp:TextBox ID="txtNo" runat="server" Width="23px"></asp:TextBox><asp:Button ID="btnDisplay" runat="server" Text="显示" OnClick="btnDisplay_Click" />
		<br/>
		<br/>
		<asp:Button ID="btnDelete" runat="server" Text="删除 book 节点" OnClick="btnDelete_OnClick"/><br/>
		<br/>
		<asp:Button ID="btnUpdate" runat="server" Text="修改 title 节点" OnClick="btnUpdate_OnClick"/><br/>
		


    </div>
    </form>
</body>
</html>
