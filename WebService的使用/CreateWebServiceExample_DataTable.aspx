<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateWebServiceExample_DataTable.aspx.cs" Inherits="WebService的使用.CreateWebServiceExample_DataTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:TextBox ID=txtTableName runat=server></asp:TextBox><br />
                <asp:GridView ID="gdvResult" runat=server></asp:GridView><br />
                <asp:Button ID="btnOK" runat=server Text="OK" onclick="btnOK_Click" />
            </div>
        </form>
    </body>
</html>