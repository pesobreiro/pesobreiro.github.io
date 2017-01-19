using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Summary description for login.
	/// </summary>
	public class login : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblUsername;
		protected System.Web.UI.WebControls.RequiredFieldValidator Requiredfieldvalidator2;
		protected System.Web.UI.WebControls.TextBox txtPassword;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.TextBox txtUsername;
		protected System.Web.UI.WebControls.Label lblLogin;
		protected System.Web.UI.WebControls.LinkButton LinkBtnLogin;
		protected System.Web.UI.WebControls.Panel pnlLogincomSucesso;
		protected System.Web.UI.WebControls.LinkButton btnTeste;
		protected System.Web.UI.WebControls.Label lblConta;
		protected System.Web.UI.WebControls.Panel pnlLogIn;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.LinkBtnLogin.Click += new System.EventHandler(this.LinkBtnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkBtnLogin_Click(object sender, System.EventArgs e)
		{
			VerificarAcesso verificaUser = new VerificarAcesso();


			verificaUser.Password = txtPassword.Text;
			verificaUser.UserName = txtUsername.Text;
			

			//Invoca o metodo para validar os acessos

			bool acessoValido = verificaUser.ValidarAcesso();

			if (acessoValido) 
			{
				pnlLogincomSucesso.Visible=true;
				lblLogin.Visible = false;
				lblConta.Visible = false;

				//Criar a sessão utilizador
				Session["nome_user"] = txtUsername.Text;
				Session["password"] = txtPassword.Text;

				//Criar a sessão id_utilizador
				Session["id_user"] = verificaUser.UserID;
				//Volta ao url de onde foi enviada
				//Vou inspeccionar a query string e retornar 
				//ao local de onde fui enviado
				NameValueCollection qstr=Request.QueryString;
				string origem = qstr.Get("origem");

				string caminho = Request.ApplicationPath + "/" +  origem + "/";
				Response.Redirect(caminho + "index.aspx");
			}
			else
			{
				pnlLogincomSucesso.Visible=false;
				lblLogin.Visible = true;
				//Permitir o envio de uma mensagem caso a conta esteja desactivada
				lblConta.Visible = false; 
			}
		}

	}
}
