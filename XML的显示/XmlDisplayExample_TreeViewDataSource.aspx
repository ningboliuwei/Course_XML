<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDisplayExample_TreeViewDataSource.aspx.cs" Inherits="XML的显示.XmlDisplayExample_TreeViewDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
		<asp:XmlDataSource ID=xmlDataSource1 runat=server DataFile=bookstore.xml TransformFile=bookstore.xsl />
		 <asp:TreeView ID=treeView1 runat=server DataSourceID="xmlDataSource1" />
		 
    </div>
    </form>
</body>
</html>
