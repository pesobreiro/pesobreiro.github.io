<%@ Page language="c#" Codebehind="PublicarTaxonomias.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.administrar.Publicar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CriarTaxonomias</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body ms_positioning="GridLayout">
		<!--#include file="../include/topoadmin.inc"-->
		<p class="TituloAzul" align="center">Publicar Taxonomias</p>
		<form id="PublicarTaxonomias" method="post" runat="server">
			<TABLE id="Table1" width="100%">
				<tr>
					<td width="20%"><b>Nome:*</b>
					</td>
					<td width="40%"><asp:textbox id="txtNome" runat="server"></asp:textbox></td>
					<td width="20%"><asp:requiredfieldvalidator id="rfvNome" ControlToValidate="txtNome" ErrorMessage="Campo Necess�rio" Runat="server"></asp:requiredfieldvalidator></td>
				</tr>
				<tr>
					<td><b>TModel Key:*</b>
					</ASP:TABLECELL>
					<td><asp:textbox id="txtTModelKey" runat="server"></asp:textbox></td>
					<td><asp:requiredfieldvalidator id="rfvTModelKey" ControlToValidate="txtTModelKey" ErrorMessage="Campo Necess�rio" Runat="server"></asp:requiredfieldvalidator></td>
				</tr>
				<tr>
					<td><b>Descri��o:*</b>
					</td>
					<td><asp:textbox id="txtDescricao" runat="server"></asp:textbox></td>
					<td><asp:requiredfieldvalidator id="rfvDescricao" ControlToValidate="txtDescricao" ErrorMessage="Campo Necess�rio" Runat="server"></asp:requiredfieldvalidator></td>
				</tr>
				<tr>
					<td><b>Caracteriza��o:</b>
					</td>
					<td><b><asp:radiobuttonlist id="rbCaracterizacao" runat="server">
								<asp:ListItem Selected="True" Value="Identificador"></asp:ListItem>
								<asp:ListItem Selected="False" Value="Categoria"></asp:ListItem>
							</asp:radiobuttonlist></b></td>
					<td width="20%">&nbsp;
					</td>
				</tr>
			</TABLE>
			<div align="center"><asp:textbox id="txtMsg" runat="server" Width="100%" Height="100%" Rows="20" TextMode="MultiLine"></asp:textbox><br>
				<asp:button id="btnPublicar" runat="server" Text="Publicar"></asp:button>
				<table width="100%">
					<tr class="textoLink" bgColor="#b0c4de">
						<td align="middle"><A class="link" href="javascript:window.history.back()">In�cio</A>
							<A class="link" href="index.aspx">Voltar</A> Link's principais da 
							aplica��o....................</td>
					</tr>
				</table>
			</div>
		</form>
	</body>
</HTML>
