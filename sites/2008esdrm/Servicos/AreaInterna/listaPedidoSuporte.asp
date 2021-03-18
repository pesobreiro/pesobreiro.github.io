<%@ Language=JavaScript %>
<html>

<head>
<script language="JavaScript" type="text/JavaScript">
<!--
function MM_callJS(jsStr) { //v2.0
  return eval(jsStr)
}
//-->
</script>
<link href="/CSS/css.css" rel="stylesheet" type="text/css">
</head>

<body background="../Fundos/exptextb.jpg" text="#000000" link="#993300" vlink="#666600" alink="#CC3300">
<div align="center"><font face="Book Antiqua, Times New Roman, Times"> 
  <%
	//Fazer a conexao a base de dados
	conn = Server.CreateObject("ADODB.Connection");
	conn.Open("dsn=Esdrm;uid=SiteEsdrm;pwd=SiteEsdrm;");
	
	SQLString = "select * from tabInter";
	rstUser = conn.Execute(SQLString);
	
%>
  <font size="4"><b><i>Lista de Pedidos de Assist&ecirc;ncia</i></b></font> <br>
  </font> </div>
<table border="1" align="center" cellpadding="5" colspan="8">
  <tr>
    <td align="middle" bgcolor="#000080"> <font face="Book Antiqua, Times New Roman, Times"><font style="ARIAL: " color="#ffffff" size="2">Utilizador</font></font></td>
    <td align="middle" bgcolor="#000080"><font face="Book Antiqua, Times New Roman, Times"><font style="ARIAL: " color="#ffffff" size="2">Descrição</font> 
      </font></td>
    <%
	while (!rstUser.EOF)
	{
	
		Response.Write("</tr>");//Termina o cabecalho
		Response.Write("<tr>");
		Response.Write("<td>");
			Response.Write("<i>" + rstUser('TabInter_Utilizador')+ "</i>");
		Response.Write("</td>");
		Response.Write("<td>");
			Response.Write("<i>" + rstUser('TabInter_eMail')+ "</i>");
		Response.Write("</td>");
	
		rstUser.MoveNext();
	}
	rstUser.Close();
	conn.Close()
    %>
  </tr>

</table>
<font face="Book Antiqua, Times New Roman, Times"> 
<center>
  <a href="JavaScript:top.history.back()"><br>
  <br>
  <input name="Button" type="button" class="botao_actualizar" onClick="MM_callJS('top.history.back()')" value="P&aacute;gina Anterior">
  </a> 
</center>	
</font> 
</body>

</html>
