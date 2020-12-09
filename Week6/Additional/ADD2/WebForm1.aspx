<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADD2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose an name:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><hr />
            First Name:<asp:TextBox ID="TextBox1" runat="server" ReadOnly="true"></asp:TextBox><br />
            Last Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Phone:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            Address:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            City:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br /><hr />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" /><asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" /><hr />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
