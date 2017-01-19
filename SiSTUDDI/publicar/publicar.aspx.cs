using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace Uddi.publicar
{
	using Microsoft.Uddi;
	using Microsoft.Uddi.Api;
	using Microsoft.Uddi.Business;
	using Microsoft.Uddi.Authentication;
	using Microsoft.Uddi.ServiceType;

	/// <summary>
	/// Summary description for publicar.
	/// </summary>
	public class publicar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label lblUser;
		protected System.Web.UI.WebControls.TextBox txtUser;
		protected System.Web.UI.WebControls.Label lblPass;
		protected System.Web.UI.WebControls.TextBox txtPass;
		protected System.Web.UI.WebControls.Button btnLogin;
		protected System.Web.UI.WebControls.Label lblStatus;
	
		public publicar()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Page_Init(object sender, EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


		private void BtnLogin_Click(object sender, System.EventArgs e)
		{
			
			///<sumary>
			///Inicializa as propriedades da conexão
			///</sumary>
			///
			
			Publish.Url="http://localhost:9443/uddisoap/publishapi";
			Publish.User=txtUser.Text;
			Publish.Password=txtUser.Text;
			
			///<sumary>
			///Regista o utilizador
			///</sumary>
			GetRegisteredInfo registraUtilizador = new GetRegisteredInfo();
			RegisteredInfo informacaoRegistada = new RegisteredInfo();


			//
			// Criar Business Entity
			//
			BusinessEntity be = new BusinessEntity();
			be.Names.Add("Empresa Teste");
			be.AuthorizedName = txtUser.Text;
			//
			// Gravar a entidade
			//
			SaveBusiness sb = new SaveBusiness();

			//GetAuthToken token = new GetAuthToken();
			//token.UserID = txtUser.Text;
			//token.Credentials = txtPass.Text;

			//sb.BusinessEntities = be.Name;
			
			//Adicionar a entidade que vai ser gravada
			sb.BusinessEntities.Add(be);
			sb.Send();

			//BusinessDetail bd = new BusinessDetail();
			//bd = sb;
			//
			// Now save in local registry
			//				
			//s_b.Send();

			// Configure for the site that are going to access

			// Create an object to save a business
			//GetAuthToken token = new GetAuthToken();
			//token.UserID = "sobreiro";
			//token.Credentials = "baril";
			// Create an object to save a business
			//SaveBusiness sb = new SaveBusiness();

			// Add a business entity and allocate a name
			//sb.BusinessEntities.Add();
			//sb.BusinessEntities[0].Name = " *** insert your business name *** ";

			// Send the prepared save business request
			//BusinessDetail savedB = sb.Send();
		}
	}
}
