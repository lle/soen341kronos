<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kronos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Already a User? Login</p>
    <p>
        Username<asp:TextBox ID="username_textbox" runat="server"></asp:TextBox>
    </p>
    <p>
        Password<asp:TextBox ID="password_textbox" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="login_button" runat="server" OnClick="Button2_Click" Text="Login" />
        <asp:Label ID="login_label" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">Registration Page Here(Don&#39;t enter real pwd info due to encryption)</asp:LinkButton>
    </p>
</asp:Content>
