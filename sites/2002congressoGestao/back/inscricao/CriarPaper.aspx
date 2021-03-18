<%@ Page language="c#" Codebehind="CriarPaper.aspx.cs" AutoEventWireup="false" Inherits="congressoGestao.CriarPaper" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>CriarPaper</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<h1 align="center">Criar Paper</h1>
		<form id="CriarPaper" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 101; LEFT: 259px; POSITION: absolute; TOP: 63px" runat="server" Width="62px" Height="29px">Autor</asp:Label>
			<asp:TextBox id="txtPaper" style="Z-INDEX: 106; LEFT: 353px; POSITION: absolute; TOP: 154px" runat="server" Width="270px" Height="179px" TextMode="MultiLine"></asp:TextBox>
			<asp:TextBox id="txtInstituicao" style="Z-INDEX: 105; LEFT: 354px; POSITION: absolute; TOP: 106px" runat="server" Width="283px" Height="32px"></asp:TextBox>
			<asp:Label id="Label3" style="Z-INDEX: 103; LEFT: 259px; POSITION: absolute; TOP: 154px" runat="server" Width="62px" Height="29px"> Resumo</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 102; LEFT: 260px; POSITION: absolute; TOP: 106px" runat="server" Width="62px" Height="29px">Instituicao</asp:Label>&nbsp;
			<asp:TextBox id="txtAutor" style="Z-INDEX: 104; LEFT: 353px; POSITION: absolute; TOP: 63px" runat="server" Width="283px" Height="32px"></asp:TextBox>
			<asp:Button id="Button1" style="Z-INDEX: 107; LEFT: 367px; POSITION: absolute; TOP: 352px" runat="server" Width="129px" Height="31px" Text="Enviar"></asp:Button>
		</form>
	</body>
</HTML>
