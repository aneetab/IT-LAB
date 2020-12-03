<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Add1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter UserName:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            Enter Password<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            Enter EMAIL:<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            Enter Contact Number<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
