<%@ Page language="c#" Codebehind="login.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.administrar.login" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>login</title>
		<meta content="True" name="vs_showGrid">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body>
		<!--#include file="../include/topoadmin.inc"-->
		<p class="TituloAzul" id="H11" align="center"><b>Login</b></p>
		<form id="login" method="post" runat="server">
			<asp:label id="lblUsername" runat="server" Width="113px"></asp:label><asp:panel id="pnlLogIn" runat="server" Width="100%" HorizontalAlign="Center">
				<TABLE id="Table1" borderColor="#000099" cellSpacing="0" cellPadding="30" width="750" align="center" border="1">
					<TR>
						<TD>
							<P align="justify"><FONT size="2">Para ter acesso a esta área reservada, tem ter um 
									nome de utilizador e uma password. Pode obtê-la <A class="link" href="../publicar/Registrar.aspx">
										aqui</A>.</FONT>
							</P>
							<P align="justify">
								<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="300" align="center" border="0">
									<TR>
										<TD width="125"><STRONG><FONT size="2">Nome Utilizador <FONT color="#ff0000">*</FONT></FONT></STRONG></TD>
										<TD>
											<P align="center">
												<asp:textbox id="txtUsername" runat="server" Width="175px" BorderStyle="Solid" Font-Names="Verdana" Font-Size="X-Small"></asp:textbox></P>
										</TD>
									</TR>
									<TR>
										<TD width="125"></TD>
										<TD>
											<P align="center">
												<asp:requiredfieldvalidator id="RequiredFieldValidator1" runat="server" Font-Size="X-Small" ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="Campo necessário!"></asp:requiredfieldvalidator></P>
										</TD>
									</TR>
									<TR>
										<TD width="125"><STRONG><FONT size="2">Palavra Passe <FONT color="#ff0000">*</FONT></FONT></STRONG></TD>
										<TD>
											<P align="center">
												<asp:textbox id="txtPassword" runat="server" Width="175px" BorderStyle="Solid" Font-Names="Verdana" Font-Size="X-Small" TextMode="Password" CssClass="link"></asp:textbox></P>
										</TD>
									</TR>
									<TR>
										<TD width="125"></TD>
										<TD>
											<P align="center">
												<asp:requiredfieldvalidator id="Requiredfieldvalidator2" runat="server" Font-Size="X-Small" ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="Campo Necessário!"></asp:requiredfieldvalidator></P>
										</TD>
									</TR>
									<TR>
										<TD width="125"></TD>
										<TD>
											<P align="right">
												<asp:LinkButton id="LinkBtnLogin" runat="server" CssClass="link">Enviar</asp:LinkButton></P>
										</TD>
									</TR>
									<TR>
										<TD width="125"></TD>
										<TD>
											<P align="center">
												<asp:Label id="lblLogin" runat="server" Font-Size="X-Small" Visible="False" ForeColor="Red">Nome utilizador, password inválida ou ainda não activou a sua conta.</asp:Label>
												<asp:Label id="lblConta" runat="server" Font-Size="X-Small" Visible="False" ForeColor="Red">A sua conta está desactivada</asp:Label></P>
										</TD>
									</TR>
								</TABLE>
							</P>
							<P class="TextoTabela" align="center"><FONT color="#ff0000">*</FONT> Campo 
								Obrigatório</P>
						</TD>
					</TR>
				</TABLE>
			</asp:panel>
			<P><asp:panel id="pnlLogincomSucesso" runat="server" Width="100%" HorizontalAlign="Center" Visible="False" Height="77px">
					<TABLE id="Table5" borderColor="#000099" cellSpacing="0" cellPadding="30" width="750" align="center" border="1">
						<TR>
							<TD>
								<P align="justify"><FONT size="2">Entrou com sucesso.</FONT></P>
								</FONT></TD>
						</TR>
					</TABLE>
				</asp:panel></P>
		</form>
		<!--#include file="../include/menubaixo.inc"-->
	</body>
</HTML>
