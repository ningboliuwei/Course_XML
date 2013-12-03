<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CaculationTest.aspx.cs" Inherits="WebService的使用_实验_四则运算.CaculationTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                <asp:TextBox runat="server" ID="txtNumber1"></asp:TextBox>
                &nbsp;<asp:Label ID="lblOperator" runat="server" Text=""></asp:Label>&nbsp;
                <asp:TextBox runat="server" ID="txtNumber2"></asp:TextBox>&nbsp;=&nbsp;
                <asp:TextBox runat="server" ID="txtResult"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnGenerate" Text="生成题目"
                    OnClick="btnGenerate_Click" />&nbsp;
                <asp:Button runat="server" ID="btnJudge" Text="判断对错" OnClick="btnJudge_Click" />&nbsp;<br />
            </p>
            <p>
                <asp:GridView runat="server" ID="gdvQuestions"></asp:GridView>
            </p>

        </div>
    </form>
</body>
</html>
