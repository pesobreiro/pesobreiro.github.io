<%@ Page language="c#" Codebehind="index.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.publicar.index" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>SiSTUDDI</title>
		<meta content="False" name="vs_showGrid">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<!--#include file="../include/topoPublicar.inc"-->
		<asp:panel id="pnlConteudo" Visible="False" HorizontalAlign="Center" Width="100%" runat="server">
			<FORM id="login" method="post" runat="server">
				<P>
					<TABLE id="conteudo" cellSpacing="0" cellPadding="0" width="100%" border="0">
						<TR>
							<TD width="22%">&nbsp;</FONT></B></TD>
							<TD width="2%">&nbsp;</TD>
							<TD width="76%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">Registro 
										da Empresa</FONT></B></TD>
						</TR>
						<TR>
							<TD style="HEIGHT: 20px" width="22%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">SiSTUDDI</FONT></B></TD>
							<TD style="HEIGHT: 20px">&nbsp;</TD>
							<TD style="HEIGHT: 20px">&nbsp;</TD>
						</TR>
						<TR>
							<TD bgColor="#ffffff">&nbsp;</TD>
							<TD>&nbsp;</TD>
							<TD>&nbsp;</TD>
						</TR>
						<TR>
							<TD vAlign="top" bgColor="#ffffff">
								<TABLE cellSpacing="0" cellPadding="0" width="212" bgColor="#e2e2e2" border="0">
									<TR>
										<TD width="28"><IMG height="33" src="../imagens/esqcima.gif" width="28"></TD>
										<TD width="156">
											<P class="texto" align="center">Registrar:</P>
										</TD>
										<TD width="28"><IMG height="33" src="../imagens/dircima.gif" width="28"></TD>
									</TR>
									<TR>
										<TD>&nbsp;</TD>
										<TD>
											<DIV align="center"><A class="link" href="RegistrarEmpresa.aspx">Empresa</A></DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD>&nbsp;</TD>
										<TD>
											<DIV align="center"><A class="link" href="RegistrarServico.aspx">Servi�os</A></DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD>&nbsp;</TD>
										<TD>
											<DIV align="center"><A class="link" href="RegistrarProduto.aspx">Produtos</A></DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<DIV align="center">
												<DIV align="center"><A class="link" href="RegistrarServicoWeb.aspx">Servi�os Web</A></DIV>
											</DIV>
										</TD>
										<TD></TD>
									</TR>
									<TR>
										<TD width="28"><IMG height="25" src="../imagens/esqbaixo.gif" width="28"></TD>
										<TD>
											<DIV align="center"></DIV>
										</TD>
										<TD width="28"><IMG height="25" src="../imagens/dirbaixo.gif" width="28"></TD>
									</TR>
								</TABLE>
								<P class="TextoTabela">Seleccione o que pretende registrar.
								</P>
							</TD>
							<TD>&nbsp;</TD>
							<TD>
								<P class="TextoTabela" align="left">O SiSTUDDI permite publicar a informa��o 
									relativamente � empresa, servi�os,&nbsp;produtos e Servi�os Web.<BR>
									Qualquer informa��o que seja publicada fica imediatamente dispon�vel na 
									pesquisa.</P>
							</TD>
						</TR>
					</TABLE>
				</P>
			</FORM>
		</asp:panel>
		<asp:panel id="pnlLoginSemSucesso" Visible="False" HorizontalAlign="Center" Width="100%" runat="server">
			<TABLE id="Table5" borderColor="#000099" cellSpacing="0" cellPadding="30" width="750" align="center" border="1">
				<TR>
					<TD>
						<P align="justify"><FONT size="2">N�o tem permiss�es de acesso. Fa�a o Login <A class="link" href="../Administrar/login.aspx?origem=publicar">
									aqui</A>.</FONT></P>
						</FONT></TD>
				</TR>
			</TABLE>
		</asp:panel>
		<!--#include file="../include/menuBaixo.inc"-->
	</body>
</HTML>
