<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            INSERT NEW EMPLOYEE RECORD:<hr />
            Enter employee name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            Enter company name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            Enter salary:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            Enter city of residence:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
            Enter street name:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="INSERT" OnClick="Button1_Click"/><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            ENTER COMPANY NAME TO FIND EMPLOYEE DETAILS :<br /><hr />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button2" runat="server" Text="SUBMIT" OnClick="Button2_Click" /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

            <asp:Table ID="Table1" runat="server"></asp:Table>



        </div>
    </form>
</body>
</html>
