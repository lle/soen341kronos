<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Kronos.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    New User? Register!<p>
        username<asp:TextBox ID="username_textbox" runat="server"></asp:TextBox>
&nbsp;</p>
    <p>
        password<asp:TextBox ID="password_textbox1" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        re-enter password<asp:TextBox ID="password_text2box" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        email address<asp:TextBox ID="email_textbox" runat="server"></asp:TextBox>
    </p>
<p>
        Student ID Number:<asp:TextBox ID="studentid_textbox" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="register_button" runat="server" OnClick="Button1_Click" Text="Register" />
    </p>
    <p>
        <asp:Label ID="register_label" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
</asp:Content>
