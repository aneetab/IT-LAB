<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             Select a state:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true"></asp:DropDownList><br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:States %>" SelectCommand="Select * from City where StateID=@id">
                <SelectParameters>
                    <asp:ControlParameter Name="id" ControlID="DropDownList1" PropertyName="SelectedValue"  />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="CityName" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList><br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
