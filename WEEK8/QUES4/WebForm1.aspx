<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:Products %>" SelectCommand="Select * from Product"  UpdateCommand="Update Product set Name=@Name,Qty=@Qty where Id=@Id"></asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="Id" AllowSorting="true" DataSourceID="SqlDataSource1" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id" ReadOnly="true" SortExpression="Id"/>
                    <asp:TemplateField HeaderText="Name" SortExpression="Name">
                        <ItemTemplate>
                        <%#Eval("Name") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%#Bind("Name") %>'></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox2" runat="server" ErrorMessage="Name can't be blank" ForeColor="Red" Font-Bold="true"></asp:RequiredFieldValidator>
                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Details">
                        <ItemTemplate>
                            Price:<%#Eval("Price") %><br />Qty:<%#Eval("Qty") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                             Price:<%#Eval("Price") %><br />Qty:<asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("Qty") %>'></asp:TextBox>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" MinimumValue="1" MaximumValue="20" Type="Integer" ErrorMessage="Quantity has to be between 1 and 20" ForeColor="Red" Font-Bold="true"></asp:RangeValidator>

                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="true" />
                </Columns>
            </asp:GridView>
            
        </div>
    </form>
</body>
</html>
