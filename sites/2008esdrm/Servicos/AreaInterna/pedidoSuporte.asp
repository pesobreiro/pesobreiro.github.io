<%@ language = JavaScript %> 
<html>

<head>
<title>Inscrição</title>
<link href="../CSS/css.css" rel="stylesheet" type="text/css">
<script language="JavaScript" type="text/JavaScript">
<!--
function MM_callJS(jsStr) { //v2.0
  return eval(jsStr)
}

function MM_goToURL() { //v3.0
  var i, args=MM_goToURL.arguments; document.MM_returnValue = false;
  for (i=0; i<(args.length-1); i+=2) eval(args[i]+".location='"+args[i+1]+"'");
}
//-->
</script>
</head>

<body background="../Fundos/exptextb.jpg" text="#000000" link="#993300" vlink="#666600" alink="#CC3300"><font face="Book Antiqua, Times New Roman, Times"> 
<p>
  <%
	//Fazer a conexao a base de dados
	conn = Server.CreateObject("ADODB.Connection");
	conn.Open("dsn=Esdrm;uid=SiteEsdrm;pwd=SiteEsdrm;");
%>
</p>
<p align="center"><strong><font size="5">Envio de Pedido de Assist&ecirc;ncia</font></strong></p>
<center>
  <form name="form1" method="get" action="../Informatica/CentroInformatica/pedidoSuporte.asp">
    <table width="79%" border="0">
      <tr> 
        <td width="13%"><font face="Book Antiqua, Times New Roman, Times"><b>Utilizador</b> 
          </font></td>
        <td width="87%"><font face="Book Antiqua, Times New Roman, Times"> 
          <% SqlUtilizadores = "select nomeUser from tabutilizadores order by nomeUser";
			   rstUtilizadores = conn.Execute(SqlUtilizadores);
			%>
          <select name="txtUtilizador" size="1">
            <% 
				while (!rstUtilizadores.EOF)
				{
					Response.Write("<option>");
					Response.Write(rstUtilizadores('nomeUser'));
					Response.Write("</option>");
					rstUtilizadores.MoveNext();
				}
					rstUtilizadores.Close()
			%>
          </select>
          </font></td>
      </tr>
      <tr> 
        <td width="13%"><font face="Book Antiqua, Times New Roman, Times"><b>Problema</b> 
          </font></td>
        <td width="87%"><font face="Book Antiqua, Times New Roman, Times"> 
          <textarea name="txtProblema" rows="4" cols="80"></textarea>
          </font></td>
      </tr>
      <tr> 
        <td colspan="2"><font face="Book Antiqua, Times New Roman, Times">&nbsp; </font> 
          <div align="center"><font face="Book Antiqua, Times New Roman, Times"> 
            <input name="cmdEnviar" type="submit" class="botao_actualizar" value="Gravar e Enviar">
            &nbsp;&nbsp; 
            <input name="Reset" type="reset" class="botao_actualizar" value="    Cancelar    ">
            </font></div></td>
      </tr>
    </table>
    <font face="Book Antiqua, Times New Roman, Times">
    </form>
<% 
	if (Request.QueryString('cmdEnviar') == 'Gravar e Enviar')
	{
		Response.Write ("<h3>O Pedido foi Enviado</h3>")
		Response.Write ('Utilizador ' + Request.QueryString('txtUtilizador') + '<br>') 
		Response.Write (Request.QueryString('txtProblema')) 
		
		SqlUtilizadores = "select * from tabutilizadores where nomeuser ='" +
						  Request.QueryString('txtUtilizador') + "'";
	    rstUtilizadores = conn.Execute(SqlUtilizadores);

		SqlAddPedido = "insert into tabInter ( tabInter_Tipo, TabInter_Descricao, TabInter_Utilizador)" +  
					   " values ('PAT', '" + Request.QueryString('txtProblema') + "', '" + 
					   rstUtilizadores('numero') + "')";
		AdicionaInscricao = conn.Execute(SqlAddPedido);
		
		
	}	
	conn.Close()
%>
  <p align="center"> 
    <input name="Button" type="button" class="botao_actualizar" onClick="MM_callJS('JavaScript:top.history.back()')" value="P&aacute;gina Anterior">
    &nbsp;&nbsp;
    <input name="Button" type="button" class="botao_actualizar" onClick="MM_goToURL('parent','listaPedidoSuporte.asp');return document.MM_returnValue" value="Listar Pedidos de Interven&ccedil;&atilde;o">
  </p>
  <p align="center">&nbsp;</p>
</center>

</body>

</html>
