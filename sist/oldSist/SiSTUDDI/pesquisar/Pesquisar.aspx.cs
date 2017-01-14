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
using SiST;

	//UDDI
using Microsoft.Uddi;
using Microsoft.Uddi.Business;

namespace SiSTUddi.pesquisar
{
	/// <summary>
	/// Permite a pesquisa de organiza��es pelo nome no 
	/// UDDI.
	/// </summary>
	public class Pesquisar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.Button btnProcurar;
		protected System.Web.UI.WebControls.Table tblLista;
		protected System.Web.UI.WebControls.Label lblMensagem;
		protected System.Web.UI.WebControls.RadioButtonList rbParametrosPesquisa;

		//public static string PesquisaNome
		//{
		//}
		public Pesquisar()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			lblMensagem.Text = "";
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
			this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
			this.ID = "Pesquisar";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void procuraNomes()
		{
			Pesquisa p = new Pesquisa();
			//bool a = p.PesquisarNome("%");
			//Console.WriteLine(a);
			if (p.PesquisarNome(txtNome.Text))
			{
	
				TableRow linha = new TableRow();
				TableCell celula = new TableCell();
				//T�tulo
				linha = new TableRow();
				linha.BackColor = Color.FromArgb(176,196,222); //Cor para fundos
					

				celula = new TableCell();
				celula.Controls.Add(new LiteralControl("<b>Nome</b>"));
				linha.Cells.Add(celula);

				celula = new TableCell();
				celula.Controls.Add(new LiteralControl("<b>Descri��o</b>"));
				linha.Cells.Add(celula);

				tblLista.Rows.Add(linha);

				foreach( BusinessInfo InformacaoEmpresa in p.listaEmpresas.BusinessInfos )
				{
					linha = new TableRow();
					linha.BackColor = Color.Empty;
					celula = new TableCell();
					celula.VerticalAlign = VerticalAlign.Top;
					celula.Controls.Add(new LiteralControl(InformacaoEmpresa.Name));
					linha.Cells.Add(celula);

					// Output dos business descriptions
					celula = new TableCell();
					for (int i=0; i< InformacaoEmpresa.Descriptions.Count; i++)
					{
						celula.Controls.Add(new LiteralControl(InformacaoEmpresa.Descriptions[0].Text + "<br>"));
					}
					linha.Cells.Add(celula);

					tblLista.Rows.Add(linha);
				}
			}
			else
			{
				lblMensagem.Text="N�o foram encontradas empresas, reformule a pesquisa";
			}
		}

		private void procuraTipoEmpresa()
		{
			lblMensagem.Text="N�o foram encontradas servi�os, reformule a pesquisa";
		}
		/// <sumary>
		/// Procurar a organizacao
		/// </sumary>
		private void btnProcurar_Click(object sender, System.EventArgs e)
		{
			if (rbParametrosPesquisa.SelectedItem.Value.ToString()=="nome")
			{
				this.procuraNomes();
			}
			else if (rbParametrosPesquisa.SelectedItem.Value.ToString()=="prod")
			{
				this.procuraTipoEmpresa();
			}
		}
	}
}