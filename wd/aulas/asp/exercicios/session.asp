,L6<%@ LANGUAGE=javascript %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Exemplo Sessions</title>
</head>

<body>
<p>Vou criar uma session como nome "nome" e "password", com os valores respectivamente de "Miguel Serodio" e "xico".</p>
<% 
	Session.TimeOut = 10; //Atribuir uma duracao a session
	Session("nome") = "Miguel Serodio";
	Session("password") = "xico";
%>

<ul>Os valores que estão na session:
	<li>Nome:</li><% Response.Write(Session("nome")); %>
	<li>Password</li> <% Response.Write(Session("password")); %>
</ul>
<!-- Limpar as sessions -->

<%
	//Eliminar o valor de uma session
	Session.Contents.Remove("nome");
	Response.Write("Nome:" + Session("nome") + "<BR>");
	Response.Write("password:" + Session("password"));
	//Eliminar todas as variaveis numa session
	Session.Contents.RemoveAll();
	Response.Write("<br>");
	Response.Write("Nome:" + Session("nome") + "<BR>");
	Response.Write("password:" + Session("password"));
	
%>
<!-- Vamos exemplificar a utilizacao de includes -->
<p><!--#include file="autor.inc"--></p>
<p>Codigo:</p>
<pre>&lt;% <br>	Session.TimeOut = 10; //Atribuir uma duracao a session<br>	Session(&quot;nome&quot;) = &quot;Miguel Serodio&quot;;<br>	Session(&quot;password&quot;) = &quot;xico&quot;;<br>%&gt;
<p>&lt;ul&gt;Os valores que est&atilde;o na session:<br>
  &lt;li&gt;Nome:&lt;/li&gt;&lt;% Response.Write(Session(&quot;nome&quot;)); %&gt;<br>
  &lt;li&gt;Password&lt;/li&gt; &lt;% Response.Write(Session(&quot;password&quot;)); 
  %&gt;<br>
  &lt;/ul&gt;<br>
  &lt;!-- Limpar as sessions --&gt;</p>
<p>&lt;%<br>
  //Eliminar o valor de uma session<br>
  Session.Contents.Remove(&quot;nome&quot;);<br>
  Response.Write(&quot;Nome:&quot; + Session(&quot;nome&quot;) + &quot;&lt;BR&gt;&quot;);<br>
  Response.Write(&quot;password:&quot; + Session(&quot;password&quot;));<br>
  //Eliminar todas as variaveis numa session<br>
  Session.Contents.RemoveAll();<br>
  Response.Write(&quot;&lt;br&gt;&quot;);<br>
  Response.Write(&quot;Nome:&quot; + Session(&quot;nome&quot;) + &quot;&lt;BR&gt;&quot;);<br>
  Response.Write(&quot;password:&quot; + Session(&quot;password&quot;));<br>
  <br>
  %&gt;<br>
  &lt;!-- Vamos exemplificar a utilizacao de includes --&gt;<br>
  &lt;p&gt;&lt;!--#include file=&quot;autor.inc&quot;--&gt;&lt;/p&gt;<br>
</p>

</pre>
</body>
</html>
