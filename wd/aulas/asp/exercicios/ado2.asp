<%@ LANGUAGE="javascript" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Exemplo ADO</title>
</head>

<body>

<p>
  <% 
	//Vou estabelecer a minha ligacao com a base de dados
	conn=Server.CreateObject("ADODB.Connection");
	//Vou activar a ligacao
	conn.Open("wd");
	//Definicao do RecordSet
	//Vou inserir um produto
		
	strSQLInsert = "insert into artigo(Artigo_Descricao, Artigo_Qt) "+ 
						   "values('Bola de Futebol', 10)"	;
	rsArtigoInsert = conn.Execute(strSQLInsert);
	Response.Write(strSQLInsert);
	
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
	//Vou inserir um produto
		
	strSQLInsert = "insert into artigo(Artigo_Descricao, Artigo_Qt) "+ 
						   "values('Bola de Futebol', 10)"	;
	rsArtigoInsert = conn.Execute(strSQLInsert);
	Response.Write(strSQLInsert);
	
	conn.Close();
</pre>
</p>
</body>
</html>
