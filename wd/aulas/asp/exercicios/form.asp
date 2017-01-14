<%@ LANGUAGE=javascript %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
	<title>Untitled</title>
</head>

<body>
<p>Nome:<%= Request.QueryString("nome")%></p>
<p>Morada:<%= Request.QueryString("morada") %></p>
<p>Email:<%= Request.QueryString("email") %></p>
<p>Codigo:</p>
<pre>&lt;p&gt;Nome:&lt;%= Request.QueryString(&quot;nome&quot;)%&gt;&lt;/p&gt;<br>&lt;p&gt;Morada:&lt;%= Request.QueryString(&quot;morada&quot;) %&gt;&lt;/p&gt;<br>&lt;p&gt;Email:&lt;%= Request.QueryString(&quot;email&quot;) %&gt;&lt;/p&gt;


</pre>
</p>
</body>
</html>
