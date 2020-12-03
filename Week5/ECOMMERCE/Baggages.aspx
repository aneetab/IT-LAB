<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Baggages.aspx.cs" Inherits="Mynta.Baggages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" >
    <asp:Label ID="Label1" runat="server" Text="Laptop Bag:<hr>Price:Rs. 700" style="font-weight:bold;"></asp:Label><br />
    <asp:Image ID="Image1" runat="server" ImageUrl="Images/laptopBag.png"/><br /><br />
    <asp:Label ID="Label2" runat="server" Text="Trolley Bag:<hr>Price:Rs. 3500"  style="font-weight:bold;"></asp:Label><br />
    <asp:Image ID="Image2" runat="server" ImageUrl="Images/trolley.png"/><br /><br />
    <asp:Label ID="Label3" runat="server" Text="Shoulder Bag:<hr>Price:Rs. 1200"  style="font-weight:bold;"></asp:Label><br />
    <asp:Image ID="Image3" runat="server" ImageUrl="Images/backpack.png"/><br /><br />

     </asp:Panel>
</asp:Content>
