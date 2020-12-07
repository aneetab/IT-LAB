<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="QUES2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:Packages %>" SelectCommand="Select * from Tours where Place=@place">
                <SelectParameters>
                    <asp:QueryStringParameter Name="place" QueryStringField="id" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView><br />
            <asp:Button ID="Button1" runat="server" Text="BACK" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
