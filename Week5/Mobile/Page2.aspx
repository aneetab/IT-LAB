<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Page2.aspx.cs" Inherits="Mobile.Page2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mobileLabel" runat="server">
    <asp:Image ID="Image" runat="server" /><br /><br />
    <asp:Label ID="Screen" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Memory" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Camera" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="Battery" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="BACK" OnClick="Button1_Click" />
</asp:Content>
