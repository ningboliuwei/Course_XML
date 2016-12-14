<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDisplayExample_GridViewDataSource.aspx.cs" Inherits="XML的显示.XmlDisplayExample_GridViewDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:XmlDataSource ID=xmlDataSource1 runat=server ></asp:XmlDataSource>
                <asp:GridView ID="gridView1" runat=server AutoGenerateColumns="False" EnableModelValidation="True" DataSourceID="xmlDataSource1"  >
                    <Columns>
                        <asp:BoundField DataField="ISBN" HeaderText="ISBN" />
                        <asp:BoundField DataField="Title" HeaderText="TITLE" />
                        <asp:BoundField DataField="Price" HeaderText="PRICE" />
                    </Columns>
                </asp:GridView>
            </div>
        </form>
    </body>
</html>