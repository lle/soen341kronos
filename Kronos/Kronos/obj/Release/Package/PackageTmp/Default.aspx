<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kronos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="~/Style/Style.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                           <div id="Div1">
                                &nbsp;&nbsp; Username:&nbsp; <asp:TextBox ID="username_textbox" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">New User?Register Here</asp:LinkButton>
                                <br />
&nbsp;&nbsp;&nbsp;
        Password: <asp:TextBox ID="password_textbox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="login_button" runat="server" OnClick="Button2_Click" Text="Login" />
  
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="login_label" runat="server" Text="Label" Visible="False"></asp:Label>
  
                                &nbsp;&nbsp;&nbsp;
                                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;</div>
    
                           </asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder2">
            <p>
                &nbsp;</p>
            <p>
                                <object data="data:application/x-silverlight-2," type="application/x-silverlight-2" style="height: 604px; width: 1167px; margin-top: 0px;">
		                          <param name="source" value="ClientBin/TimeTableDesign.xap"/>
		                          <param name="onError" value="onSilverlightError" />
		                          <param name="background" value="white" />
		                          <param name="minRuntimeVersion" value="3.0.40624.0" />
		                          <param name="autoUpgrade" value="true" />
		                          <a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40624.0" style="text-decoration:none">
 			                          <img src="http://go.microsoft.com/fwlink/?LinkId=108181" alt="Get Microsoft Silverlight" style="border-style:none"/>
		                          </a>
	                            </object></p>
            </asp:Content>

