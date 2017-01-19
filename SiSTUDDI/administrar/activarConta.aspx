<%@ Page language="c#" Codebehind="activarConta.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.administrar.activarConta" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>activarConta</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="activarConta" method="post" runat="server">
			<div align="center">
				<asp:Label id="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
				<asp:panel id="pnlSucesso" runat="server" Visible="False" Wrap="True" Width="100%">
					<P class="textoNormal"><B>Obrigado por activar o sua conta!</B><BR>
						<BR>
						Vai ser redireccionado para poder realizar o Login, para poder ter acesso à 
						publicação da&nbsp;informação relativamente à sua empresa. Caso o 
						redireccionamento não ocorra automáticamente pode carregar <A class="link" href="../Administrar/login.aspx?origem=publicar">
							aqui.</A>
					</P>
					<BR>
				</asp:panel>
			</div>
		</form>
	</body>
</HTML>
