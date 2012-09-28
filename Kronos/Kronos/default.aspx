<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Kronos._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
            Team Kronos On Fire :P			<br />
            <img src="http://www.automopedia.org/wp-content/uploads/2009/03/optimusprime.jpg" />
        </center>

        <asp:TextBox value="Vroom1" ID="txtValueOne" runat="server"></asp:TextBox>
        <asp:TextBox value="Vroom2" ID="txtValueTwo" runat="server"></asp:TextBox><br />
        <asp:Button Text="Button" ID="btnCalculate" OnClick="btnCalculate_Click" runat="server" /><br />
        <asp:Label value="Press Button" ID="lblResult" runat="server"></asp:Label><br />
    </div>
    </form>
</body>
</html>
