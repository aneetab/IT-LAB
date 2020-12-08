<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:Staff_Details %>" SelectCommand="Select * from Staff" ></asp:SqlDataSource>
            Details of Staff:<hr />
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="false" AllowSorting="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:TemplateField HeaderText="Staff details" SortExpression="Name">
                        <ItemTemplate>

                            <b>Name:</b><asp:Label ID="Label1" runat="server" Text='<%#Bind("Name") %>'/><br />
                            <b>Age:</b><asp:Label ID="Label2" runat="server" Text='<%#Bind("Age") %>'/><br />

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Designation" HeaderText="Designation" />
                    <asp:BoundField DataField="Salary" HeaderText="Salary" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
