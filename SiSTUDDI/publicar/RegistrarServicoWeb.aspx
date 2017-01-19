<%@ Page language="c#" Codebehind="RegistrarServicoWeb.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.publicar.RegistrarServicoWeb" %>
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
						<TBODY>
							<TR>
								<TD width="22%">&nbsp;</FONT></B></TD>
								<TD width="2%">&nbsp;</TD>
								<TD width="76%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">Registo 
											de Serviços Web</FONT></B></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 20px" width="22%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">SiSTUDDI</FONT></B></TD>
								<TD style="HEIGHT: 20px">&nbsp;</TD>
								<TD style="HEIGHT: 20px">&nbsp;</TD>
							</TR>
							<TR>
								<TD bgColor="#ffffff">&nbsp;</TD>
								<TD>&nbsp;</TD>
								<TD class="TextoTabela">Para adicionar um serviço seleccione uma empresa registrada 
									e adicione o serviço.
								</TD>
							</TR>
							<TR>
								<TD vAlign="top" bgColor="#ffffff">
									<TABLE cellSpacing="0" cellPadding="0" width="100%" bgColor="#e2e2e2" border="0">
										<TR>
											<TD width="28"><IMG height="33" src="../imagens/esqcima.gif" width="28"></TD>
											<TD width="156">
												<P class="texto" align="center">Registar:</P>
											</TD>
											<TD width="28"><IMG height="33" src="../imagens/dircima.gif" width="28"></TD>
										</TR>
										<TR>
											<TD></TD>
											<TD>
												<DIV align="center"><A class="link" href="index.aspx">Registos realizados</A></DIV>
											</TD>
											<TD></TD>
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
													<DIV align="center"><A class="link" href="RegistrarServico.aspx">Serviços/Produtos</A></DIV>
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
									<P class="TextoTabela">A descrição do serviço incluí o nome do serviço, bem como:</P>
									<UL>
										<LI>
											<DIV class="TextoTabela" align="left">Descrição do serviço</DIV>
										<LI>
											<DIV class="TextoTabela" align="left">Implementação do serviço(Ponto de acesso ao 
												serviço)</DIV>
										<LI>
											<DIV class="TextoTabela" align="left">Classificação do serviço</DIV>
										<LI>
											<DIV class="TextoTabela" align="left">Descrição do modelo de invoção do serviço</DIV>
										</LI>
									</UL>
								</TD>
								<TD>&nbsp;</TD>
								<TD>
									<asp:panel id="pnlPublicarTaxonomias" runat="server" Width="100%" HorizontalAlign="Center">
										<TABLE id="Table2" cellSpacing="0" cellPadding="30" width="100%" align="center" border="1">
											<TBODY>
												<TR>
													<TD style="HEIGHT: 576px" vAlign="top">
														<DIV align="center">
															<TABLE id="tableListaEmpresa" cellSpacing="1" cellPadding="1" width="100%" border="0">
																<TR>
																	<TD width="20%"><STRONG><EM>Empresa:</EM></STRONG></TD>
																	<TD>
																		<asp:DropDownList id="cmbEmpresas" runat="server" Width="190px"></asp:DropDownList>
																		<asp:Button id="btnVerServicos" runat="server" Width="150px" Text="Ver Serviços"></asp:Button></TD>
																</TR>
																<TR>
																	<TD width="20%"></TD>
																	<TD>
																		<asp:DropDownList id="cmbServicos" runat="server" Width="190px"></asp:DropDownList></TD>
																</TR>
																<TR>
																	<TD width="20%" colSpan="2">
																		<asp:Button id="btnAdicionar" runat="server" Width="150px" Text="Adicionar  Serviços"></asp:Button></TD>
																</TR>
															</TABLE>
														</DIV>
														<P align="center"><STRONG><EM>
																	<asp:Panel id="pnlDefinirPontos" runat="server" Width="100%" Visible="False">Serviço 
																	Web</EM></STRONG></P>
														<P></P>
														<DIV align="center">
															<TABLE id="tableEmpresa" cellSpacing="1" cellPadding="1" width="100%" border="0">
																<TR>
																	<TD style="HEIGHT: 26px" width="20%">Nome:</TD>
																	<TD style="HEIGHT: 26px">
																		<asp:TextBox id="txtNome" runat="server" Width="330px"></asp:TextBox>
																		<asp:RequiredFieldValidator id="rfvNome" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="txtNome"></asp:RequiredFieldValidator></TD>
																</TR>
																<TR>
																	<TD vAlign="top" width="20%">Descrição:</TD>
																	<TD>
																		<asp:TextBox id="txtDescricao" runat="server" Width="330px" Height="46px"></asp:TextBox>
																		<asp:RequiredFieldValidator id="rfvDescricao" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="txtDescricao"></asp:RequiredFieldValidator></TD>
																</TR>
																<TR>
																	<TD width="20%"></TD>
																	<TD>
																		<asp:Button id="btnDefinirBinding" runat="server" Width="90px" Text="Definir pontos acesso"></asp:Button></TD>
																</TR>
															</TABLE>
														</DIV>
														<P align="center">
									</asp:panel>
					</EM></STRONG></P>
				<P align="center">
					<asp:Panel id="pnlRegistrarServicoWeb" runat="server" Width="100%" Visible="False" Height="226px">
						<TABLE id="tblRegistrarServico" cellSpacing="1" cellPadding="1" width="100%" border="0">
							<TR>
								<TD width="20%"><STRONG>Pontos de acesso</STRONG></TD>
								<TD>
									<P class="TextoTabela" align="left">Um serviço pode ter Endereços que permitem 
										invocar o serviço. Podem ser URLs, eMails ou números de telefone</P>
								</TD>
							</TR>
							<TR>
								<TD width="20%">Descrição</TD>
								<TD>
									<P class="TextoTabela" align="left">
										<asp:TextBox id="txtDescricaoPAcesso" runat="server" Width="330px"></asp:TextBox>
										<asp:RequiredFieldValidator id="rfvDescricaoPAcesso" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="txtDescricaoPAcesso"></asp:RequiredFieldValidator></P>
								</TD>
							</TR>
							<TR>
								<TD width="20%">Tipo de URL</TD>
								<TD>
									<asp:DropDownList id="cmbTiposUrl" runat="server" Width="73px" on>
										<asp:ListItem Value="uuid:93335D49-3EFB-48A0-ACEA-EA102B60DDC6">smtp</asp:ListItem>
										<asp:ListItem Value="uuid:1A2B00BE-6E2C-42F5-875B-56F32686E0E7">fax</asp:ListItem>
										<asp:ListItem Value="uuid:5FCF5CD0-629A-4C50-8B16-F94E9CF2A674">ftp</asp:ListItem>
										<asp:ListItem Value="uuid:38E12427-5536-4260-A6F9-B5B530E63A07">telefone</asp:ListItem>
										<asp:ListItem Value="uuid:68DE9E80-AD09-469D-8A37-088422BFBC36" Selected="True">http</asp:ListItem>
										<asp:ListItem Value=" uuid:4CEC1CEF-1F68-4B23-8CB7-8BAA763AEB89">homepage</asp:ListItem>
									</asp:DropDownList>
									<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="cmbTiposUrl"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD width="20%">URL Ponto&nbsp;Acesso</TD>
								<TD>
									<asp:TextBox id="txtURLPontoAcesso" runat="server" Width="330px"></asp:TextBox>
									<asp:RequiredFieldValidator id="rfvURLPontoAcesso" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="txtURLPontoAcesso"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 17px" vAlign="top" width="20%">Classificação:</TD>
								<TD style="HEIGHT: 17px">
									<asp:DropDownList id="cmbtModel" runat="server" Width="190px"></asp:DropDownList>
									<asp:RequiredFieldValidator id="rfvClassificacao" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="cmbtModel"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD vAlign="top" width="20%"><STRONG>Dados do serviço</STRONG></TD>
								<TD>
									<P class="TextoTabela" align="left">Descrição da definição do serviço identificado 
										no ponto de acesso e URLs com documentação referente ao serviço</P>
								</TD>
							</TR>
							<TR>
								<TD vAlign="top" width="20%">Descrição:</TD>
								<TD>
									<asp:TextBox id="txtDocPontoAcesso" runat="server" Width="338px" Height="46px" TextMode="MultiLine"></asp:TextBox></TD>
							</TR>
							<TR>
								<TD width="20%">URL Descrição</TD>
								<TD>
									<asp:TextBox id="txtURLDocPontoAcesso" runat="server" Width="338px"></asp:TextBox>
									<asp:RequiredFieldValidator id="rfvURLDescricao" runat="server" ErrorMessage="Campo Necessário" ControlToValidate="txtURLDocPontoAcesso"></asp:RequiredFieldValidator></TD>
							</TR>
							<TR>
								<TD width="20%"></TD>
								<TD>
									<asp:Button id="btnCriarBinding" runat="server" Width="90px" Text="Registrar"></asp:Button></TD>
							</TR>
						</TABLE>
					</asp:Panel></P>
				</TD></TR>
				<TR>
					<TD vAlign="top"></TD>
				</TR></TBODY></TABLE>
		</asp:panel></TD></TR></TBODY></TABLE></P></FORM></asp:panel>
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
