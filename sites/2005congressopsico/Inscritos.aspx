<%@ Page language="c#" Inherits="CongressoPsicologia.Inscritos" CodeFile="Inscritos.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Inscritos</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body topmargin="0" leftmargin="0">
		<asp:Label id="Label1" runat="server" Height="16px" Width="432px" Font-Bold="True">Inscritos</asp:Label>
		<form id="Form1" method="post" runat="server">
			<asp:DataGrid id="DataGridLista" runat="server" Width="100%" Height="100%" BorderColor="#CC9966"
				BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4">
				<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
				<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
				<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
				<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
				<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
			</asp:DataGrid>
		</form>
	</body>
</HTML>
