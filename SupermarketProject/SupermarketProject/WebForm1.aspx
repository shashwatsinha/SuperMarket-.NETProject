<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SupermarketProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
   
   
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Add new Item" OnClick="Button1_Click" />

        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Modify Existing Item" />

        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Go Back" />

        </div>
    </form>
</body>
</html>
