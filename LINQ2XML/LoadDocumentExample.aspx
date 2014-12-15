<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadDocumentExample.aspx.cs" Inherits="LINQ2XML.LoadDocumentExample" ValidateRequest="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<p><asp:Button ID="btnLoadDocument" runat="server" Text="从文件加载 XML 文档" OnClick="btnLoadDocument_OnClick" /></p>
			<p><asp:TextBox ID="txtUrl" runat="server" Width="300px"></asp:TextBox><asp:Button ID="btnLoadUrl" runat="server" Text="从 Url 加载 XML 文档" OnClick="btnLoadUrl_OnClick" /></p>
			<p><asp:TextBox ID="txtString" runat="server" TextMode="MultiLine" Height="200px" Width="300px"></asp:TextBox><asp:Button ID="btnLoadString" runat="server" Text="从字符串加载 XML 文档" OnClick="btnLoadString_OnClick" /></p>

		</div>
	</form>
</body>
</html>
