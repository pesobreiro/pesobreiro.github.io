<%@ Page language="c#" Codebehind="Inscricao.aspx.cs" AutoEventWireup="false" Inherits="CongressoPsicologia.WebForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Congresso de Psicologia</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 72px; POSITION: absolute; TOP: 8px" runat="server"
				Width="424px" Height="24px" Font-Bold="True" Font-Italic="True">Pré Inscrição no curso de programação neuro linguística</asp:Label>
			<asp:TextBox id="txtContribuinte" style="Z-INDEX: 116; LEFT: 128px; POSITION: absolute; TOP: 272px"
				tabIndex="8" runat="server" Width="184px"></asp:TextBox>
			<asp:TextBox id="txtEmail" style="Z-INDEX: 114; LEFT: 128px; POSITION: absolute; TOP: 208px"
				tabIndex="6" runat="server" Width="183px"></asp:TextBox>
			<asp:TextBox id="txtCodPostal" style="Z-INDEX: 113; LEFT: 128px; POSITION: absolute; TOP: 176px"
				tabIndex="5" runat="server" Width="183px"></asp:TextBox>
			<asp:TextBox id="txtLocalidade" style="Z-INDEX: 112; LEFT: 128px; POSITION: absolute; TOP: 152px"
				tabIndex="4" runat="server" Width="185px"></asp:TextBox>
			<asp:TextBox id="txtMorada" style="Z-INDEX: 111; LEFT: 128px; POSITION: absolute; TOP: 112px"
				tabIndex="3" runat="server" Width="230px"></asp:TextBox>
			<asp:TextBox id="txtNome" style="Z-INDEX: 110; LEFT: 128px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Width="232px"></asp:TextBox>
			<asp:Label id="Label8" style="Z-INDEX: 108; LEFT: 24px; POSITION: absolute; TOP: 248px" runat="server"
				Height="21px" Width="70px">Telefone:</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 216px" runat="server"
				Height="21px" Width="69px">e-Mail:</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 184px" runat="server"
				Height="21px" Width="102px">Código Postal:</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 105; LEFT: 16px; POSITION: absolute; TOP: 152px" runat="server"
				Height="21px" Width="73px">Localidade:</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 120px" runat="server"
				Height="21px" Width="73px">Morada:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 88px" runat="server"
				Height="21px" Width="73px">Nome:</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 56px" runat="server"
				Height="21px" Width="73px">Instituição:</asp:Label>
			<asp:TextBox id="txtInstituicao" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 56px"
				runat="server" Width="231px" tabIndex="1"></asp:TextBox>
			<asp:Label id="Label9" style="Z-INDEX: 117; LEFT: 24px; POSITION: absolute; TOP: 400px" runat="server"
				Height="32px" Width="558px" Font-Size="Smaller">Curso completo com documentação e personalização do modo de pagamento.			
				</asp:Label>
			<asp:Button id="btnEnviar" style="Z-INDEX: 118; LEFT: 216px; POSITION: absolute; TOP: 432px"
				runat="server" Height="30px" Width="95px" Text="Enviar" tabIndex="11"></asp:Button>
			<P align="center">
				<asp:HyperLink id="HyperLink1" style="Z-INDEX: 119; LEFT: 248px; POSITION: absolute; TOP: 472px"
					runat="server" NavigateUrl="index.html">Voltar</asp:HyperLink>
				<asp:RequiredFieldValidator id="RequiredFieldValidator2" style="Z-INDEX: 127; LEFT: 384px; POSITION: absolute; TOP: 248px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtTelefone"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator8" style="Z-INDEX: 126; LEFT: 384px; POSITION: absolute; TOP: 216px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator7" style="Z-INDEX: 125; LEFT: 384px; POSITION: absolute; TOP: 184px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtCodPostal"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator5" style="Z-INDEX: 124; LEFT: 384px; POSITION: absolute; TOP: 152px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtLocalidade"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator4" style="Z-INDEX: 123; LEFT: 384px; POSITION: absolute; TOP: 120px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtMorada"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator3" style="Z-INDEX: 122; LEFT: 384px; POSITION: absolute; TOP: 88px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
				<asp:Panel id="PnlObrigado" style="Z-INDEX: 120; LEFT: 448px; POSITION: absolute; TOP: 312px"
					runat="server" Height="8px" Width="212px" Visible="False">
					<P>&nbsp;</P>
				</asp:Panel>
				<asp:RequiredFieldValidator id="RequiredFieldValidator1" style="Z-INDEX: 121; LEFT: 384px; POSITION: absolute; TOP: 56px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtInstituicao"></asp:RequiredFieldValidator><A href="javascript:window.history.back()"></A>
			<P>
				<asp:Label id="Label10" style="Z-INDEX: 128; LEFT: 24px; POSITION: absolute; TOP: 280px" runat="server"
					Height="21px" Width="70px">Contribuinte:</asp:Label>
				<asp:RadioButtonList id="rbComunicacao" style="Z-INDEX: 129; LEFT: 128px; POSITION: absolute; TOP: 304px"
					tabIndex="9" runat="server" Height="30px" Width="288px">
					<asp:ListItem Value="Inscri&#231;&#227;o - 100€" Selected="True">Inscri&#231;&#227;o - 100€</asp:ListItem>
					<asp:ListItem Value="Forma&#231;&#227;o - 700€ + 100€ Inscri&#231;&#227;o">Forma&#231;&#227;o - 700€ + 100€ Inscri&#231;&#227;o</asp:ListItem>
				</asp:RadioButtonList>
				<asp:TextBox id="txtTelefone" style="Z-INDEX: 115; LEFT: 128px; POSITION: absolute; TOP: 240px"
					tabIndex="7" runat="server" Width="184px"></asp:TextBox>
			</P>
			<P>
				<asp:Label id="lblMsg" style="Z-INDEX: 130; LEFT: 32px; POSITION: absolute; TOP: 368px" runat="server"
					Font-Bold="True" Width="545px" ForeColor="Red"></asp:Label></P>
		</form>
	</body>
</HTML>
