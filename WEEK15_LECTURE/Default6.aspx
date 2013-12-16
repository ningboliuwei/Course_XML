<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default6.aspx.cs" Inherits="Default6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Programmatically Displaying XML Data using Xml Web Server Control</title>
</head>
<body STYLE="font-family:Arial, helvetica, sans-serif; font-size:12pt;
            background-color:#EEEEEE">
    <form id="form1" runat="server">
    <div>       
        <P>
        <asp:TextBox ID=rssTextBox runat=server Width="300px"></asp:TextBox>
			<asp:Button ID=okButton text="OK" runat=server onclick="okButton_Click" />
            <asp:Xml id="Xml1" runat="server"></asp:Xml>
        </P>  
    </div>
    </form>
</body>
</html>
