<%@ Page language="c#" Codebehind="index.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.administrar.index" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>index</title>
		<meta content="False" name="vs_showGrid">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<!--#include file="../include/topoadmin.inc"-->
		<asp:panel id="pnlConteudo" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
			<FORM id="login" method="post" runat="server">
				<TABLE id="conteudo" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD width="22%">&nbsp;</FONT></B></TD>
						<TD width="2%">&nbsp;</TD>
						<TD width="76%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">Página 
									de Administração do SiST</FONT></B></TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 20px" width="22%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">SiSTUDDI</FONT></B></TD>
						<TD style="HEIGHT: 20px">&nbsp;</TD>
						<TD style="HEIGHT: 20px">&nbsp;</TD>
					</TR>
					<TR>
						<TD style="HEIGHT: 18px" bgColor="#ffffff">&nbsp;</TD>
						<TD style="HEIGHT: 18px">&nbsp;</TD>
						<TD style="HEIGHT: 18px">&nbsp;</TD>
					</TR>
					<TR>
						<TD bgColor="#ffffff">
							<TABLE cellSpacing="0" cellPadding="0" width="212" bgColor="#e2e2e2" border="0">
								<TR>
									<TD width="28"><IMG height="33" src="../imagens/esqcima.gif" width="28"></TD>
									<TD width="156"><B>
											<P class="texto" align="center">Opções</P>
										</B>
									</TD>
									<TD width="28"><IMG height="33" src="../imagens/dircima.gif" width="28"></TD>
								</TR>
								<TR>
									<TD>&nbsp;</TD>
									<TD>
										<DIV align="center"><A class="link" href="../SiSTUDDI/Pesquisar/Pesquisar.aspx">Acessos</A></DIV>
									</TD>
									<TD>&nbsp;</TD>
								</TR>
								<TR>
									<TD>&nbsp;</TD>
									<TD>
										<DIV align="center">
											<asp:LinkButton id="lbtnTaxonomias" runat="server" CssClass="link">Taxonomias</asp:LinkButton></DIV>
									</TD>
									<TD>&nbsp;</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 20px">&nbsp;</TD>
									<TD style="HEIGHT: 20px">
										<DIV align="center">
											<DIV align="center">
												<asp:LinkButton id="lbtnAlterar" runat="server" CssClass="link">Alterar</asp:LinkButton></DIV>
										</DIV>
									</TD>
									<TD style="HEIGHT: 20px">&nbsp;</TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 20px"></TD>
									<TD style="HEIGHT: 20px">
										<DIV align="center">
											<asp:LinkButton id="lbtnEliminar" runat="server" CssClass="link">Eliminar</asp:LinkButton></DIV>
									</TD>
									<TD style="HEIGHT: 20px"></TD>
								</TR>
								<TR>
									<TD width="28"><IMG height="25" src="../imagens/esqbaixo.gif" width="28"></TD>
									<TD>
										<DIV align="center"></DIV>
									</TD>
									<TD width="28"><IMG height="25" src="../imagens/dirbaixo.gif" width="28"></TD>
								</TR>
							</TABLE>
						</TD>
						<TD>&nbsp;</TD>
						<TD>
							<asp:panel id="pnlRegistrarUser" Visible="False" HorizontalAlign="Center" Width="100%" runat="server">
								<TABLE id="Table1" cellSpacing="0" cellPadding="30" width="100%" align="center" border="0">
									<TR>
										<TD>
											<P align="center"><FONT class="tituloazul" size="2">Gestão de Taxonomias</FONT>&nbsp;</P>
										</TD>
									</TR>
									<TR>
										<TD>
											<DIV align="center"><A class="link" href="PublicarTaxonomias.aspx">Publicar Taxonomias</A><BR>
												<A class="link" href="../SiSTUDDI/Pesquisar/Pesquisar.aspx">Visualizar Taxonomias</A>
											</DIV>
										</TD>
									</TR>
								</TABLE>
							</asp:panel>
							<asp:panel id="pnlPublicarTaxonomias" Visible="False" HorizontalAlign="Center" Width="100%" runat="server" DESIGNTIMEDRAGDROP="12">
								<TABLE id="Table2" cellSpacing="0" cellPadding="30" width="100%" align="center" border="0">
									<TR>
										<TD>
											<P align="center"><FONT class="tituloazul" size="2">Gestão de Taxonomias</FONT>&nbsp;</P>
										</TD>
									</TR>
									<TR>
										<TD>
											<DIV align="center"><A class="link" href="PublicarTaxonomias.aspx">Publicar Taxonomias</A><BR>
												<A class="link" href="../SiSTUDDI/Pesquisar/Pesquisar.aspx">Visualizar Taxonomias</A>
											</DIV>
										</TD>
									</TR>
								</TABLE>
							</asp:panel></TD>
					</TR>
					<TR>
						<TD bgColor="#ffffff">
							<DIV align="center">Colocar os menus principais da aplicação</DIV>
						</TD>
						<TD>&nbsp;</TD>
						<TD>&nbsp;</TD>
					</TR>
				</TABLE>
			</FORM>
		</asp:panel>
		<P></P>
		<asp:panel id="pnlLoginSemSucesso" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
			<TABLE id="Table5" borderColor="#000099" cellSpacing="0" cellPadding="30" width="750" align="center" border="1">
				<TR>
					<TD>
						<P align="justify"><FONT size="2">Não tem permissões de acesso. Faça o Login <A class="link" href="login.aspx?origem=administrar">
									aqui</A>.</FONT></P>
						</FONT></TD>
				</TR>
			</TABLE>
		</asp:panel>
	</body>
</HTML>
