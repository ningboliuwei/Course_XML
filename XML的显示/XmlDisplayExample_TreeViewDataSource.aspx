<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDisplayExample_TreeViewDataSource.aspx.cs" Inherits="XML的显示.XmlDisplayExample_TreeViewDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:XmlDataSource ID="xmlDataSource1" runat="server" DataFile="bookstore.xml" />
            <asp:XmlDataSource ID="xmlDataSource2" runat="server" DataFile="bookstore.xml" XPath="bookstore/genre" />
            <asp:XmlDataSource ID="xmlDataSource3" runat="server" DataFile="bookstore.xml" XPath="bookstore/genre/book" />
            <asp:XmlDataSource ID="xmlDataSource4" runat="server" DataFile="bookstore.xml" XPath="bookstore/genre[@name='Fiction']/book" />
            <asp:TreeView ID="treeView1" runat="server" DataSourceID="xmlDataSource1">
                <DataBindings>
                    <asp:TreeNodeBinding DataMember="book" TextField="Title" />
                    <asp:TreeNodeBinding DataMember="genre" TextField="name" />
                    <asp:TreeNodeBinding DataMember="chapter" TextField="name" />
                </DataBindings>
            </asp:TreeView>



        </div>
    </form>
</body>
</html>
