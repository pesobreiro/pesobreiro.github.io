<%@ LANGUAGE="javascript" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Exemplo ADO</title>
</head>

<body>
<% 
	//Vou estabelecer a minha ligacao com a base de dados
	conn=Server.CreateObject("ADODB.Connection");
	//Vou activar a ligacao
	conn.Open("wd");
	//Definicao do RecordSet
	strSQLSelect = "select * from artigo";
	rsArtigo = conn.Execute(strSQLSelect);
%>
<p align="center">Listagem de produtos</p>
<p>
  <% 
	while(!rsArtigo.EOF) {
		Response.Write("<p>Nome:" + rsArtigo('Artigo_Descricao') +"</p>");
		Response.Write("<p>Qt:" + rsArtigo('Artigo_Qt') + "</p>");
		rsArtigo.MoveNext();
	}
	rsArtigo.Close();
	conn.Close();
%>
</p>
<p>Codigo:
<pre>
	//Vou estabelecer a minha ligacao com a base de dados
	conn=Server.CreateObject("ADODB.Connection");
	//Vou activar a ligacao
	conn.Open("wd");
	//Definicao do RecordSet
	strSQLSelect = "select * from artigo";
	rsArtigo = conn.Execute(strSQLSelect);
	
	//Listagem de produtos

	while(!rsArtigo.EOF) {
		Response.Write("Nome:" + rsArtigo('Artigo_Descricao'));
		Response.Write("Qt:" + rsArtigo('Artigo_Qt'));
		rsArtigo.MoveNext();
	}
	rsArtigo.Close();
	conn.Close();
</pre>
</p>
</body>
</html>
