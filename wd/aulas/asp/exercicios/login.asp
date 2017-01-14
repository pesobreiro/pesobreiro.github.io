<%@ LANGUAGE="javascript" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Valida</title>
</head>

<body>

<% 
	//Vou estabelecer a minha ligacao com a base de dados
	conn=Server.CreateObject("ADODB.Connection");
	//Vou activar a ligacao
	conn.Open("wd");
	//Definicao do RecordSet
	//Vou inserir um produto
	
	//O select vai ser realizado com os dados do login		
	strSQLSelect = "select * from user where user_login='" + Request.Form("user") + "'"	;
	rsUser = conn.Execute(strSQLSelect);
	
	//Vamos comparar os dados do login com os dados da tabela de utilizadores
	Response.Write(strSQLSelect + "<br>"); 
	
	//Mostrar os dados que estão a ser enviados
	Response.Write(Request.Form("user") + "<br>");
	Response.Write(Request.Form("pass") + "<br>");
	
	if(!rsUser.EOF){
		Response.Write(rsUser('user_pass'));

		passBD = rsUser('user_pass') + " ";
		passForm = Request.Form("pass") + " ";
		if (passBD == passForm) {
			//Vamos criar uma session
			Session("acesso") = 'sim';
			Response.Write("Vai ter acesso");
		} else {
			Response.Write("Nome de utilizador inválido ou password incorrecta...");
			Session("acesso") = 'nao'
		}
	}
	conn.Close();
%>
<p align="center"><a href="asp2.asp">Área Privada</a></p>
<p>Codigo: 
<pre>
&lt;% <br>	//Vou estabelecer a minha ligacao com a base de dados<br>	conn=Server.CreateObject(&quot;ADODB.Connection&quot;);<br>	//Vou activar a ligacao<br>	conn.Open(&quot;wd&quot;);<br>	//Definicao do RecordSet<br>	//Vou inserir um produto<br>	<br>	//O select vai ser realizado com os dados do login		<br>	strSQLSelect = &quot;select * from user where user_login='&quot; + Request.Form(&quot;user&quot;) + &quot;'&quot;	;<br>	rsUser = conn.Execute(strSQLSelect);<br>	<br>	//Vamos comparar os dados do login com os dados da tabela de utilizadores<br>	Response.Write(strSQLSelect + &quot;&lt;br&gt;&quot;); <br>	<br>	//Mostrar os dados que est&atilde;o a ser enviados<br>	Response.Write(Request.Form(&quot;user&quot;) + &quot;&lt;br&gt;&quot;);<br>	Response.Write(Request.Form(&quot;pass&quot;) + &quot;&lt;br&gt;&quot;);<br>	<br>	if(!rsUser.EOF){<br>		Response.Write(rsUser('user_pass'));
  		passBD = rsUser('user_pass') + &quot; &quot;;<br> 	passForm = Request.Form(&quot;pass&quot;) + &quot; &quot;;<br>  	if (passBD == passForm) {<br>  	//Vamos criar uma session<br>   	Session(&quot;acesso&quot;) = 'sim';<br>		  	Response.Write(&quot;Vai ter acesso&quot;);<br>	  	} else {<br>		  	Response.Write(&quot;Nome de utilizador inv&aacute;lido ou password incorrecta...&quot;);<br>		  	Session(&quot;acesso&quot;) = 'nao'<br>	  	}<br>  }<br>  conn.Close();<br>  %&gt;
		
</pre>
</p>
</body>
</html>
