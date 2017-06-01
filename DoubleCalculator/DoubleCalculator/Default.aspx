<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DoubleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1" style="font-family: Arial, Helvetica, sans-serif">
            Quackulator</div>
        <p>
            First Value&nbsp;
            <asp:TextBox ID="value1" runat="server"></asp:TextBox>
        </p>
        <p>
            Second Value&nbsp;
            <asp:TextBox ID="value2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;
            <asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
        </p>
        <p>
            <asp:Label ID="resultLabel" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </p>
    </form>
</body>
</html>
