<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
    <title>Displaying XML Data in Nested DataList Controls</title>
</head>
<body>    
  <form id="Form1" runat="server">
    <h1>Bookstore: Fiction</h1>
    <asp:XmlDataSource id="MySource" DataFile="Bookstore.xml" 
      XPath="bookstore/genre/book" runat="server"/>
    <asp:DataList id="DataList1" DataSourceId="MySource" runat="server">
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
