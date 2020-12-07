<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Choose a genre:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"></asp:DropDownList><br />
            Choose an actor:<br />
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="name"></asp:ListBox><br /><hr />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:Genre %>" SelectCommand="Select * from Actors where category=@cat">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="cat" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2"></asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ConnectionStrings:Genre %>" SelectCommand="Select * from Actors where name=@name" >
                <SelectParameters>
                    <asp:ControlParameter ControlID="ListBox1" Name="name" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>
           
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

        </div>
    </form>
</body>
</html>
