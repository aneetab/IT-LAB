<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="QUES4._default" Theme="DefaultTheme" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mobileLabel" runat="server">
    
    Select a mobile:<br />
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
        ></asp:DropDownList><br /><br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
    <asp:Button ID="Button1" runat="server" Text="Confirm" OnClick="Button1_Click"/>
    
</asp:Content>