<%@ Page language="c#" Codebehind="RegistrarProduto.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.publicar.RegistrarProduto" %>
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
										de Produtos</FONT></B></TD>
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
											<DIV align="center">
												<DIV align="center"><A class="link" href="RegistrarEmpresa.aspx">Empresa</A></DIV>
											</DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD>&nbsp;</TD>
										<TD>
											<DIV align="center">
												<DIV align="center"><A class="link" href="RegistrarServico.aspx">Serviços</A></DIV>
											</DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD>&nbsp;</TD>
										<TD>
											<DIV align="center">
												<DIV align="center"><A class="link" href="RegistrarProduto.aspx">Produtos</A></DIV>
											</DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<DIV align="center">
												<DIV align="center">
													<DIV align="center"><A class="link" href="RegistrarServicoWeb.aspx">Serviços Web</A></DIV>
												</DIV>
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
								<asp:panel id="pnlPublicarTaxonomias" runat="server" Width="100%" HorizontalAlign="Center">
									<TABLE id="Table2" cellSpacing="0" cellPadding="30" width="100%" align="center" border="0">
										<TR>
											<TD>
												<P class="TextoTabela" align="left">O SiSTUDDI permite publicar a informação 
													relativamente à empresa, serviços,&nbsp;produtos e Serviços Web.<BR>
													Qualquer informação que seja publicada fica imediatamente disponível na 
													pesquisa.</P>
											</TD>
										</TR>
										<TR>
											<TD>
												<DIV align="center">
													<P>Produtos</P>
													<TABLE id="tableEmpresa" cellSpacing="1" cellPadding="1" width="100%" border="0">
														<TR>
															<TD width="20%">Nome:</TD>
															<TD width="75%">
																<asp:TextBox id="txtNome" runat="server" Width="330px"></asp:TextBox>
																<asp:RequiredFieldValidator id="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="Campo Necessário"></asp:RequiredFieldValidator></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 134px">Descrição:</TD>
															<TD>
																<asp:TextBox id="txtDescricao" runat="server" Width="330px"></asp:TextBox>
																<asp:RequiredFieldValidator id="rfvDescricao" runat="server" ControlToValidate="txtDescricao" ErrorMessage="Campo Necessário"></asp:RequiredFieldValidator></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 134px">Contacto:</TD>
															<TD>
																<asp:TextBox id="txtContacto" runat="server" Width="330px"></asp:TextBox>
																<asp:RequiredFieldValidator id="rfvContacto" runat="server" ControlToValidate="txtContacto" ErrorMessage="Campo Necessário"></asp:RequiredFieldValidator></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 134px">Função Contacto:</TD>
															<TD>
																<asp:TextBox id="txtFuncaoContacto" runat="server" Width="330px"></asp:TextBox>
																<asp:RequiredFieldValidator id="rfvFuncaoContacto" runat="server" ControlToValidate="txtFuncaoContacto" ErrorMessage="Campo Necessário"></asp:RequiredFieldValidator></TD>
														</TR>
													</TABLE>
													<P>
														<asp:Button id="btnRegistrarEmpresa" runat="server" Text="Registrar"></asp:Button></P>
												</DIV>
											</TD>
										</TR>
									</TABLE>
								</asp:panel></TD>
						</TR>
					</TABLE>
				</P>
			</FORM>
		</asp:panel>
		<asp:panel id="pnlLoginSemSucesso" Visible="False" HorizontalAlign="Center" Width="100%" runat="server">
			<TABLE id="Table5" borderColor="#000099" cellSpacing="0" cellPadding="30" width="750" align="center" border="1">
				<TR>
					<TD>
						<P align="justify"><FONT size="2">Não tem permissões de acesso. Faça o Login <A class="link" href="../Administrar/login.aspx?origem=publicar">
									aqui</A>.</FONT></P>
						</FONT></TD>
				</TR>
			</TABLE>
		</asp:panel>
		<!--#include file="../include/menuBaixo.inc"-->
	</body>
</HTML>
