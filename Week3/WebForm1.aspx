<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MagazineFront.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div>
            Choose an image:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Update_Click"></asp:DropDownList><br />

            Choose a background colour:<br />
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Update_Click"></asp:DropDownList><br />
            
            Specify numeric fontsize:<br />
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="Update_Click"></asp:TextBox><br />

            Choose a font colour:<br />
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Update_Click"></asp:DropDownList><br />
            Enter message to be displayed:<br />
            <asp:TextBox ID="TextBox2" TextMode="MultiLine" runat="server" AutoPostBack="true" OnTextChanged="Update_Click"></asp:TextBox><br /><br />
        
            <asp:Button ID="Update" runat="server" Text="Update" Width="132px" OnClick="Update_Click" />
       
            </div>
        <asp:Panel ID="Panel1" runat="server" Width="40%" Height="100%" HorizontalAlign="Center" style="position:absolute;margin-top:5px;margin-left:334px;">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Image ID="Image1" runat="server" Height="50%"/>
        </asp:Panel>
            
    </form>
</body>

</html>
