using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.Odbc;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Configuration.Assemblies;

namespace CongressoPsicologia
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox txtEmail;
		protected System.Web.UI.WebControls.TextBox txtCodPostal;
		protected System.Web.UI.WebControls.TextBox txtLocalidade;
		protected System.Web.UI.WebControls.TextBox txtMorada;
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox txtInstituicao;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.HyperLink HyperLink1;
		protected System.Web.UI.WebControls.Panel PnlObrigado;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator5;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator7;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator8;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.Label Label10;
		protected System.Web.UI.WebControls.TextBox txtContribuinte;
		protected System.Web.UI.WebControls.TextBox txtTelefone;
		protected System.Web.UI.WebControls.Label lblMsg;
		protected System.Web.UI.WebControls.RadioButtonList rbComunicacao;
		protected System.Web.UI.WebControls.Button btnEnviar;
	
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
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void btnEnviar_Click(object sender, System.EventArgs e)
		{
			//Criar a conexao com a base de dados
			OdbcConnection conexao = new OdbcConnection();
			// Define a conexao para a base de dados em access no caminho especificado
			conexao.ConnectionString = 	conexao.ConnectionString = "DSN=Pnl2005";

			conexao.Open();

			//Coloca a informacao na base de dados
			//Definir um provider
			string instrucaoSQL = "INSERT into inscricao (" +
				"instituicao, nome, morada, localidade, "+
				"codigoPostal, email, telefone, contribuinte, " +
				"inscricao ) " + 
				"VALUES ('"+this.txtInstituicao.Text + "','" + this.txtNome.Text + "','" + 
				this.txtMorada.Text + "','" + this.txtLocalidade.Text + 
				"','" + this.txtCodPostal.Text + "','" + this.txtEmail.Text + "','" + this.txtTelefone.Text +
				"','" + this.txtContribuinte.Text + "','" + this.rbComunicacao.SelectedValue + "')";
			OdbcCommand comando = new OdbcCommand(instrucaoSQL,conexao);
			try
			{
				comando.ExecuteNonQuery();
				this.PnlObrigado.Visible = true;
				this.lblMsg.Text = "Obrigado pela sua inscrição!";
			}
			catch (Exception ex)
			{
				this.PnlObrigado.Visible = true;
				this.lblMsg.Text = ex.ToString();

			}
			conexao.Close();
		}
	}
}
