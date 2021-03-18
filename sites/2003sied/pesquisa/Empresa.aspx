<%@ Page language="c#" Codebehind="Empresa.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.pesquisar.Empresa" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<link href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<!--#include file="../include/topo.inc"-->
		<form id="Pesquisar" method="post" runat="server">
			<br>
			<asp:table id="tblLista" runat="server" Height="170px" Width="511px" HorizontalAlign="Center">
				<asp:TableRow>
					<asp:TableCell></asp:TableCell>
				</asp:TableRow>
			</asp:table>
			<br>
			<asp:label id="lblMensagem" Runat="server"></asp:label>
		</form>
		<!--#include file="../menubaixo.inc"-->
	</body>
</HTML>
