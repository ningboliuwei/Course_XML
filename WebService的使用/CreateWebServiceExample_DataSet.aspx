<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateWebServiceExample_DataSet.aspx.cs" Inherits="WebService的使用.CreateWebServiceExample_DataSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:GridView ID="gdvStudent" runat="server"></asp:GridView>
		<asp:GridView ID="gdvCourse" runat="server"></asp:GridView>
		<asp:GridView ID="gdvSC" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
