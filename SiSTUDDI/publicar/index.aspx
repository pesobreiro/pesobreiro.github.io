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
							<TD width="76%" bgColor="#b0c4de"><B><FONT face="Arial, Helvetica, sans-serif" color="#ffffff">Registo 
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
											<P class="texto" align="center">Registar:</P>
										</TD>
										<TD width="28"><IMG height="33" src="../imagens/dircima.gif" width="28"></TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<DIV align="center"><A class="link" href="index.aspx">Registos realizados</A>&nbsp;</DIV>
										</TD>
										<TD></TD>
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
											<DIV align="center"><A class="link" href="RegistrarServico.aspx">Serviços/Produtos</A></DIV>
										</TD>
										<TD>&nbsp;</TD>
									</TR>
									<TR>
										<TD></TD>
										<TD>
											<DIV align="center">
												<DIV align="center"><A class="link" href="RegistrarServicoWeb.aspx">Serviços Web</A></DIV>
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
								<P class="TextoTabela" align="left">O SiSTUDDI permite publicar a informação 
									relativamente à empresa, serviços,&nbsp;produtos e Serviços Web.<BR>
									Qualquer informação que seja publicada fica imediatamente disponível na 
									pesquisa.</P>
								<P class="TextoTabela" align="center"><B>Empresas Registadas</B></P>
								<P class="TextoTabela" align="left">
									<asp:DataGrid id="DataGridEmpresas" runat="server" Width="100%" AutoGenerateColumns="False" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Horizontal" OnItemCreated="ScriptDelete">
										<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
										<EditItemStyle Font-Size="Smaller"></EditItemStyle>
										<AlternatingItemStyle Font-Size="Smaller" BackColor="#F7F7F7"></AlternatingItemStyle>
										<ItemStyle Font-Size="Smaller" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
										<HeaderStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
										<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
										<Columns>
											<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Actualizar" CancelText="Cancelar" EditText="Editar"></asp:EditCommandColumn>
											<asp:ButtonColumn Text="Eliminar" CommandName="Delete"></asp:ButtonColumn>
											<asp:BoundColumn DataField="businessKey" ReadOnly="True" HeaderText="BusinessKey"></asp:BoundColumn>
											<asp:BoundColumn DataField="Nome" HeaderText="Nome"></asp:BoundColumn>
											<asp:BoundColumn DataField="Descricao" HeaderText="Descri&#231;&#227;o"></asp:BoundColumn>
											<asp:BoundColumn DataField="Contacto" HeaderText="Contacto"></asp:BoundColumn>
											<asp:BoundColumn DataField="FuncaoContacto" HeaderText="Fun&#231;&#227;o"></asp:BoundColumn>
											<asp:TemplateColumn></asp:TemplateColumn>
										</Columns>
										<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
									</asp:DataGrid></P>
							</TD>
						</TR>
					</TABLE>
				</P>
			</FORM>
			<P>
				<asp:Label id="lblMessagem" runat="server" Width="225px"></asp:Label></P>
			<P>&nbsp;</P>
		</asp:panel><asp:panel id="pnlLoginSemSucesso" Visible="False" HorizontalAlign="Center" Width="100%" runat="server">
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
