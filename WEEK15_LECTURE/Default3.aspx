﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
