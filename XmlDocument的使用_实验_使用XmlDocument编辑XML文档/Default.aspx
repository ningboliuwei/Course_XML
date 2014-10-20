<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XmlDocument的使用_实验_使用XmlDocument编辑XML文档._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
    <head>
        <title>手机信息</title>
    </head>
    <body bgcolor="#cc99ff">
        <form id="Form1" runat="server">
            手机品牌：<asp:TextBox ID="txtBrand" runat="server"></asp:TextBox><br />
            手机型号：<asp:TextBox ID="txtModel" runat="server"></asp:TextBox><br />
            手机类型：<asp:DropDownList ID="dplType" runat="server">
                     <asp:ListItem Value="直板">直板</asp:ListItem>
                     <asp:ListItem Value="翻盖">翻盖</asp:ListItem>
                     <asp:ListItem Value="滑盖">滑盖</asp:ListItem>
                 </asp:DropDownList>
            <br />
            兼容网络制式：<asp:CheckBoxList ID="cblNetwork" runat="server" RepeatDirection="Horizontal"
                                     RepeatColumns="1">
                       <asp:ListItem Value="GSM 850">GSM 850</asp:ListItem>
                       <asp:ListItem Value="GSM 900">GSM 900</asp:ListItem>
                       <asp:ListItem Value="GSM 1800">GSM 1800</asp:ListItem>
                       <asp:ListItem Value="GSM 1900">GSM 1900</asp:ListItem>
                   </asp:CheckBoxList>
            <br />
            售价：<asp:TextBox ID="txtPrice" runat="server"></asp:TextBox><br />
            重量：<asp:TextBox ID="txtWeight" runat="server"></asp:TextBox><br />
            长：<asp:TextBox ID="txtLength" runat="server"></asp:TextBox><br />
            宽：<asp:TextBox ID="txtWidth" runat="server"></asp:TextBox><br />
            厚：<asp:TextBox ID="txtThickness" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnAdd" runat="server" Text="新    增" OnClick="btnAdd_Click"></asp:Button>
            <asp:Button ID="btnDelete" runat="server" Text="删    除"
                        OnClick="btnDelete_Click"></asp:Button>
            <asp:Button ID="btnClear" runat="server" Text="清    空" OnClick="btnClear_Click"></asp:Button><br />
            <asp:Button ID="btnPreviousRecord" runat="server" Text="上一条记录"></asp:Button>
            <asp:Button ID="btnNextRecord" runat="server" Text="下一条记录"></asp:Button>
            <br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
        </form>
    </body>
</html>