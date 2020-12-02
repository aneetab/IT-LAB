<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="HouseKeepingQues.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select the ID of the staff whose details you want to display:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br /><br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView><br /><br />
            Select a city to update city:<br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>



        </div>
    </form>
</body>
</html>
