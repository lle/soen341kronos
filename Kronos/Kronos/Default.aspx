<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kronos.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #Div1 {
            height: 394px;
            width: 1132px;
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 42px; width: 973px">
        <p style="width: 959px; margin-left: 171px; height: 45px;">
        Already a User? Login:&nbsp;&nbsp;&nbsp;&nbsp; Username<asp:TextBox ID="username_textbox" runat="server"></asp:TextBox>
        Password<asp:TextBox ID="password_textbox" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="login_button" runat="server" OnClick="Button2_Click" Text="Login" />
  
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="login_label" runat="server" Text="Label" Visible="False"></asp:Label>
  
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Register.aspx">New User?Register Here</asp:LinkButton>
        </p>
  
                           <div id="Div1">
                                <object data="data:application/x-silverlight-2," type="application/x-silverlight-2" style="height: 578px; width: 1060px; margin-top: 0px;">
		                          <param name="source" value="ClientBin/TimeTableDesign.xap"/>
		                          <param name="onError" value="onSilverlightError" />
		                          <param name="background" value="white" />
		                          <param name="minRuntimeVersion" value="3.0.40624.0" />
		                          <param name="autoUpgrade" value="true" />
		                          <a href="http://go.microsoft.com/fwlink/?LinkID=149156&v=3.0.40624.0" style="text-decoration:none">
 			                          <img src="http://go.microsoft.com/fwlink/?LinkId=108181" alt="Get Microsoft Silverlight" style="border-style:none"/>
		                          </a>
	                            </object><iframe id="Iframe1" style="visibility:hidden;height:0px;width:0px;border:0px"></iframe></div>
    
                           </asp:Content>
