<%@ Page language="c#" Inherits="CongressoPsicologia.WebForm1" CodeFile="Inscricao.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Congresso de Psicologia</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 184px; POSITION: absolute; TOP: 88px" runat="server"
				Width="296px" Height="24px" Font-Bold="True" Font-Italic="True">Pré-Inscrição no Congresso de Psicologia</asp:Label>
			<asp:TextBox id="txtContribuinte" style="Z-INDEX: 116; LEFT: 240px; POSITION: absolute; TOP: 352px"
				tabIndex="8" runat="server" Width="184px"></asp:TextBox>
			<asp:TextBox id="txtEmail" style="Z-INDEX: 114; LEFT: 240px; POSITION: absolute; TOP: 288px"
				tabIndex="6" runat="server" Width="183px"></asp:TextBox>
			<asp:TextBox id="txtCodPostal" style="Z-INDEX: 113; LEFT: 240px; POSITION: absolute; TOP: 256px"
				tabIndex="5" runat="server" Width="183px"></asp:TextBox>
			<asp:TextBox id="txtLocalidade" style="Z-INDEX: 112; LEFT: 240px; POSITION: absolute; TOP: 232px"
				tabIndex="4" runat="server" Width="185px"></asp:TextBox>
			<asp:TextBox id="txtMorada" style="Z-INDEX: 111; LEFT: 240px; POSITION: absolute; TOP: 192px"
				tabIndex="3" runat="server" Width="230px"></asp:TextBox>
			<asp:TextBox id="txtNome" style="Z-INDEX: 110; LEFT: 240px; POSITION: absolute; TOP: 168px" tabIndex="2"
				runat="server" Width="232px"></asp:TextBox>
			<asp:Label id="Label8" style="Z-INDEX: 108; LEFT: 136px; POSITION: absolute; TOP: 328px" runat="server"
				Height="21px" Width="70px">Telefone:</asp:Label>
			<asp:Label id="Label7" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 296px" runat="server"
				Height="21px" Width="69px">e-Mail:</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 264px" runat="server"
				Height="21px" Width="102px">Código Postal:</asp:Label>
			<asp:Label id="Label5" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 232px" runat="server"
				Height="21px" Width="73px">Localidade:</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 200px" runat="server"
				Height="21px" Width="73px">Morada:</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 168px" runat="server"
				Height="21px" Width="73px">Nome:</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 128px; POSITION: absolute; TOP: 136px" runat="server"
				Height="21px" Width="73px">Instituição:</asp:Label>
			<asp:TextBox id="txtInstituicao" style="Z-INDEX: 109; LEFT: 240px; POSITION: absolute; TOP: 136px"
				runat="server" Width="231px" tabIndex="1"></asp:TextBox>
			<asp:RadioButtonList id="rbComunicacao" style="Z-INDEX: 117; LEFT: 240px; POSITION: absolute; TOP: 384px"
				tabIndex="9" runat="server" Height="30px" Width="205px">
				<asp:ListItem Value="0" Selected="True">At&#233; 3 de Junho - 30€</asp:ListItem>
				<asp:ListItem Value="1">At&#233; 17 de Junho - 40€</asp:ListItem>
				<asp:ListItem Value="2">Depois de 17 de Junho - 50€</asp:ListItem>
			</asp:RadioButtonList>
			<asp:Label id="Label9" style="Z-INDEX: 118; LEFT: 136px; POSITION: absolute; TOP: 480px" runat="server"
				Height="32px" Width="558px" Font-Size="Smaller">A inscrição só é válida após o pagamento emitido por cheque à 
				ordem da Escola Superior de Desporto de Rio Maior e enviado para a seguinte morada: <br>
				Escola Superior de Desporto de Rio Maior<br>
				Secretariado do Congresso de Psicologia do Desporto<br>
				(A/C <a href="mailto:stela@esdrm.pt">Stella Van Zeller</a>)<br>
				Rua Jos&eacute; Pedro In&ecirc;s Canadas - Lote 1 R/C<bR>
				2040 - 326 Rio Maior <br>
				Portugal
				<br>
				Só se aceitam as inscrições como estudante mediante a apresentação de comprovativo.			
				</asp:Label>
			<asp:Button id="btnEnviar" style="Z-INDEX: 119; LEFT: 712px; POSITION: absolute; TOP: 528px"
				runat="server" Height="30px" Width="95px" Text="Enviar" tabIndex="11" onclick="btnEnviar_Click"></asp:Button>
			<P align="center">
				<asp:HyperLink id="HyperLink1" style="Z-INDEX: 120; LEFT: 400px; POSITION: absolute; TOP: 640px"
					runat="server" NavigateUrl="index.htm">Voltar</asp:HyperLink><IMG style="Z-INDEX: 131; LEFT: 0px; POSITION: absolute; TOP: 0px" src="images/Psicologia_r1_c1.jpg"
					width="760" height="86">
				<asp:RequiredFieldValidator id="RequiredFieldValidator2" style="Z-INDEX: 128; LEFT: 496px; POSITION: absolute; TOP: 328px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtTelefone"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator8" style="Z-INDEX: 127; LEFT: 496px; POSITION: absolute; TOP: 296px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator7" style="Z-INDEX: 126; LEFT: 496px; POSITION: absolute; TOP: 264px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtCodPostal"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator5" style="Z-INDEX: 125; LEFT: 496px; POSITION: absolute; TOP: 232px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtLocalidade"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator4" style="Z-INDEX: 124; LEFT: 496px; POSITION: absolute; TOP: 200px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtMorada"></asp:RequiredFieldValidator>
				<asp:RequiredFieldValidator id="RequiredFieldValidator3" style="Z-INDEX: 123; LEFT: 496px; POSITION: absolute; TOP: 168px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtNome"></asp:RequiredFieldValidator>
				<asp:Panel id="PnlObrigado" style="Z-INDEX: 121; LEFT: 480px; POSITION: absolute; TOP: 416px"
					runat="server" Height="8px" Width="212px" Visible="False">
					<P>
						<asp:Label id="lblMsg" runat="server" Font-Bold="True" Width="184px" ForeColor="Red"></asp:Label></P>
				</asp:Panel>
				<asp:RequiredFieldValidator id="RequiredFieldValidator1" style="Z-INDEX: 122; LEFT: 496px; POSITION: absolute; TOP: 136px"
					runat="server" ErrorMessage="* Preencha o campo" ControlToValidate="txtInstituicao"></asp:RequiredFieldValidator><A href="javascript:window.history.back()"></A>
			<P>
				<asp:Label id="Label10" style="Z-INDEX: 129; LEFT: 136px; POSITION: absolute; TOP: 360px" runat="server"
					Height="21px" Width="70px">Contribuinte:</asp:Label>
				<asp:TextBox id="txtTelefone" style="Z-INDEX: 115; LEFT: 240px; POSITION: absolute; TOP: 320px"
					tabIndex="7" runat="server" Width="184px"></asp:TextBox>
				<asp:CheckBox id="CheckBoxEstudante" style="Z-INDEX: 130; LEFT: 472px; POSITION: absolute; TOP: 384px"
					runat="server" Text="Estudante (50% desconto)" tabIndex="10"></asp:CheckBox>
			</P>
		</form>
	</body>
</HTML>
