<%@ Page language="c#" Codebehind="categoria.aspx.cs" AutoEventWireup="false" Inherits="SiSTPortal.categoria" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>categorias</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio 7.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<link href="css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table width="100%" border="0">
			<tr>
				<td><img src="imagens/logoSiST2.jpg"></td>
				<td align="middle" valign="top"><a href="../SiSTUDDI/Administrar/login.aspx?origem=administrar" class="link">Administração</a></td>
			</tr>
		</table>
		<table width="100%" border="0" cellSpacing="0" cellPadding="0">
			<tr>
				<td width="22%">&nbsp;</FONT></B></td>
				<td width="2%">&nbsp;</td>
				<td width="76%" bgcolor="#b0c4de">
					<b><font color="#ffffff" face="Arial, Helvetica, sans-serif">Bem vindo ao SiST</font></b>
				</td>
			</tr>
			<tr>
				<td hei width="22%" bgcolor="#b0c4de" align="middle"><b><font color="#ffffff" face="Arial, Helvetica, sans-serif">Opções</font></b></td>
				<td>&nbsp;</td>
				<td class="TextoNormal" align="middle">O SiST é uma aplicação que permite a 
					pesquisa e o registro de empresas através do protocolo UDDI.</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td></td>
				<td class="TextoNormal" valign="top">&nbsp;</td>
			</tr>
			<tr>
				<td>
					<table width="212" border="0" cellspacing="0" cellpadding="0" bgcolor="#e2e2e2">
						<tr>
							<td width="28"><img src="imagens/esqcima.gif" width="28" height="33"></td>
							<td width="156"><p align="center" class="texto"><b>Empresa</b></p>
								</B>
							</td>
							<td width="28"><img src="imagens/dircima.gif" width="28" height="33"></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><div align="center"><a href="../SiSTUDDI/Administrar/login.aspx?origem=publicar" class="link">Login</a></div>
							</td>
							<td>&nbsp;</td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><div align="center"><a href="../SiSTUDDI/publicar/index.aspx" class="link">Registrar</a></div>
							</td>
							<td>&nbsp;</td>
						</tr>
						<tr>
							<td width="28"><img src="imagens/esqbaixo.gif" width="28" height="20"></td>
							<td><div align="center"></div>
							</td>
							<td width="28"><img src="imagens/dirbaixo.gif" width="28" height="20"></td>
						</tr>
					</table>
				</td>
				<td></td>
				<td rowspan="3">
					<asp:Panel id="pnlLista" runat="server" Width="100%" Height="100%" BorderStyle=Solid>
						<asp:Table id="tblLista" runat="server" Height="100%" Width="100%"></asp:Table>
					</asp:Panel></td>
			</tr>
			<tr>
				<td><br>
					<table width="212" border="0" cellspacing="0" cellpadding="0" bgcolor="#e2e2e2">
						<tr>
							<td width="28"><img src="imagens/esqcima.gif" width="28" height="33"></td>
							<td width="156">
								<p align="center" class="texto"><b>Procurar</b></p>
							</td>
							<td width="28"><img src="imagens/dircima.gif" width="28" height="33"></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><div align="center"><a href="../SiSTUDDI/Pesquisar/Pesquisar.aspx" class="link">Empresa 
										de Turísmo </a>
								</div>
							</td>
							<td>&nbsp;</td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><div align="center"><a href="" class="link">Oferta Turística</a></div>
							</td>
							<td>&nbsp;</td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><div align="center"><a href="" class="link">Opções Avançadas</a></div>
							</td>
							<td>&nbsp;</td>
						</tr>
						<tr>
							<td width="28" align="char"><img src="imagens/esqbaixo.gif" width="28" height="20"></td>
							<td><div align="center"></div>
							</td>
							<td width="28"><img src="imagens/dirbaixo.gif" width="28" height="20"></td>
						</tr>
					</table>
				</td>
				<td></td>
				<!-- row span <td></td> -->
			</tr>
			<tr>
				<td><br>
					<table width="212" border="0" cellspacing="0" cellpadding="0" bgcolor="#e2e2e2">
						<tr>
							<td width="28" align="char"><img src="imagens/esqcima.gif" width="28" height="33"></td>
							<td colspan="2">
								<b>
									<p align="center" class="texto">Empresas por Distritos</p>
								</b>
							</td>
							<td width="28"><img src="imagens/dircima.gif" width="28" height="33"></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td width="80"><a href="" class="link">Aveiro</a></td>
							<td width="80"><a href="" class="link">Leiria</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Açores</a></td>
							<td><a href="" class="link">Lisboa</a></td>
							<td>&nbsp;</td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Beja</a></td>
							<td><a href="" class="link">Madeira</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Braga</a></td>
							<td><a href="" class="link">Portalegre</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Bragança</a></td>
							<td><a href="" class="link">Porto</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Castelo Branco</a></td>
							<td><a href="" class="link">Santarém</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Coimbra</a></td>
							<td><a href="" class="link">Setúbal</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Évora</a></td>
							<td><a href="" class="link">Viana do Castelo</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Faro</a></td>
							<td><a href="" class="link">Vila Real</a></td>
						</tr>
						<tr>
							<td>&nbsp;</td>
							<td><a href="" class="link">Guarda</a></td>
							<td><a href="" class="link">Viseu</a></td>
						</tr>
						<tr>
							<td width="28" align="char"><img src="imagens/esqbaixo.gif" width="28" height="20"></td>
							<td></td>
							<td></td>
							<td width="28"><img src="imagens/dirbaixo.gif" width="28" height="20"></td>
						</tr>
					</table>
				</td>
				<td></td>
				<!-- rowspan <td>dddd</td> -->
			</tr>
		</table>
		</TD></TR></TBODY></TABLE>
		<form id="categorias" method="post" runat="server">
		</form>
	</body>
</HTML>
