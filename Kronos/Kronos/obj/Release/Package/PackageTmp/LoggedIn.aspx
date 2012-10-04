<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LoggedIn.aspx.cs" Inherits="Kronos.LoggedIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:FileUpload id="FileUploadControl" runat="server" />
    <asp:Button runat="server" id="UploadButton" text="Upload" onclick="UploadButton_Click" />
    <br /><br />
    <asp:Label runat="server" id="StatusLabel" text="Upload status: " />
    <br />
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

