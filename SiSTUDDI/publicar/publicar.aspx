<%@ Page language="c#" Codebehind="publicar.aspx.cs" AutoEventWireup="false" Inherits="Uddi.publicar.publicar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="publicar" method="post" runat="server">
			<asp:label id="lblUser" style="Z-INDEX: 101; LEFT: 77px; POSITION: absolute; TOP: 64px" runat="server" Width="143px" Height="25px">Username</asp:label>
			<asp:textbox id="txtPass" style="Z-INDEX: 104; LEFT: 237px; POSITION: absolute; TOP: 105px" runat="server" Width="108px" Height="30px"></asp:textbox>
			<asp:label id="lblPass" style="Z-INDEX: 103; LEFT: 77px; POSITION: absolute; TOP: 109px" runat="server" Width="143px" Height="25px">Password</asp:label>
			<asp:textbox id="txtUser" style="Z-INDEX: 102; LEFT: 237px; POSITION: absolute; TOP: 63px" runat="server" Width="108px" Height="30px"></asp:textbox>
			<asp:button id="btnLogin" style="Z-INDEX: 105; LEFT: 154px; POSITION: absolute; TOP: 167px" runat="server" Width="133px" Height="35px" Text="Login"></asp:button>
			<asp:label id="lblStatus" style="Z-INDEX: 106; LEFT: 84px; POSITION: absolute; TOP: 231px" runat="server" Width="270px" Height="49px">Status</asp:label>
		</form>
	</body>
</HTML>
