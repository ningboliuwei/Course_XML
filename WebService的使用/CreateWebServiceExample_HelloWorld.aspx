﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateWebServiceExample_HelloWorld.aspx.cs" Inherits="WebService的使用.CreateWebServiceExample_HelloWorld" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <asp:Button runat=server ID="btnInvoke" Text="调用Hello World" 
                            onclick="btnInvoke_Click" />
            </div>
        </form>
    </body>
</html>