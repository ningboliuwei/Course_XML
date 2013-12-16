<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlDisplayExample_RSSReader.aspx.cs" Inherits="XML的显示.XmlDisplayExample_RSSReader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
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
