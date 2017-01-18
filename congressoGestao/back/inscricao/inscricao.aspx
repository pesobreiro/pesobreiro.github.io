<%@ Page language="c#" Codebehind="inscricao.aspx.cs" AutoEventWireup="false" Inherits="congressoGestao.Inscricao" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 155px; POSITION: absolute; TOP: 15px" runat="server" Width="201px" Height="40px" Font-Bold="True" Font-Italic="True">Pré-Inscrição na Conferência</asp:Label>
			<asp:TextBox id="txtTelefone" style="Z-INDEX: 115; LEFT: 137px; POSITION: absolute; TOP: 248px" runat="server" Width="91px" tabIndex="6"></asp:TextBox>
			<asp:TextBox id="txtEmail" style="Z-INDEX: 114; LEFT: 137px; POSITION: absolute; TOP: 218px" runat="server" Width="183px" tabIndex="5"></asp:TextBox>
			<asp:TextBox id="txtCodPostal" style="Z-INDEX: 113; LEFT: 137px; POSITION: absolute; TOP: 190px" runat="server" Width="183px" tabIndex="4"></asp:TextBox>
			<asp:TextBox id="txtLocalidade" style="Z-INDEX: 112; LEFT: 137px; POSITION: absolute; TOP: 159px" runat="server" Width="185px" tabIndex="3"></asp:TextBox>
			<asp:TextBox id="txtMorada" style="Z-INDEX: 111; LEFT: 137px; POSITION: absolute; TOP: 126px" runat="server" Width="230px" tabIndex="2"></asp:TextBox>
			<asp:TextBox id="txtNome" style="Z-INDEX: 110; LEFT: 137px; POSITION: absolute; TOP: 95px" runat="server" Width="232px" tabIndex="1"></asp:TextBox>
			<asp:Label id="Label8" style="Z-INDEX: 108; LEFT: 30px; POSITION: absolute; TOP: 253px" runat="server" Width="70px" Height="21px">Telefone:</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 107; LEFT: 30px; POSITION: absolute; TOP: 224px" runat="server" Width="69px" Height="21px">e-Mail:</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 106; LEFT: 28px; POSITION: absolute; TOP: 192px" runat="server" Width="102px" Height="21px">Código Postal:</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 105; LEFT: 30px; POSITION: absolute; TOP: 159px" runat="server" Width="73px" Height="21px">Localidade:</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 30px; POSITION: absolute; TOP: 127px" runat="server" Width="73px" Height="21px">Morada:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 30px; POSITION: absolute; TOP: 96px" runat="server" Width="73px" Height="21px">Nome:</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 30px; POSITION: absolute; TOP: 66px" runat="server" Width="73px" Height="21px">Instituição:</asp:Label>
			<asp:TextBox id="txtInstituicao" style="Z-INDEX: 109; LEFT: 137px; POSITION: absolute; TOP: 65px" runat="server" Width="231px"></asp:TextBox>
			<asp:RadioButtonList id="rbComunicacao" style="Z-INDEX: 117; LEFT: 384px; POSITION: absolute; TOP: 213px" runat="server" Width="205px" Height="30px" tabIndex="7">
				<asp:ListItem Value="0" Selected="True">Sem Comunica&#231;&#227;o (100€)</asp:ListItem>
				<asp:ListItem Value="1">Com Comunica&#231;&#227;o (75€)</asp:ListItem>
			</asp:RadioButtonList>
			<asp:Label id="Label9" style="Z-INDEX: 118; LEFT: 33px; POSITION: absolute; TOP: 284px" runat="server" Width="558px" Height="40px" Font-Size="Smaller">A inscrição só é válida após o pagamento emitido à ordem da Escola Superior de Desporto de Rio Maior</asp:Label>
			<asp:Button id="btnEnviar" style="Z-INDEX: 119; LEFT: 226px; POSITION: absolute; TOP: 337px" runat="server" Width="95px" Height="30px" Text="Enviar"></asp:Button>
		</form>
	</body>
</HTML>
