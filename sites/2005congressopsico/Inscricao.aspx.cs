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
	public partial class WebForm1 : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
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

		}
		#endregion

		protected void btnEnviar_Click(object sender, System.EventArgs e)
		{
			//Criar a conexao com a base de dados
			OdbcConnection conexao = new OdbcConnection();
			// Define a conexao para a base de dados em access no caminho especificado
			conexao.ConnectionString = 	conexao.ConnectionString = "DSN=CongressoPsicologia";
			conexao.Open();

			//Obter o dia
			DateTime agora = DateTime.Now;
			//Coloca a informacao na base de dados
			//Definir um provider
			string instrucaoSQL = "INSERT into inscricao (" +
				"instituicao, nome, morada, localidade, "+
				"codigoPostal, email, telefone, contribuinte, " +
				"estudante, inscricao, dia ) " + 
				"VALUES ('"+this.txtInstituicao.Text + "','" + this.txtNome.Text + "','" + 
				this.txtMorada.Text + "','" + this.txtLocalidade.Text + 
				"','" + this.txtCodPostal.Text + "','" + this.txtEmail.Text + "','" + this.txtTelefone.Text +
				"','" + this.txtContribuinte.Text + "','" + this.CheckBoxEstudante.Checked.ToString() + 
				"','" + this.rbComunicacao.SelectedValue + "'," + agora.Day +")";

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
