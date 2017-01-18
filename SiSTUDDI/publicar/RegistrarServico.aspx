<%@ Page language="c#" Codebehind="RegistrarServico.aspx.cs" AutoEventWireup="false" Inherits="SiSTUddi.publicar.RegistrarServico" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
  <HEAD>
		<title>SiSTUDDI</title>
		<meta content="False" name="vs_showGrid">
		<meta content="Microsoft Visual Studio 7.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
  </HEAD>
	<body>
		<!--#include file="../include/topoPublicar.inc"--><TR>
			<TD>
		<TR>
			<TD><asp:panel id="pnlConteudo" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
<FORM id=login method=post runat="server">
<P>
<TABLE id=conteudo cellSpacing=0 cellPadding=0 width="100%" border=0>
  <TR>
    <TD width="22%">&nbsp;</TD>
    <TD width="2%">&nbsp;</TD>
    <TD width="76%" bgColor=#b0c4de><B><FONT 
      face="Arial, Helvetica, sans-serif" color=#ffffff>Registo de 
      Serviço</FONT></B></TD></TR>
  <TR>
    <TD style="HEIGHT: 20px" width="22%" bgColor=#b0c4de><B><FONT 
      face="Arial, Helvetica, sans-serif" color=#ffffff>SiSTUDDI</FONT></B></TD>
    <TD style="HEIGHT: 20px">&nbsp;</TD>
    <TD style="HEIGHT: 20px">&nbsp;</TD></TR>
  <TR>
    <TD bgColor=#ffffff>&nbsp;</TD>
    <TD>&nbsp;</TD>
    <TD>&nbsp;</TD></TR>
  <TR>
    <TD vAlign=top bgColor=#ffffff>
      <TABLE cellSpacing=0 cellPadding=0 width=212 bgColor=#e2e2e2 border=0>
        <TR>
          <TD width=28><IMG height=33 src="../imagens/esqcima.gif" 
width=28></TD>
          <TD width=156>
            <P class=texto align=center>Registrar:</P></TD>
          <TD width=28><IMG height=33 src="../imagens/dircima.gif" 
        width=28></TD></TR>
        <TR>
          <TD></TD>
          <TD>
            <DIV align=center><A class=link href="index.aspx">Registos 
            realizados</A></DIV></TD>
          <TD></TD></TR>
        <TR>
          <TD>&nbsp;</TD>
          <TD>
            <DIV align=center>
            <DIV align=center><A class=link 
            href="RegistrarEmpresa.aspx">Empresa</A></DIV></DIV></TD>
          <TD>&nbsp;</TD></TR>
        <TR>
          <TD>&nbsp;</TD>
          <TD>
            <DIV align=center>
            <DIV align=center><A class=link 
            href="RegistrarServico.aspx">Serviços/Produtos</A>&nbsp;</DIV></DIV></TD>
          <TD>&nbsp;</TD></TR>
        <TR>
          <TD></TD>
          <TD>
            <DIV align=center>
            <DIV align=center>
            <DIV align=center><A class=link 
            href="RegistrarServicoWeb.aspx">Serviços 
Web</A></DIV></DIV></DIV></TD>
          <TD></TD></TR>
        <TR>
          <TD width=28><IMG height=25 src="../imagens/esqbaixo.gif" 
          width=28></TD>
          <TD>
            <DIV align=center></DIV></TD>
          <TD width=28><IMG height=25 src="../imagens/dirbaixo.gif" 
          width=28></TD></TR></TABLE>
      <P class=TextoTabela>Seleccione o que pretende registrar. </P></TD>
    <TD>&nbsp;</TD>
    <TD>
<asp:panel id=pnlPublicarTaxonomias HorizontalAlign="Center" Width="100%" runat="server">
      <TABLE id=Table2 cellSpacing=0 cellPadding=1 width="100%" align=center 
      border=0>
        <TR>
          <TD class=TextoTabela>Para adicionar um serviço seleccione uma 
            empresa registradas e adicione o serviço. </TD></TR>
        <TR>
          <TD>
            <DIV align=center><STRONG>Empresas Registradas</STRONG> 
            <TABLE id=tblEmpresa cellSpacing=1 cellPadding=1 width="100%" 
            border=0>
              <TR>
                <TD style="WIDTH: 134px">Empresa</TD>
                <TD>
<asp:dropdownlist id=cmbEmpresas Width="190px" runat="server"></asp:dropdownlist>
<asp:button id=btnVerServicos Width="150px" runat="server" Text="Seleccionar"></asp:button></TD></TR>
              <TR>
                <TD style="WIDTH: 134px; HEIGHT: 15px"></TD>
                <TD style="HEIGHT: 15px">
<asp:dropdownlist id=cmbTemp Width="190px" runat="server"></asp:dropdownlist></TD></TR>
              <TR>
                <TD style="WIDTH: 134px">
                  <P align=center>
<asp:button id=btnPublicarServicos Visible="False" Width="150px" runat="server" Text="Adicionar Serviço"></asp:button></P></TD>
                <TD>
                  <P>
<asp:button id=btnEliminarServicos Visible="False" Width="150px" runat="server" Text="Eliminar Serviço"></asp:button></P></TD></TR>
              <TR>
                <TD style="WIDTH: 134px" colSpan=2>
                  <P align=center>&nbsp;</P></TD>
                <TD></TD></TR></TABLE>
<asp:panel id=pnlRegistrarServico Visible="False" runat="server">
            <TABLE id=tblRegistrarServico cellSpacing=1 cellPadding=1 
            width="100%" border=0>
              <TR>
                <TD style="WIDTH: 134px" colSpan=2><STRONG>Registrar 
                  Serviço/Produto</STRONG></TD></TR>
              <TR>
                <TD style="WIDTH: 134px">Empresa</TD>
                <TD></TD></TR>
              <TR>
                <TD style="WIDTH: 134px">Actividade:</TD>
                <TD>
<asp:dropdownlist id=cmbFamilia Width="190px" runat="server"></asp:dropdownlist>
<asp:button id=btnFamilia Width="150px" runat="server" Text="Ver Categorias"></asp:button></TD></TR>
              <TR>
                <TD style="WIDTH: 134px"></TD>
                <TD>
<asp:dropdownlist id=cmbClasse Width="190px" runat="server" Enabled="False"></asp:dropdownlist>
<asp:button id=btnClasse Width="150px" runat="server" Text="Ver SubCategoria" Enabled="False"></asp:button></TD></TR>
              <TR>
                <TD style="WIDTH: 134px"></TD>
                <TD>
<asp:dropdownlist id=cmbElemento Width="190px" runat="server" Enabled="False"></asp:dropdownlist></TD></TR>
              <TR>
                <TD style="WIDTH: 134px"></TD>
                <TD>
<asp:label id=lblCodigo Visible="False" Width="150px" runat="server"></asp:label>
<asp:label id=lblDescricao Visible="False" Width="330px" runat="server"></asp:label></TD></TR></TABLE>
<asp:button id=btnRegistrarServico runat="server" Text="Registrar" Enabled="False"></asp:button></asp:panel></DIV></TD></TR></TABLE></asp:panel></TD></TR>
  <TR>
    <TD vAlign=top bgColor=#ffffff></TD>
    <TD></TD>
    <TD>
<asp:Panel id=pnlEliminarTaxonomias Width="100%" runat="server">
<asp:DataGrid id=DataGridEliminarTaxonomias Width="100%" runat="server" OnItemCreated="ScriptDelete" GridLines="Horizontal" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#E7E7FF">
												<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
												<EditItemStyle Font-Size="Smaller"></EditItemStyle>
												<AlternatingItemStyle Font-Size="Smaller" BackColor="#F7F7F7"></AlternatingItemStyle>
												<ItemStyle Font-Size="Smaller" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
												<HeaderStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
												<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
												<Columns>
													<asp:ButtonColumn Text="Eliminar" CommandName="Delete"></asp:ButtonColumn>
												</Columns>
												<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
											</asp:DataGrid></asp:Panel></TD></TR></TABLE>
<P></P></FORM>
				</asp:panel><asp:panel id="pnlLoginSemSucesso" runat="server" Width="100%" HorizontalAlign="Center" Visible="False">
<TABLE id=Table5 style="WIDTH: 750px; HEIGHT: 81px" borderColor=#000099 
cellSpacing=0 cellPadding=30 width=750 align=center border=1>
  <TR>
    <TD>
      <P align=justify><FONT size=2>Não tem permissões de acesso. Faça o Login 
      <A class=link 
      href="../Administrar/login.aspx?origem=publicar">aqui</A>.</FONT></P></FONT></TD></TR></TABLE>
				</asp:panel><asp:panel id="pnlErro" runat="server" Width="100%" HorizontalAlign="Center" Visible="False" Height="105px">
<asp:Label id=lblErro Width="742px" runat="server" Height="96px" CssClass="Erro"></asp:Label>
				</asp:panel>
		<!--#include file="../include/menuBaixo.inc"-->
	</body>
</HTML>
