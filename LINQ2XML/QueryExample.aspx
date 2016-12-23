<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryExample.aspx.cs" Inherits="LINQ2XML.QueryExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<asp:Button ID="btnGetTitles" runat="server" Text="得到所有的大写标题" OnClick="btnGetTitles_OnClick"/><br/>
		<asp:Button ID="btnGetChildrenTitles" runat="server" Text="得到所有的儿童书标题" OnClick="btnGetChildrenTitles_OnClick"/><br/>
		<asp:Button ID="btnGetMaxPrice" runat="server" Text="得到所有书的最高价格" OnClick="btnGetMaxPrice_OnClick"/><br/>
		<asp:Button ID="btnOrderByPrice" runat="server" Text="把所有书的标题按照价格从高到低排列" OnClick="btnOrderByPrice_OnClick"/><br/>
		<asp:Button ID="btnGroupByGenre" runat="server" Text="得到每种类型书的个数" OnClick="btnGroupByGenre_OnClick"/><br/>
		<asp:Button ID="btnGetAveragePrice" runat="server" Text="得到每种类型书的平均价格" OnClick="btnGetAveragePrice_OnClick"/><br/>
		<asp:Button ID="btnGetAveragePriceGroupByGenre" runat="server" Text="得到每种类型的书的平均价格" OnClick="btnGetAveragePriceGroupByGenre_OnClick"/>
        <asp:GridView ID="gdvResult" runat="server">
        </asp:GridView>
        <br/>
	




	</div>
	</form>
</body>
</html>
