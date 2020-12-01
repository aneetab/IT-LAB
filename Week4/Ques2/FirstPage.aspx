<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="Ques2.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Name: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            Enter RollNo: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            Select a subject: <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>

</body>
</html>
