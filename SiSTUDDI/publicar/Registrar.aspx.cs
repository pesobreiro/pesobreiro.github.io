using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.Mail;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using SiSTUddi.xml;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Summary description for Registrar Utilizador
	/// </summary>
	public class Registrar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnVoltar;
		protected System.Web.UI.WebControls.LinkButton lbtnPublicar;
		protected System.Web.UI.WebControls.LinkButton lbtnVoltar;
		protected System.Web.UI.WebControls.TextBox txtUser;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.TextBox txtConfirmaPassword;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvConfirmaPassword;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvPassword;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvUser;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvEmail;
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvNome;
		protected System.Web.UI.WebControls.TextBox txtNomeEmpresa;
		protected System.Web.UI.WebControls.TextBox txtTelefoneEmpresa;
		protected System.Web.UI.WebControls.TextBox txtMorada;
		protected System.Web.UI.WebControls.TextBox txtLocalidade;
		protected System.Web.UI.WebControls.TextBox txtCodigoPostal;
		protected System.Web.UI.WebControls.Button btnRegistrar;
		protected System.Web.UI.WebControls.Panel pnlRegistrar;
		protected System.Web.UI.HtmlControls.HtmlForm frmLogin;
		protected System.Web.UI.WebControls.Panel pnlErro;
		protected System.Web.UI.WebControls.Panel pnlSucesso;
		protected System.Web.UI.WebControls.CompareValidator CompareValidator;
		protected System.Web.UI.WebControls.Label lblMensagem;
		protected System.Web.UI.WebControls.TextBox txtPais;
	
		private void Page_Load(object sender, System.EventArgs e)
		{

		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnRegistrar_Click(object sender, System.EventArgs e)
		{
			string resultado;
			Utilizador user = new Utilizador();
			resultado = user.CriarUtilizador(this.txtUser.Text,this.txtPassword.Text,this.txtNome.Text, 
				this.txtEmail.Text, this.txtMorada.Text, this.txtLocalidade.Text, 
				this.txtCodigoPostal.Text, this.txtPais.Text);
			if (resultado == "") 
			{
				//Enviar um email para activar a conta			
				MailMessage mail = new MailMessage();
				mail.From = "geral@sist.esdrm.pt";
				mail.To = this.txtEmail.Text;
				mail.Subject = "Activação da conta";
				mail.Body = "Aceda ao endereço " +
					"<a href='http://sist.esdrm.pt/sistuddi/administrar/activarConta.aspx?user=" + txtUser.Text +
					"'>http://sist.esdrm.pt/sistuddi/administrar/activarConta.aspx?user=" + txtUser.Text + 
					"</a> para activar a sua conta <br>Obrigado!";
				mail.BodyFormat = MailFormat.Html;
				SmtpMail.SmtpServer = "mail.esdrm.pt";
				SmtpMail.Send(mail);

				this.txtUser.Text = "";
				this.txtPassword.Text = "";
				this.txtNome.Text = "";
				this.txtEmail.Text = "";
				this.txtMorada.Text = "";
				this.txtLocalidade.Text = "";
				this.txtCodigoPostal.Text = "";
				this.txtPais.Text = "";
				// Enviar uma Mensagem ao utilizador a indicar que foi registrado com sucesso
				this.pnlErro.Visible = false;
				this.pnlSucesso.Visible = true;
				this.pnlRegistrar.Visible = false;
				//Redireccionar o utilizador
				Response.AppendHeader("refresh","5; URL=../Administrar/login.aspx?origem=publicar");
			}
			else 
			{
				//Ocorreu um erro - notificar
				this.pnlRegistrar.Visible = true;
				this.pnlErro.Visible = true;
				this.lblMensagem.Text = resultado;
			}
		}
	}
}
