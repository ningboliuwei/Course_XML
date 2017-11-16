<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateDocumentBasicExample.aspx.cs" Inherits="LINQ2XML.CreateDocumentExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:Button ID="btnCreateBasic" runat="server" Text="创建简单的 XML 文档" OnClick="btnCreateBasic_OnClick" />
		<asp:Button ID="btnCreate" runat="server" Text="创建稍复杂的 XML 文档" OnClick="btnCreate_OnClick" />
		<asp:Button ID="btnCreate2" runat="server" Text="另一种方式" OnClick="btnCreate2_OnClick" />

		 </div>
	</form>
</body>
</html>
