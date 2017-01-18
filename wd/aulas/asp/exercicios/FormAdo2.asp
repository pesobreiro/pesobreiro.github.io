<%@ LANGUAGE="javascript" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Exemplo ADO</title>
</head>

<body>

<form action="FormAdo2.asp" method="post">
	Descrição Produto: <input type="Text" name="produto" size="60"><br>
	Qt Produto: <input type="Text" name="qt">
	<input type="Submit" value="enviar" name="enviar" >
	<input type="Reset">
</form>
<% 
	Response.Write(Request.Form("produto"));
	Response.Write(Request.Form("qt"));
	//Vou estabelecer a minha ligacao com a base de dados
	conn=Server.CreateObject("ADODB.Connection");
	//Vou activar a ligacao
	conn.Open("wd");
	if (Request.Form("enviar") == "enviar")
	{
		//Definicao do RecordSet
		//Vou inserir os dados do form
		
		qt = parseInt(Request.Form("qt"),10);
		strSQLInsert = "insert into artigo(Artigo_Descricao, Artigo_Qt) "+ 
							   "values('"+Request.Form("produto") +
							   "'," + qt + ")"	;
		rsArtigoInsert = conn.Execute(strSQLInsert);
		Response.Write(strSQLInsert);
	
		//rsArtigoInsert.Close();
		conn.Close();
		//Request.Form("enviar") = "";
	}	
%>
<p>Codigo:
	
<pre>

		Response.Write(Request.Form(&quot;produto&quot;));<br>	Response.Write(Request.Form(&quot;qt&quot;));<br>	//Vou estabelecer a minha ligacao com a base de dados<br>	conn=Server.CreateObject(&quot;ADODB.Connection&quot;);<br>	//Vou activar a ligacao<br>	conn.Open(&quot;wd&quot;);<br>	if (Request.Form(&quot;enviar&quot;) == &quot;enviar&quot;)<br>	{<br>		//Definicao do RecordSet<br>		//Vou inserir os dados do form<br>		<br>		qt = parseInt(Request.Form(&quot;qt&quot;),10);<br>		strSQLInsert = &quot;insert into artigo(Artigo_Descricao, Artigo_Qt) &quot;+ <br>							   &quot;values('&quot;+Request.Form(&quot;produto&quot;) +<br>							   &quot;',&quot; + qt + &quot;)&quot;	;<br>		rsArtigoInsert = conn.Execute(strSQLInsert);<br>		Response.Write(strSQLInsert);<br>	<br>		//rsArtigoInsert.Close();<br>		conn.Close();<br>		//Request.Form(&quot;enviar&quot;) = &quot;&quot;;<br>	}<br></pre></p> 
</body>
</html>
