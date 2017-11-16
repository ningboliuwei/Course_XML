<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SerializeAndDeserialize.aspx.cs" Inherits="LINQ2XML.SerializeAndDeserialize" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
       
        <asp:Button ID="btnSerialize" runat="server" Text="Serialize" OnClick="btnSerialize_OnClick"></asp:Button>
           <asp:Button ID="btnSerializeCollection" runat="server" Text="SerializeCollection" OnClick="btnSerializeCollection_OnClick"></asp:Button>
         <asp:Button ID="btnDeserialize" runat="server" Text="Deserialize" OnClick="btnDeserialize_OnClick"></asp:Button>
           <asp:Button ID="btnDeserializeCollection" runat="server" Text="DeserializeCollection" OnClick="btnDeserializeCollection_OnClick"></asp:Button>

   </div>
        <asp:GridView ID="gdvResult" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
