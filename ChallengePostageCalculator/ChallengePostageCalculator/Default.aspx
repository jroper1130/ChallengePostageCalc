<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostageCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="Change"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="Change"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" OnTextChanged="Change"></asp:TextBox>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="rb" OnCheckedChanged="Change" Text="Ground" />
            <br />
            <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="rb" OnCheckedChanged="Change" Text="Air" />
            <br />
            <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" GroupName="rb" OnCheckedChanged="Change" Text="Next Day" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
