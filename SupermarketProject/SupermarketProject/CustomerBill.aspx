<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerBill.aspx.cs" Inherits="SupermarketProject.CustomerBill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Go Back" OnClick="Button1_Click" />
        <asp:Label ID="Label3" runat="server" Text="Total Bill"></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
        
    </form>
</body>
</html>
