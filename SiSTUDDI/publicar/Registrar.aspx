<%@ Page language="c#" Codebehind="Registrar.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.publicar.Registrar" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<meta name=vs_showGrid content="False">
<title>Registrar Utilizador</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
  </HEAD>
	<body>
		<!--#include file="../include/topopublicar.inc"-->
		<P class="TituloAzul" align="center">Registrar Utilizador</P>
		<asp:panel id="pnlRegistrar" runat="server" Width="100%" Height="192px">
<FORM id=frmLogin method=post runat="server">
<TABLE id=tblLogin width="100%">
  <TR>
    <TD width="15%"></TD>
    <TD width="20%"><B>Nome Utilizador:<FONT color=#ff0000>*</FONT></B> </TD>
    <TD width="30%">
<asp:textbox id=txtUser Width="250px" runat="server"></asp:textbox></TD>
    <TD width="25%">
<asp:requiredfieldvalidator id=rfvUser Runat="server" ErrorMessage="Campo Necess�rio" ControlToValidate="txtUser"></asp:requiredfieldvalidator></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Password Utilizador:<FONT color=#ff0000>*</FONT></B> 
    <TD>
<asp:textbox id=txtPassword Width="250px" runat="server" TextMode="Password"></asp:textbox></TD>
    <TD>
<asp:requiredfieldvalidator id=rfvPassword Runat="server" ErrorMessage="Campo Necess�rio" ControlToValidate="txtPassword"></asp:requiredfieldvalidator></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Confirmar Password:<FONT color=#ff0000>*</FONT></B> </TD>
    <TD>
<asp:textbox id=txtConfirmaPassword Width="250px" runat="server" TextMode="Password"></asp:textbox></TD>
    <TD>
<asp:requiredfieldvalidator id=rfvConfirmaPassword Runat="server" ErrorMessage="Campo Necess�rio" ControlToValidate="txtConfirmaPassword"></asp:requiredfieldvalidator></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>email:<FONT color=#ff0000>*</FONT></B> </TD>
    <TD>
<asp:textbox id=txtEmail Width="250px" runat="server"></asp:textbox></TD>
    <TD>
<asp:requiredfieldvalidator id=rfvEmail Runat="server" ErrorMessage="Campo Necess�rio" ControlToValidate="txtEmail"></asp:requiredfieldvalidator></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Nome:<FONT color=#ff0000>*</FONT></B> </TD>
    <TD>
<asp:textbox id=txtNome Width="250px" runat="server"></asp:textbox></TD>
    <TD>
<asp:requiredfieldvalidator id=rfvNome Runat="server" ErrorMessage="Campo Necess�rio" ControlToValidate="txtNome"></asp:requiredfieldvalidator></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Nome Empresa:</B></TD>
    <TD>
<asp:textbox id=txtNomeEmpresa Width="250px" runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Telefone Empresa:</B></TD>
    <TD>
<asp:textbox id=txtTelefoneEmpresa Width="250px" runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Morada:</B></TD>
    <TD>
<asp:textbox id=txtMorada Width="250px" runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Localidade:</B></TD>
    <TD>
<asp:textbox id=txtLocalidade Width="250px" runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>C�digo Postal:</B></TD>
    <TD>
<asp:textbox id=txtCodigoPostal Width="250px" runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD></TD>
    <TD><B>Pa�s:</B></TD>
    <TD>
<asp:textbox id=txtPais Width="250px" runat="server"></asp:textbox></TD>
    <TD></TD></TR>
  <TR>
    <TD></TD>
    <TD></TD>
    <TD colSpan=2>
<asp:CompareValidator id=CompareValidator runat="server" ErrorMessage="As passwords n�o s�o iguais, confirme novamente!" ControlToValidate="txtConfirmaPassword" ControlToCompare="txtPassword"></asp:CompareValidator><BR>
<asp:Label id=lblMensagem runat="server" ForeColor="Red"></asp:Label></TD></TR></TABLE>
<P></P>
<DIV align=center><FONT color=#ff0000>*</FONT> - Campo Obrigat�rio</DIV>
<DIV align=center><BR>
<asp:button id=btnRegistrar runat="server" Text="Registrar"></asp:button></DIV></FORM>
		</asp:panel><asp:panel id="pnlErro" runat="server" Width="100%" Visible="False" Wrap="True">
<P class="">Ocorreu um erro, entre em contacto com o <A class=link 
href="mailto:sobreiro@esdrm.pt">administrador do sistema</A> reportando a 
mensagem abaixo indicada.</P><BR>
		</asp:panel><asp:panel id="pnlSucesso" runat="server" Width="100%" Visible="False" Wrap="True">
<P class=textoNormal><B>Obrigado por se registrar no nosso 
servidor!</B><BR><BR>Vai ser redireccionado para a �rea privada onde poder� 
publicar informa��o relativamente � sua empresa e alterar os dados publicados. 
Caso o redireccionamento n�o ocorra autom�ticamente pode carregar <A class=link 
href="../Administrar/login.aspx?origem=publicar">aqui.</A> </P>
<P class=textoNormal>N�o se esque�a de ver o correio electr�nico para proceder � 
activa��o da sua conta, para ter acesso � �rea privada.</P><BR>
		</asp:panel>
		<DIV align="center">
			<table width="100%">
				<tr class="textoLink" bgColor="#b0c4de">
					<td align="middle"><A class="link" href="../../SistPortal/index.html">In�cio</A> <A class="link" href="javascript:window.history.back()">
							Voltar</A> Link's principais da aplica��o....................</td>
				</tr>
			</table>
		</DIV>
	</body>
</HTML>