<%@ page language="C#" autoeventwireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Registo</title>
    <style type="text/css">
        <!--
        body,td,th {
	        font-family: Verdana, Arial, Helvetica, sans-serif;
	        font-size: x-small;
	        color: #000000;
        }
        body {
	        margin-left: 0px;
	        margin-top: 2px;
	        margin-right: 0px;
	        margin-bottom: 0px;
        }
        a:link {
	        color: #019A01;
	        text-decoration: underline;
        }
        a:visited {
	        text-decoration: underline;
	        color: #019A01;
        }
        a:hover {
	        text-decoration: none;
	        color: #FF0000;
        }
        a:active {
	        text-decoration: underline;
	        color: #019A01;
        }
        -->
</style>
<link href="principal.css" rel="stylesheet" type="text/css">
</head>
<body style="position: static; font-size: 12pt; font-family: Times New Roman;" topmargin=2 leftmargin=2>
    <form id="formRegisto" runat="server">
    <div style="text-align: left"><br />
        <table>
            <tr>
              <td colspan="3"></td>
            </tr>
            <tr>
                <td colspan="3">                
                  <div align="center"><strong>Pré-Registo&nbsp; em Jornada Técnica Científica em Exercício 
                      e Saúde</strong></div></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    Institui&ccedil;&atilde;o:</td>
                <td>
                    <asp:TextBox ID="txtInstitution" runat="server" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtInstitution"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    Nome:</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Width="414px" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtName"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    Morada:</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Width="413px" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtAddress"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    Localidade:</td>
                <td>
                    <asp:TextBox ID="txtCity" runat="server" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCity"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    C&oacute;digo Postal:</td>
                <td>
                    <asp:TextBox ID="txtZipCode" runat="server" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtZipCode"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td>                </td>
            </tr>
            <tr>
                <td>
                    email</td>
                <td style="text-align: left">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtEmail"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td>                </td>
            </tr>
            <tr>
                <td style="height: 22px">
                    Telefone:</td>
                <td style="height: 22px">
                    <asp:TextBox ID="txtPhone" runat="server" CssClass="Conteudo"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtPhone"
                        ErrorMessage="Campo necessário"></asp:RequiredFieldValidator></td>
                <td style="height: 22px">                </td>
            </tr>
            <tr>
                <td>
                    Contribuinte:</td>
                <td>
                    <asp:TextBox ID="txtFax" runat="server" Width="149px" CssClass="Conteudo"></asp:TextBox></td>
                <td>                </td>
            </tr>
            <tr>
              <td style="width: 8px">Formação:</td>
              <td style="text-align: left">
              Manh&atilde;
              <select name="select" size="1">
                <option selected>1</option>
                <option>2</option>
                <option>3</option>
                <option>4</option>
              </select>
              Tarde 
              <select name="select2">
                <option selected>5</option>
                <option>6</option>
                <option>7</option>
                <option>8</option>
              </select>
</p>

              
              
              &nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td style="width: 8px">Inscri&ccedil;&atilde;o:</td>
              <td style="text-align: left"><asp:RadioButtonList ID="rbFee" runat="server" CssClass="Conteudo" OnSelectedIndexChanged="rbFee_SelectedIndexChanged">
                <asp:ListItem Value="25">Estudante ou ex-aluno ESDRM (25 €)</asp:ListItem>
                <asp:ListItem Value="45">Profissional (45 €)</asp:ListItem>
              </asp:RadioButtonList></td>
              <td></td>
            </tr>
            <tr>
                <td style="width: 8px">                </td>
                <td style="text-align: left">
                    Os pagamentos dever&atilde;o ser feitos para a conta 078101120112001184707. As transfer&ecirc;ncias bancárias dever&atilde;o ter a identifica&ccedil;&atilde;o "SDM", seguido do primeiro nome e apelido do titular. O comprovativo da transfer&ecirc;ncia, tem que ser enviado
                    pelo inscrito para o fax n&ordm; 243 999292. A inscri&ccedil;&atilde;o só é válida
                    depois de confirmada pela organização, após a qual será emitido o respectivo recibo.
                    Os encargos com a transfer&ecirc;ncia banc&aacute;ria s&atilde;o da responsabilidade do inscrito.</td>
                <td>                </td>
            </tr>
            <tr>
                <td style="width: 8px">
                </td>
                <td style="text-align: left">
                    <asp:Label ID="lblMsg" runat="server" Text="Label" ForeColor="Red"></asp:Label></td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancelar" Width="80px" />
                    <asp:Button ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Enviar" CssClass="Conteudo" Font-Size="Small" Width="80px" /></td>
            </tr>
                    
                    <td colspan="3">                    </td>
                    <font face="Arial, Helvetica, sans-serif" size="2"><b></b></font>
                <td>                </td>
        </table>
<br />
        &nbsp;</div>
</form>
</body>
</html>
