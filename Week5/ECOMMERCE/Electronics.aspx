<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Electronics.aspx.cs" Inherits="Mynta.Electronics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" style="margin-left:380px;height:50%;width:50%;">
    Choose a category:<br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList><br /><br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br />
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList><br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </asp:Panel>
</asp:Content>
