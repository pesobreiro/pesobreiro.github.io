<%@ Page language="c#" Codebehind="Inscritos.aspx.cs" AutoEventWireup="false" Inherits="congressoGestao.Inscritos" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Inscritos</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<h1 align="center">Inscritos</h1>
		<form id="Inscritos" method="post" runat="server">
			<Div ID="queryDiv">&nbsp;</Div>
			<BR>
			<asp:DataGrid runat="server" DataKeyField="tabInscritosConferencia_id" PageSize="5" AutoGenerateColumns="False" Height="50px" Width="100%" DataMember="tabInscritosConferencia" ID="masterDataGrid" CellPadding="4" DataSource='<%# objdsInscritos %>' BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" BackColor="White" GridLines="Horizontal">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
				<ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Names="Verdana" Font-Bold="True" Height="10px" ForeColor="White" BackColor="#336666"></HeaderStyle>
				<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="tabInscritosConferencia_Instituicao" HeaderText="Instituicao"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_Nome" HeaderText="Nome"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_Morada" HeaderText="Morada"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_Localidade" HeaderText="Localidade"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_CodPostal" HeaderText="CodPostal"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_eMail" HeaderText="eMail"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_telefone" HeaderText="telefone"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosConferencia_participante" HeaderText="participante"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
