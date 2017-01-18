<%@ Page language="c#" Codebehind="Pesquisar.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.pesquisar.Pesquisar" %>
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
			<table align="center" border="0">
				<tr>
					<td>
						<p>Parâmetros de pesquisa</p>
						<asp:radiobuttonlist id="rbParametrosPesquisa" runat="server" Width="183px" Height="43px" CssClass="../../Texto.css">
							<asp:ListItem Value="nome" Selected="True">Nome</asp:ListItem>
							<asp:ListItem Value="prod">Produto ou Servi&#231;o</asp:ListItem>
						</asp:radiobuttonlist></td>
					<td vAlign="top">
						<p>Começa por:</p>
						<br>
						<asp:textbox id="txtNome" runat="server" Width="250px"></asp:textbox></td>
				</tr>
				<tr>
					<td><asp:button id="btnProcurar" runat="server" Text="Procurar"></asp:button></td>
					<td>
						<p>Utilize o % como wildcard</p>
					</td>
				</tr>
			</table>
			<br>
			<asp:table id="tblLista" runat="server" Height="170px" Width="511px" HorizontalAlign="Center">
				<asp:TableRow>
					<asp:TableCell></asp:TableCell>
				</asp:TableRow>
			</asp:table><asp:label id="lblMensagem" style="Z-INDEX: 101; LEFT: 174px; POSITION: absolute; TOP: 265px" runat="server" Width="453px" Height="17px"></asp:label></form>
		<!--#include file="menubaixo.inc"-->
	</body>
</HTML>
