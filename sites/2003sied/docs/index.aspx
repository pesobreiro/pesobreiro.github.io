<%@ Page CodeBehind="index.aspx.cs" Language="c#" AutoEventWireup="false" Inherits="SiSTPortal.docs.index" %>
<HTML>
	<HEAD>
		<TITLE>Sistema para Integra��o de Servi�os para Turismo</TITLE>
		<META http-equiv="Content-Type" content="text/html;">
		<LINK href="../css/geral.css" type="text/css" rel="stylesheet">
	</HEAD>
	<BODY>
		<TABLE width="100%" border="0">
			<TR>
				<TD><IMG src="../imagens/logoSiST2.jpg" width="586" height="77">
				</TD>
				<td valign="center" align="center"><p>
						<a href="../SiSTUDDI/Administrar/login.aspx?origem=administrar" class="link">Administra��o</a><br>
						<a href="docs/index.html" class="link">Ajuda</a><br>
						<a href="CodeCommentReport/SiST/sist.htm" class="link">UDDI Api</a>
				</td>
			</TR>
		</TABLE>
		<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
			<TR>
				<TD width="22%">
					&nbsp;</FONT></B>
				</TD>
				<TD width="2%">&nbsp;
				</TD>
				<TD width="76%" bgcolor="#b0c4de"><B><FONT color="#ffffff" face="Arial, Helvetica, sans-serif">Ajuda</FONT></B>
				</TD>
			</TR>
			<TR>
				<TD>&nbsp;</TD>
				<TD>&nbsp;</TD>
				<TD class="Texto">
				</TD>
			</TR>
			<TR>
			</TR>
			<TR>
				<TD width="22%" bgcolor="#b0c4de" align="middle"><B><FONT color="#ffffff" face="Arial, Helvetica, sans-serif">Op��es</FONT></B>
				</TD>
				<TD>
				</TD>
			</TR>
			<TR>
				<TD bgcolor="#ffffff" valign="bottom">
					<TABLE width="212" border="0" cellspacing="0" cellpadding="0" bgcolor="#e2e2e2">
						<TR>
							<TD width="28" align="char"><IMG src="../imagens/esqcima.gif" width="28" height="33">
							</TD>
							<TD width="156"><B>
									<P align="center" class="texto">Empresa</P>
								</B>
							</TD>
							<TD width="28"><IMG src="../imagens/dircima.gif" width="28" height="33">
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD>
								<DIV align="center"><A href="../../SiSTUDDI/Administrar/login.aspx?origem=publicar" class="link">Login</A>
								</DIV>
							</TD>
							<TD>&nbsp;
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD>
								<DIV align="center"><A href="../SiSTUDDI/publicar/index.aspx" class="link">Registar</A>
								</DIV>
							</TD>
							<TD>&nbsp;
							</TD>
						</TR>
						<TR>
							<TD width="28" align="char"><IMG src="../imagens/esqbaixo.gif" width="28" height="20">
							</TD>
							<TD>
								<DIV align="center">
								</DIV>
							</TD>
							<TD width="28"><IMG src="../imagens/dirbaixo.gif" width="28" height="20">
							</TD>
						</TR>
						<TR>
						</TR>
					</TABLE>
				</TD>
				<TD>&nbsp;
				</TD>
				<TD valign="top">
					<P class="texto">
						<a href="#oquesist" class="link">O que &eacute; o SiST?</a><BR>
						<a href="#funcionalidades" class="link">Que funcionalidades disponibiliza?</a><BR>
						<a href="#comofunciona" class="link">Como funciona?</a><BR>
						<a href="#comoRegisto" class="link">Como Registo a empresa?</a><BR>
						<a href="#oqueumservicoweb" class="link">O que � um servi�o web?</a><BR>
					</P>
				</TD>
			</TR>
			<TR>
				<TD bgcolor="#ffffff" valign="top">
					<TABLE width="212" border="0" cellspacing="0" cellpadding="0" bgcolor="#e2e2e2">
						<TR>
							<TD width="28" align="char"><IMG src="../imagens/esqcima.gif" width="28" height="33">
							</TD>
							<TD width="156"><B>
									<P align="center" class="texto">Procurar</P>
								</B>
							</TD>
							<TD width="28"><IMG src="../imagens/dircima.gif" width="28" height="33">
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD>
								<DIV align="center"><A href="../../SiSTUDDI/Pesquisar/Pesquisar.aspx" class="link">Empresa 
										de Tur�smo </A>
								</DIV>
							</TD>
							<TD>&nbsp;
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD>
								<DIV align="center"><A href="" class="link">Oferta Tur�stica</A>
								</DIV>
							</TD>
							<TD>&nbsp;
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD>
								<DIV align="center"><A href="" class="link">Op��es Avan�adas</A>
								</DIV>
							</TD>
							<TD>&nbsp;
							</TD>
						</TR>
						<TR>
							<TD width="28" align="char"><IMG src="../imagens/esqbaixo.gif" width="28" height="20">
							</TD>
							<TD>
								<DIV align="center">
								</DIV>
							</TD>
							<TD width="28"><IMG src="../imagens/dirbaixo.gif" width="28" height="20">
							</TD>
						</TR>
						<TR>
							&nbsp;
						</TR>
					</TABLE>
					<BR>
					<TABLE width="212" border="0" cellspacing="0" cellpadding="0" bgcolor="#e2e2e2">
						<DIV align="center">
						</DIV>
						<TR>
							<TD width="28" align="char"><IMG src="../imagens/esqcima.gif" width="28" height="33">
							</TD>
							<TD colspan="2"><B>
									<P align="center" class="texto">Empresas por Zonas</P>
								</B>
							</TD>
							<TD width="28"><IMG src="../imagens/dircima.gif" width="28" height="33">
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD width="80"><A href="../zona.aspx?id=distritos-pt:Aveiro" class="link">Aveiro</A>
							</TD>
							<TD width="80"><A href="../zona.aspx?id=distritos-pt:Leiria" class="link">Leiria</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Acores" class="link">A�ores</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Lisboa" class="link">Lisboa</A>
							</TD>
							<TD>&nbsp;
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Beja" class="link">Beja</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Madeira" class="link">Madeira</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../../zona.aspx?id=distritos-pt:Braga" class="link">Braga</A>
							</TD>
							<TD><A href="../../zona.aspx?id=distritos-pt:Portalegre" class="link">Portalegre</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Braganca" class="link">Bragan�a</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Porto" class="link">Porto</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:CasteloBranco" class="link">Castelo Branco</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Santarem" class="link">Santar�m</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Coimbra" class="link">Coimbra</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Setubal" class="link">Set�bal</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Evora" class="link">�vora</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Viana" class="link">Viana do Castelo</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Faro" class="link">Faro</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:VilaReal" class="link">Vila Real</A>
							</TD>
						</TR>
						<TR>
							<TD>&nbsp;
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Guarda" class="link">Guarda</A>
							</TD>
							<TD><A href="../zona.aspx?id=distritos-pt:Viseu" class="link">Viseu</A>
							</TD>
						</TR>
						<TR>
							<TD width="28" align="char"><IMG src="../imagens/esqbaixo.gif" width="28" height="20">
							</TD>
							<TD>
							</TD>
							<TD>
							</TD>
							<TD width="28"><IMG src="../imagens/dirbaixo.gif" width="28" height="20">
							</TD>
						</TR>
						<DIV>
						</DIV>
					</TABLE>
					<BR>
				</TD>
				<TD>&nbsp;
				</TD>
				<TD valign="top" class="Texto">
					<DIV class="TextoNormal">
						<p><strong><a name="oqueosist">O que &eacute; o SiST</a></strong></p>
						<p>O SiST &eacute; uma aplica&ccedil;&atilde;o que permite a descoberta e 
							interac&ccedil;&atilde;o entre as PMEs participantes na ind&uacute;stria do 
							turismo e potenciais parceiros, atrav&eacute;s do registo, 
							classifica&ccedil;&atilde;o e cataloga&ccedil;&atilde;o dos interfaces expostos 
							de empresas registadas.<br>
							Os utilizadores podem aceder &agrave;s funcionalidades pesquisa de empresa e 
							visualizar as empresas que se encontram registadas por &aacute;reas de 
							actividade e por zonas.<br>
						</p>
						<p><a name="funcionalidades"><strong>Que funcionalidades disponibiliza</strong></a></p>
						<p><strong><em>Empresas:</em></strong></p>
						<ul>
							<li>
								O link login permite aceder &agrave; &aacute;rea privada mediante uma 
								autentica&ccedil;&atilde;o</li>
							<li>
								A op&ccedil;&atilde;o de registar permite o acesso a op&ccedil;&otilde;es de 
								registo de empresa, classifica&ccedil;&otilde;es e defini&ccedil;&otilde;es de 
								pontos de acesso. &Eacute; necess&aacute;rio uma autentica&ccedil;&atilde;o.</li>
						</ul>
						<p><strong><em>Procurar:</em></strong></p>
						<ul>
							<li>
								Empresa de tur&iacute;smo, permite a pesquisar as empresas registadas</li>
							<li>
								Oferta tur&iacute;stica, permite a pesquisa de empresas em fun&ccedil;&atilde;o 
								das ofertas disponibilizadas</li>
						</ul>
						<p><strong><em>Empresas por zonas:</em> </strong>D&aacute; acesso &agrave;s 
							empresas registadas por zona</p>
						<p><strong><em>Administra&ccedil;&atilde;o:</em> </strong>Permite o acesso a uma 
							&aacute;rea reservada para a administra&ccedil;&atilde;o do sistema</p>
						<p><strong><em>Ajuda:</em> </strong>Acesso &agrave; ajuda</p>
						<p><a name="comofunciona"><strong>Como funciona</strong></a></p>
						<p>As empresas registam-se no servidor e passam a estar disponiveis nas ferramentas 
							de pesquisa. Toda a inform&ccedil;&atilde;o &eacute; armazenada num servidor 
							UDDI(Universal, Discovery, Description and Integration).</p>
						<p><a name="comoRegisto"><strong>Como registo a empresa</strong></a></p>
						<p>Uma empresa pode ser registada mediante o acesso a uma &aacute;rea privada, 
							atrav&eacute;s da utiliza&ccedil;&atilde;o de um username e uma password. O 
							dados para o acesso s&atilde;o obtidos no As empresas registam-se no servidor e 
							passam a estar disponiveis nas ferramentas de pesquisa. Toda a 
							inform&ccedil;&atilde;o &eacute; armazenada num servidor UDDI(Universal, 
							Discovery, Description and Integration).</p>
						<p><a name="oqueeumservicoweb"><strong>O que &eacute; um servi&ccedil;o web</strong></a></p>
						<p>Um servi&ccedil;o web &eacute; um interface para uma aplica&ccedil;&atilde;o 
							acess&iacute;vel numa rede, atrav&eacute;s da utiliza&ccedil;&atilde;o de 
							protocolos tais como, HTTP, XML ou SMTP. Este tipo de interfaces posiciona-se 
							entre a aplica&ccedil;&atilde;o e o utilizador da aplica&ccedil;&atilde;o, 
							permitindo separar os detalhes da plataforma e da linguagem utilizada para 
							implementar o programa.</p>
						<p>&nbsp;</p>
					</DIV>
				</TD>
			</TR>
			<TR>
				<TD bgcolor="#ffffff" valign="top">&nbsp;</TD>
				<TD>&nbsp;</TD>
				<TD valign="top">&nbsp;</TD>
			</TR>
			<TR>
			</TR>
		</TABLE>
		<br>
		<!--#include virtual="../menubaixo.inc" -->
	</BODY>
</HTML>
