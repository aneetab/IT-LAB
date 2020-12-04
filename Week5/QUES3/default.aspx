<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Ques3._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server"></asp:Image><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Select a theme:"></asp:Label><br /><br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br /><br />
            <asp:TextBox ID="TextBox1" runat="server" Text="Hello World" ReadOnly="true"></asp:TextBox><br />
        </div>
    </form>
</body>
</html>
