﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomersReader.aspx.cs" Inherits="XmlReader的使用_实验_VS2012._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="lightblue">
<form id="form1" runat="server">
    <div>
<table width="400px" border="1">
<tr>
    <td>
        <b>顾客信息：</b>
    </td>
    <td></td>
</tr>
<tr>
    <td>
        顾客ID：
    </td>
    <td>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        姓名：
    </td>
    <td>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        E-mail：
    </td>
    <td>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        街道：
    </td>
    <td>
        <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        城市
    </td>
    <td>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        州：
    </td>
    <td>
        <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        邮政编码：
    </td>
    <td>
        <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <b>订单信息：</b>
    </td>
    <td></td>
</tr>
<tr>
    <td>
        订单号：
    </td>
    <td>
        <asp:TextBox ID="txtOrderNumber" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        订单日期：
    </td>
    <td>
        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        <b>物品信息：</b>
    </td>
    <td></td>
</tr>
<tr>
    <td>
        SKU号：
    </td>
    <td>
        <asp:TextBox ID="txtSKUNumber" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        物品号：
    </td>
    <td>
        <asp:TextBox ID="txtItemNumber" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        物品成本：
    </td>
    <td>
        <asp:TextBox ID="txtItemCost" runat="server"></asp:TextBox>
    </td>
</tr>
<tr>
    <td>
        物品价格：
    </td>
    <td>
        <asp:TextBox ID="txtItemPrice" runat="server"></asp:TextBox>
    </td>
</tr>
</table>
    </div>
</form>
</body>
</html>