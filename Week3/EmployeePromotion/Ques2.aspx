<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ques2.aspx.cs" Inherits="EmployeePromotion.Ques2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              <asp:Panel ID="Panel1" runat="server" Height="200px" Width="330px" style="margin-left:500px;margin-top:50px;">
                  <asp:Image ID="Image1" Height="50%" Width="50%" runat="server" />
              </asp:Panel>
        <div>
            Select Employee ID: <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br /><br />
            Name of employee:<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            Enter DOJ(MM/DD/YYYY): <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Am I Eligible for Promotion" OnClick="Button1_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            
        </div>
  
    </form>
</body>
</html>
