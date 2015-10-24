<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="SupermarketProject.Billing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server">
            
        </asp:GridView>
    
        
         <asp:Label ID="Label1" runat="server" Text="Product_Id"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Quantity Purchased"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Add More" OnClick="Button1_Click" />
            <br/>
    
    </div>
        <asp:Button ID="Button2" runat="server" Text="Print Bill" OnClick="Button2_Click" />
    </form>
</body>
</html>
