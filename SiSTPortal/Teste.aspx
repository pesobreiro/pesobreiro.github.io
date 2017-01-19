<%@ Page language="vbscript" ContentType="image/jpeg" %>
<%@ Import namespace="System.Drawing" %>
<%@ Import namespace="System.Drawing.Imaging" %>
<%@ Import namespace="System.Drawing.Text" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Teste</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<Script Runat="Server">
			Dim objectoBitmap As Bitmap
			Dim objectoGraficos As Graphics
			Dim strTexto As String
			objectoBitmap = New Bitmap( 600, 100 )

			objectoGraficos = Graphics.FromImage( objectoBitmap )
			objectoGraficos.Clear( Color.DarkBlue )

			Dim objectoFonte As New Font( "Verdana", 20 )

			strTexto = "Este é o Título com AntiAlias"
			objectoGraficos.TextRenderingHint = TextRenderingHint.AntiAlias
			objectoGraficos.DrawString( strTexto, objectoFonte, Brushes.White, 10, 10 )

			strTexto = "Olá, como se pode verificar esta uma breve descrição com o SystemDefault"
			objectoGraficos.TextRenderingHint = TextRenderingHint.SystemDefault
			objectoGraficos.DrawString( strTexto, New Font("Times", 14), Brushes.White, 12, 50 )

			objectoBitmap.Save( Response.OutputStream, ImageFormat.JPEG )
		</Script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Teste" method="post" runat="server">
		</form>

	</body>
</HTML>
