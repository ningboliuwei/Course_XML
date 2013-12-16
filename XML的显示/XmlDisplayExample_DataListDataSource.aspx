<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDisplayExample_DataListDataSource.aspx.cs" Inherits="XML的显示.XmlDisplayExample_DataListDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>    
  <form id="Form1" runat="server">
    <h1>Bookstore: Fiction</h1>
    <asp:XmlDataSource id="MySource" DataFile="Bookstore.xml" 
      XPath="bookstore/genre/book" runat="server"/>
    <asp:DataList id="DataList1" DataSourceId="MySource" runat="server" RepeatColumns="2">
      <ItemTemplate>
        <table>
          <tr>
            <td>
              <img src='<%# "images/" + XPath("@ISBN") + ".jpg" %>'>
            </td>
            <td>
              <h4><%# XPath("@Title") %></h4>
              <b>ISBN:</b> <%# XPath("@ISBN") %><br>
              <b>Price:</b> <%# XPath("@Price") %><br>
            </td>
          </tr>
        </table>
          <asp:DataList id="DataList2" DataSource='<%# XPathSelect("chapter") %>' runat="server">
            <ItemTemplate>
              <br>
              <u>
                Chapter <%# XPath("@num") %>: 
                <%# XPath("@name") %>
              </u>
              <br>
              <%# XPath(".") %>
            </ItemTemplate>
          </asp:DataList>
      </ItemTemplate>
    </asp:DataList>

  </form>
</body>
</html>
