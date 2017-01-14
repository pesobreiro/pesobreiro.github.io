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

using SiSTUddi.xml;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Summary description for CriarTaxonomias.
	/// </summary>
	public class Publicar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button btnVoltar;
		protected System.Web.UI.WebControls.LinkButton lbtnPublicar;
		protected System.Web.UI.WebControls.LinkButton lbtnVoltar;
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvNome;
		protected System.Web.UI.WebControls.TextBox txtTModelKey;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvTModelKey;
		protected System.Web.UI.WebControls.TextBox txtDescricao;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvDescricao;
		protected System.Web.UI.WebControls.RadioButtonList rbCaracterizacao;
		protected System.Web.UI.WebControls.TextBox txtMsg;
		protected System.Web.UI.WebControls.Button btnPublicar;
	
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
			this.btnPublicar.Click += new System.EventHandler(this.btnPublicar_Click);

		}
		#endregion

		private void btnPublicar_Click(object sender, System.EventArgs e)
		{
			//Enviar a informacao para ser publicada no servidor
			//Invocação de um metodo no serializador para publicacao da das taxonomias
			string nome = this.txtNome.Text;
			string descricao = this.txtDescricao.Text;
			int caracterizacao = this.rbCaracterizacao.SelectedIndex;

			//criar o ficheiro xml 

			Serializador serializador = new Serializador();
			txtMsg.Text = serializador.findtModel("%");

			//find_business fb = new find_business();
			find_tModel ftm = new find_tModel();			
			txtMsg.Text = serializador.enviarSocket("localhost",ftm,true);


		}

	}
}
