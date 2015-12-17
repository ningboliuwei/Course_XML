<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeatherForcast.aspx.cs" Inherits="WebService的使用_实验_天气预报.WeatherForcast" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="weather.css" rel="stylesheet"/>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <table width="680" border="0" align="center" cellpadding="0" cellspacing="0">
            <tr>
                <td height="60" align="center">
                    <asp:Label Font-Bold="true" ID="Title" runat="server" Text="国内外主要城市  3天天气预报实例"/>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td width="25%">
                                <strong>选择省/洲</strong>
                                <asp:DropDownList CssClass="list" ID="drpProvince" runat="server"
                                                  AutoPostBack="true" OnSelectedIndexChanged="drpProvince_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <strong>选择城市</strong>
                                <asp:DropDownList CssClass="list" ID="drpCity" runat="server"
                                                  AutoPostBack="true" OnSelectedIndexChanged="drpCity_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table width="100%" border="0" cellspacing="2" cellpadding="0">
                        <tr>
                            <td width="15%" height="30">&nbsp; </td>
                            <td align="right">
                                <asp:Label CssClass="bredfont" ID="Label8" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <strong>今日实况</strong>
                            </td>
                            <td class="hfont">
                                <asp:Label ID="Label1" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">&nbsp; </td>
                            <td>&nbsp; </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <strong>天气预报</strong><font color="#FF0033">(今天)</font>
                            </td>
                            <td class="hfont">
                                <asp:Label ID="Label2" runat="server"/>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Image AlternateText="icon" ID="Image1" ImageAlign="AbsMiddle" runat="server"/>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Image AlternateText="icon" ID="Image2" ImageAlign="AbsMiddle" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <strong>今天指数</strong>
                            </td>
                            <td>&nbsp; </td>
                        </tr>
                        <tr>
                            <td colspan="2" valign="top" class="hfont">
                                <asp:Label ID="Label5" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">&nbsp; </td>
                            <td>&nbsp; </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <strong>天气预报</strong><font color="#3333FF">(明天)</font>
                            </td>
                            <td class="hfont">
                                <asp:Label ID="Label3" runat="server"/>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Image AlternateText="icon" ID="Image3" ImageAlign="AbsMiddle" runat="server"/>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Image AlternateText="icon" ID="Image4" ImageAlign="AbsMiddle" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">&nbsp; </td>
                            <td>&nbsp; </td>
                        </tr>
                        <tr>
                            <td valign="top">
                                <strong>天气预报</strong><font color="#006633">(后天)</font>
                            </td>
                            <td class="hfont">
                                <asp:Label ID="Label4" runat="server"/>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Image AlternateText="icon" ID="Image5" ImageAlign="AbsMiddle" runat="server"/>
                                &nbsp;&nbsp;&nbsp;
                                <asp:Image AlternateText="icon" ID="Image6" ImageAlign="AbsMiddle" runat="server"/>
                            </td>
                        </tr>
                        <tr>
                            <td valign="top">&nbsp; </td>
                            <td>&nbsp; </td>
                        </tr>

                        <tr>
                            <td height="30" colspan="2" align="right" valign="bottom">
                                <strong>预报时间</strong>：
                                <asp:Label ID="Label7" runat="server"/>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</form>
</body>
</html>