<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kronos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Added master file, now all pages you add should be inherited from it which contains css and design</p>
    <p>
        &nbsp;</p>
    <p>
        username<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        email address<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
