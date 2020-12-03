<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="Genre1.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select a Genre:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            Select name of a legend:<br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox><br /><br /><br />
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="true" Columns="50"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>


        </div>
    </form>
</body>
</html>
