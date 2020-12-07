<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a fruit:<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList><br />
            Choose an icecream:<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><hr />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
        </div>
    </form>
</body>
</html>
