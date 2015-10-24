<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePrices.aspx.cs" Inherits="SupermarketProject.UpdatePrices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter item name"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Select" OnClick="Button1_Click" />
    </div>
        <asp:Label ID="Cost" runat="server" Text="Cost"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Stock" runat="server" Text="Stock"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Set New Values" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Go Back" />
    </form>
</body>
</html>
