<%@ Page language="c#" Codebehind="Pesquisar.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.pesquisa.Pesquisar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript (ECMAScript)" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<!--#include file="../include/topo.inc"-->
		<form id="Pesquisar" method="post" runat="server">
			<table align="center" border="0">
				<tr>
					<td>
						<p>&nbsp;</p>
					</td>
					<td vAlign="top">
						<asp:Panel id="pnlPesquisarNome" runat="server">
							<P><STRONG>Nome</STRONG></P>
							<P>Começa por:
								<asp:textbox id="txtNome" runat="server" Width="250px"></asp:textbox></P>
							<P align="center">Utilize o % como wildcard</P>
						</asp:Panel>
						<asp:panel id="pnlPesquisarServico" runat="server" Visible="False">
							<TABLE id="tblRegistrarServico" cellSpacing="1" cellPadding="1" width="100%" border="0">
								<TR>
									<TD style="WIDTH: 134px" colSpan="2"><STRONG>Serviço/Produto</STRONG></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 134px">Empresa</TD>
									<TD></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 134px">Actividade:</TD>
									<TD>
										<asp:dropdownlist id="cmbFamilia" runat="server" Width="190px"></asp:dropdownlist>
										<asp:button id="btnFamilia" runat="server" Width="150px" Text="Ver Categorias"></asp:button></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 134px"></TD>
									<TD>
										<asp:dropdownlist id="cmbClasse" runat="server" Width="190px" Enabled="False"></asp:dropdownlist>
										<asp:button id="btnClasse" runat="server" Width="150px" Text="Ver SubCategoria" Enabled="False"></asp:button></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 134px"></TD>
									<TD>
										<asp:dropdownlist id="cmbElemento" runat="server" Width="190px" Enabled="False"></asp:dropdownlist></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 134px"></TD>
									<TD>
										<P>
											<asp:label id="lblCodigo" runat="server" Width="150px" Visible="False"></asp:label>
											<asp:label id="lblDescricao" runat="server" Width="330px" Visible="False"></asp:label></P>
										<P>
											<asp:Label id="lblCategory" runat="server"></asp:Label></P>
									</TD>
								</TR>
							</TABLE>
						</asp:panel>
						<P></P>
					</td>
				</tr>
				<tr>
					<td></td>
					<td>
						<p align="center">&nbsp;</p>
					</td>
				</tr>
			</table>
			<div align="center">
				<asp:button id="btnProcurar" runat="server" Text="Procurar"></asp:button>
			</div>
			<br>
			<asp:table id="tblLista" runat="server" HorizontalAlign="Center">
				<asp:TableRow>
					<asp:TableCell></asp:TableCell>
				</asp:TableRow>
			</asp:table>
			<div align="center">
				<asp:label id="lblMensagem" runat="server" Width="453px" Height="17px" Font-Bold="True"></asp:label>
		</form>
		</DIV> 
		<!--#include file="../menubaixo.inc"-->
	</body>
</HTML>
