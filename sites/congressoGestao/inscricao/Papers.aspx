<%@ Page language="c#" Codebehind="Papers.aspx.cs" AutoEventWireup="false" Inherits="congressoGestao.Papers" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Papers</title>
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../texto.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<h1 align="center">Comunicações Admitidas</h1>
		<P align="center">&nbsp;</P>
		<P align="center"><asp:datagrid id=masterDataGrid runat="server" DataSource="<%# objdsPapers %>" CellPadding="4" DataMember="tabInscritosPaper" Width="476px" Height="120px" AutoGenerateColumns="False" PageSize="5" DataKeyField="tabInscritosPaper_id" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" BackColor="White" GridLines="Horizontal">
				<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
				<ItemStyle ForeColor="#333333" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Names="Verdana" Font-Bold="True" Height="10px" ForeColor="White" BackColor="#336666"></HeaderStyle>
				<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
				<Columns>
					<asp:BoundColumn DataField="tabInscritosPaper_Autor" HeaderText="Autor"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosPaper_Instituicao" HeaderText="Institui&#231;&#227;o"></asp:BoundColumn>
					<asp:BoundColumn DataField="tabInscritosPaper_Resumo" HeaderText="Resumo"></asp:BoundColumn>
				</Columns>
				<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
			</asp:datagrid></P>
		<p align="center"><A href="javascript:window.close()">Fechar</A></p>
	</body>
</HTML>
