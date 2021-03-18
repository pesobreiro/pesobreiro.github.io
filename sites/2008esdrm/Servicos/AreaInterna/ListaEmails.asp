<%@LANGUAGE="JAVASCRIPT"%> 
<!--#include file="../Connections/Esdrm.asp" -->
<%
var rstEmail = Server.CreateObject("ADODB.Recordset");
rstEmail.ActiveConnection = MM_Esdrm_STRING;
rstEmail.Source = "SELECT nomeUser, email FROM dbo.TabUtilizadores ORDER BY nomeUser ASC";
rstEmail.CursorType = 0;
rstEmail.CursorLocation = 2;
rstEmail.LockType = 1;
rstEmail.Open();
var rstEmail_numRows = 0;
%>
<%
var Repeat1__numRows = -1;
var Repeat1__index = 0;
rstEmail_numRows += Repeat1__numRows;
%>
<html>

<head>
<link href="../CSS/css.css" rel="stylesheet" type="text/css">
<script language="JavaScript" type="text/JavaScript">
<!--
function MM_callJS(jsStr) { //v2.0
  return eval(jsStr)
}
//-->
</script>
</head>

<body background="../imagens/exptextb.jpg" bgcolor="#FFFFFF" text="#000000" link="#993300" vlink="#666600" alink="#CC3300"><font face="Book Antiqua, Times New Roman, Times">
<div align="center"> 
  <p> 
    <%
	//Fazer a conexao a base de dados
	conn = Server.CreateObject("ADODB.Connection");
	conn.Open("dsn=Esdrm;uid=SiteEsdrm;pwd=SiteEsdrm;");
	
	SQLString = "select * from tabUtilizadores order by nomeUser";
	rstUser = conn.Execute(SQLString);
	
%><center>
    <font size="4" face="Arial, Helvetica, sans-serif"><b><i>Lista dos eMails 
    de Funcion&aacute;rios e Professores da ESDRM</i></b></font> <br>
  </p>
</div>
<table width="50%" border="1" align="center" bordercolor="#999966">
  <tr bordercolor="#999933" bgcolor="#999966"> 
    <td><div align="center"><strong>Nome do Utilizador</strong></div></td>
    <td><div align="center"><strong>eMail</strong></div></td>
  </tr>
  <% while ((Repeat1__numRows-- != 0) && (!rstEmail.EOF)) { %>
  <tr bgcolor="#E4E4E4"> 
    <td><%=(rstEmail.Fields.Item("nomeUser").Value)%></td>
    <td><a href="mailto:<%=(rstEmail.Fields.Item("email").Value)%>"><%=(rstEmail.Fields.Item("email").Value)%></a></td>
  </tr>
  <%
  Repeat1__index++;
  rstEmail.MoveNext();
}
%>
  
</table>

<p align="center">
<input name="Button" type="button" class="botao_actualizar" onClick="MM_callJS('JavaScript:top.history.back()')" value="P&aacute;gina Anterior">
</p>
<!--#include file="../Autor.inc" -->
</body>

</html>
<%
rstEmail.Close();
%>
