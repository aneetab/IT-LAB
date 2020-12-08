<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="QUES2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ConnectionStrings:Genre %>" UpdateCommand="Update Authors set FirstName=@FirstName,CopiesSold=@CopiesSold where Id=@Id" SelectCommand="Select * from Authors"></asp:SqlDataSource>
            Details of Authors:<hr />
            <asp:GridView ID="GridView1" runat="server" DataSourceId="SqlDataSource1" AllowPaging="true" PageSize="3" AutoGenerateColumns="false" DataKeyNames="Id">
                <Columns>
                    <asp:CommandField ShowEditButton="true" />
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true"> 
                        <HeaderStyle Font-Bold="true" ForeColor="Red" BackColor="Green" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Name">
                        <HeaderStyle Font-Bold="true" ForeColor="Red" BackColor="Green" />
                        <ItemTemplate>
                            <b>FirstName:</b><%#Eval("FirstName") %><br />
                            <b>LastName:</b><%#Eval("LastName") %><br />
                        </ItemTemplate>
                        <EditItemTemplate>
                            <b>FirstName:</b>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%#Bind("FirstName") %>' Width="50px"></asp:TextBox><br />
                            <b>LastName:</b><%#Eval("LastName") %><br />

                        </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="BookTitle" HeaderText="Book Title" ReadOnly="true"> 
                        <HeaderStyle Font-Bold="true" ForeColor="Red" BackColor="Green" /> 
                    </asp:BoundField>
                    <asp:BoundField DataField="Genre" HeaderText="Genre" ReadOnly="true" > 
                        <HeaderStyle Font-Bold="true" ForeColor="Red" BackColor="Green" /> 
                    </asp:BoundField>
                    <asp:BoundField DataField="CopiesSold" HeaderText="Copies Sold" > 
                        <HeaderStyle Font-Bold="true" ForeColor="Red" BackColor="Green" /> 
                    </asp:BoundField>
                </Columns>

            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
