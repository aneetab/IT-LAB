<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="ShoppingCart.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br /><br />
            Enter Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Select Items to add to cart:<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br />
            <asp:Button ID="Button1" runat="server" Text="Continue Shopping" OnClick="Button1_Click"/><br /><br />


        </div>
    </form>
</body>
</html>

