<%@ Page language="c#" Codebehind="RegistrarServico.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.publicar.RegistrarServico" %>
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
		<asp:panel id="pnlConteudo" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
			<FORM id="login" method="post" runat="server">
				<P>
					<TABLE id="conteudo" cellSpacing="0" cellPadding="0" width="100%" border="0">
						<TR>
							<TD width="22%">&nbsp;</FONT></B></TD>
							<TD width="2%">&nbsp;</TD>
							<TD width="76%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">Registro 
										de Serviço</FONT></B></TD>
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
								<asp:panel id="pnlPublicarTaxonomias" HorizontalAlign="Center" Width="100%" runat="server">
									<TABLE id="Table2" cellSpacing="0" cellPadding="1" width="100%" align="center" border="0">
										<TR>
											<TD class="TextoTabela">Para adicionar um serviço seleccione uma empresa 
												registradas e adicione o serviço.
											</TD>
										</TR>
										<TR>
											<TD>
												<DIV align="center"><STRONG>Empresas Registradas</STRONG>
													<TABLE id="tblEmpresa" cellSpacing="1" cellPadding="1" width="100%" border="0">
														<TR>
															<TD style="WIDTH: 134px">Empresa</TD>
															<TD>
																<asp:DropDownList id="cmbEmpresas" Width="190px" runat="server" on></asp:DropDownList>
																<asp:Button id="btnVerServicos" Width="150px" runat="server" Text="Ver Serviços"></asp:Button></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 134px"></TD>
															<TD>
																<asp:DropDownList id="cmbTemp" Width="190px" runat="server"></asp:DropDownList></TD>
														</TR>
														<TR>
															<TD style="WIDTH: 134px"></TD>
															<TD>
																<P>&nbsp;</P>
															</TD>
														</TR>
														<TR>
															<TD style="WIDTH: 134px" colSpan="2">
																<P align="center">
																	<asp:Button id="btnPublicarServicos" Width="150px" runat="server" Text="Adicionar Serviço"></asp:Button></P>
															</TD>
															<TD></TD>
														</TR>
													</TABLE>
													<STRONG>Registrar Serviço</STRONG>
													<asp:Panel id="pnlRegistrarServico" Visible="False" runat="server">
														<TABLE id="tblRegistrarServico" cellSpacing="1" cellPadding="1" width="100%" border="0">
															<TR>
																<TD style="WIDTH: 134px">Empresa</TD>
																<TD></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 134px">Actividade:</TD>
																<TD>
																	<asp:DropDownList id="cmbFamilia" Width="190px" runat="server" on></asp:DropDownList>
																	<asp:Button id="btnFamilia" Width="150px" runat="server" Text="Ver Categorias"></asp:Button></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 134px"></TD>
																<TD>
																	<asp:DropDownList id="cmbClasse" Width="190px" runat="server" Enabled="False"></asp:DropDownList>
																	<asp:Button id="btnClasse" Width="150px" runat="server" Text="Ver SubCategoria" Enabled="False"></asp:Button></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 134px"></TD>
																<TD>
																	<asp:DropDownList id="cmbElemento" Width="190px" runat="server" Enabled="False"></asp:DropDownList></TD>
															</TR>
															<TR>
																<TD style="WIDTH: 134px"></TD>
																<TD>
																	<asp:Label id="lblCodigo" Visible="False" Width="150px" runat="server"></asp:Label>
																	<asp:Label id="lblDescricao" Visible="False" Width="330px" runat="server"></asp:Label></TD>
															</TR>
														</TABLE>
														<asp:Button id="btnRegistrarServico" runat="server" Text="Registrar" Enabled="False"></asp:Button>
													</asp:Panel></DIV>
											</TD>
										</TR>
									</TABLE>
								</asp:panel></TD>
						</TR>
					</TABLE>
				</P>
			</FORM>
		</asp:panel>
		<asp:panel id="pnlLoginSemSucesso" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
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
