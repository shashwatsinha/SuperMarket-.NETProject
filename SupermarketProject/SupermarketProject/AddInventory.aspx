<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddInventory.aspx.cs" Inherits="SupermarketProject.AddInventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Text ="Product_ID"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Text ="Product_Name"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Text ="Product_Type"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" Text ="Product_Cost"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server" Text ="Product_Stock"></asp:TextBox>
    </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" />
        </p>
    </form>
</body>
</html>
