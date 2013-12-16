<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Transforming and Displaying XML Data using Xml Web Server Control</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <P>Maximum Calories:
            <asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
            <asp:Button OnClick="Button1_Click" id="Button1" runat="server" Text="Filter Menu"></asp:Button>
        </P>
        <P>
            <asp:Xml id="Xml1" runat="server" DocumentSource="Menu.xml" TransformSource="Menu.xsl"></asp:Xml>
        </P>  
    </div>
    </form>
</body>
</html>
