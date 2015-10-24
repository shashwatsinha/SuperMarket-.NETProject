<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SalesMenu.aspx.cs" Inherits="SupermarketProject.SalesMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Add New Transaction" OnClick="Button1_Click" />
    </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Search Customer" OnClick="Button2_Click" />
            
        </p>
        <asp:Button ID="Button3" runat="server" Text="Go Back" OnClick="Button3_Click" />
    </form>
</body>
</html>
