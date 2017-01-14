<%@ LANGUAGE=javascript%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Introdução ás ASP´s</title>
</head>

<body>
<p>
  <% Response.Write("Olá Asp´s...") %>
  <BR>
  <% 
    for (i=1;i<10;i++)
    {
	 Response.Write(i)
	} 
	Response.Write("<BR>");
	if (Session("acesso") == 'sim') {
		Response.Write("Está na àrea privada");
	}
	else
	{
		Response.Write("Não tem acesso à área privada");
	}		
%>
</p>
<p>Codigo:</p>
<p> &lt;% Response.Write(&quot;Ol&aacute; Asp&acute;s...&quot;) %&gt;<br>
  &lt;BR&gt;<br>
  &lt;% <br>
  for (i=1;i&lt;10;i++)<br>
  {<br>
  Response.Write(i)<br>
  } <br>
  Response.Write(&quot;&lt;BR&gt;&quot;);<br>
  if (Session(&quot;acesso&quot;) == 'sim') {<br>
  Response.Write(&quot;Est&aacute; na &agrave;rea privada&quot;);<br>
  }<br>
  else<br>
  {<br>
  Response.Write(&quot;N&atilde;o tem acesso &agrave; &aacute;rea privada&quot;);<br>
  } <br>
  %&gt;<br>
</p>
</body>
</html>