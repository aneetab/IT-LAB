﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LoginForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Username:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            Enter Password:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
