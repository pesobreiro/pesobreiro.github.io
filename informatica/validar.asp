<%@ language = JavaScript %>
<html>
<head>
	<title>Escola Superior de Desporto de Rio Maior</title>
<style type="text/css">
<!--
	a { font-family: Verdana, Arial, Helvetica }
	a { font-size: 9pt }
	a { font-weight: bold }
	a { text-decoration: underline }
	a:hover { color: #ff0000; text-decoration: underline }
	a:active { color: #000000 }
	a:visited { color: none }
	a:link { color: #000000 }
	
	i {  color: #990000}
	.cor1 {  color: #CC0000}
-->
</style>
	
</head>
<BODY bgColor="#f7efde" link="#000000" vlink="#000000" alink="#000000">
<center>
	<h2>Trabalho de Informática</h2>
</center>

<%
	var order_num;
	var order_seq_num;
	var errStr = "";

	//Cria uma conexao a base de dados
	conn = Server.CreateObject("ADODB.Connection");
	conn.Open("dsn=AulasInformatica;uid='';pwd=''");
		
	if (Request('numero1') == "")
		errStr = errStr + "Falta o Numero 1<br>";
	if (Request('nome1') == "")
		errStr = errStr + "Falta a nome 1<br>";
	if (Request('numero2') == "")
		errStr = errStr + "Falta a numero 2<br>";
	if (Request('nome2') == "")
		errStr = errStr + "Falta o nome 2<br>";
	if (Request('turma') == "")
		errStr = errStr + "Falta a turma<br>";
	if (Request('trabalho') == "")
		errStr = errStr + "Falta o tema do trabalho<br>";

	if (errStr != "") 
	{ 
			Response.Write("<center>");
			Response.Write("<strong>Foram encontrados os seguintes erros:</strong><br>");
			Response.Write(errStr);
			Response.Write("</center>");
	}
	else 
	{

			Response.Write("<center><h4>Obrigado!<h4></center>");
			//Vamos actualizar a tabela com os dados
			
		   //Cria a inscricao
		   
			{
				SqlAddInscricao = "insert into alunos ( Numero1, Nome1, Numero2, nome2, turma, trabalho ) " +
				" values ('" + Request('numero1') + "', '" + Request('nome1') + "', '" + Request('numero2') + "', '" + 
				Request('nome2') + "', '"  + Request('turma') + "', '" + Request('trabalho')+ "');";

				Response.Write("<center><h4>" + SqlAddInscricao +"<h4></center>");

				AdicionaInscricao = conn.Execute(SqlAddInscricao);
			}
			Response.Write("</table>\n");
			conn.Close()
	}

%>	

<p>
<p>
<center>
<A href="informatica.html">Início</A>
</center>
</body>
</html>
