<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kronos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display.">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
        </Columns>
    </asp:GridView>
    -&gt; USERS CURRENTLY REGISTERED SHOWING<br />
    New User? Register!<p>
        username<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:soen341dBConnectionString1 %>" ProviderName="<%$ ConnectionStrings:soen341dBConnectionString1.ProviderName %>" SelectCommand="SELECT [Id], [Username], [Password], [email] FROM [registration]"></asp:SqlDataSource>
&nbsp;</p>
    <p>
        password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
    <p>
        email address<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
<p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Register" />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
        Already a User? Login</p>
    <p>
        Username<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Password<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" />
        <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
