using System;
using System.Xml;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

//Meu UDDI
using SiST.UddiAPI.UddiData;


namespace SiSTUddi.pesquisa
{
	/// <summary>
	/// Permite a pesquisa de organizações pelo nome no 
	/// UDDI.
	/// </summary>
	public class Pesquisar : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.Button btnProcurar;
		protected System.Web.UI.WebControls.Table tblLista;
		protected System.Web.UI.WebControls.Label lblMensagem;
		protected System.Web.UI.WebControls.Label lblDescricao;
		protected System.Web.UI.WebControls.Label lblCodigo;
		protected System.Web.UI.WebControls.DropDownList cmbElemento;
		protected System.Web.UI.WebControls.Button btnClasse;
		protected System.Web.UI.WebControls.DropDownList cmbClasse;
		protected System.Web.UI.WebControls.Button btnFamilia;
		protected System.Web.UI.WebControls.DropDownList cmbFamilia;
		protected System.Web.UI.WebControls.Panel pnlPesquisarNome;
		protected System.Web.UI.WebControls.Panel pnlPesquisarServico;
		protected System.Web.UI.WebControls.Label lblCategory;

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
			if (Request.QueryString["tipopesquisa"] == "oferta")
			{
				this.pnlPesquisarServico.Visible = true;
				this.pnlPesquisarNome.Visible = false;

				this.MostrarTaxonomias("");
			}
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
			this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
			this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
			this.ID = "Pesquisar";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void procuraNomes()
		{
			Pesquisa p = new Pesquisa();

			businessEntity[] bes = p.PesquisarNome(txtNome.Text);

			//Obteve valores
			if (bes.Length > 0)
			{
	
				TableRow linha = new TableRow();
				TableCell celula = new TableCell();
				//Título
				linha = new TableRow();
				linha.BackColor = Color.FromArgb(176,196,222); //Cor para fundos
					

				celula = new TableCell();
				celula.Controls.Add(new LiteralControl("<b>Nome</b>"));
				linha.Cells.Add(celula);

				celula = new TableCell();
				celula.Controls.Add(new LiteralControl("<b>Descrição</b>"));
				linha.Cells.Add(celula);

				tblLista.Rows.Add(linha);

				foreach( businessEntity be in bes)
				{
					linha = new TableRow();
					linha.BackColor = Color.Empty;
					celula = new TableCell();
					celula.VerticalAlign = VerticalAlign.Top;
					celula.Controls.Add(new LiteralControl("<a href='empresa.aspx?id="+be.businessKey+"' class='link'>" + be.name[0].Value+@"</a>"));
					linha.Cells.Add(celula);

					// Output dos business descriptions
					celula = new TableCell();
					Description[] descricoes = be.description;
					if (descricoes != null)
					{
						celula.Controls.Add(new LiteralControl(be.description[0].Value + "<br>"));
					}
					linha.Cells.Add(celula);

					tblLista.Rows.Add(linha);
				}
			}
			else
			{
				lblMensagem.Text="Não foram encontradas empresas!";
			}
		}

		private void procuraCategoria(string codigo)
		{
			Pesquisa p = new Pesquisa();
			businessEntity[] bes = p.ProcurarServico(codigo);

			//Obteve valores
			if (bes.Length > 0)
			{
	
				TableRow linha = new TableRow();
				TableCell celula = new TableCell();
				//Título
				linha = new TableRow();
				linha.BackColor = Color.FromArgb(176,196,222); //Cor para fundos
					

				celula = new TableCell();
				celula.Controls.Add(new LiteralControl("<b>Nome</b>"));
				linha.Cells.Add(celula);

				celula = new TableCell();
				celula.Controls.Add(new LiteralControl("<b>Descrição</b>"));
				linha.Cells.Add(celula);

				tblLista.Rows.Add(linha);

				foreach( businessEntity be in bes)
				{
					linha = new TableRow();
					linha.BackColor = Color.Empty;
					celula = new TableCell();
					celula.VerticalAlign = VerticalAlign.Top;
					celula.Controls.Add(new LiteralControl("<a href='empresa.aspx?id="+be.businessKey+"' class='link'>" + be.name[0].Value+@"</a>"));
					linha.Cells.Add(celula);

					// Output dos business descriptions
					celula = new TableCell();
					Description[] descricoes = be.description;
					if (descricoes != null)
					{
						celula.Controls.Add(new LiteralControl(be.description[0].Value + "<br>"));
					}
					linha.Cells.Add(celula);

					tblLista.Rows.Add(linha);
				}
			}
			else
			{
				lblMensagem.Text="Não foram encontradas empresas!";
			}
		}

		private void MostrarTaxonomias(string descricao)
		{
			string codigo = descricao;
			//Obter as taxonomias
			Taxonomia taxonomia = new Taxonomia();

			if (descricao =="")
			{
				//Colocar num datatable
				DataTable dt = taxonomia.obterTaxonomias();
				//Carregar as familias
				foreach ( DataRow dataRow in dt.Rows)
				{
					codigo = dataRow["class_id"].ToString().Trim();
					if ((codigo.Length == 4))
					{
						cmbFamilia.Items.Add(dataRow["class_descricao"].ToString());
						//Guarda o id do servico
						//falta guardar o ID na
					}
				}
			}
			else
			{
				//Colocar num datatable
				DataTable dt = taxonomia.obterTaxonomias(descricao);
				foreach ( DataRow dataRow in dt.Rows)
				{

					if ((dataRow["class_id"].ToString().Trim().Length == 6))
					{
						cmbClasse.Items.Add(dataRow["class_descricao"].ToString());
					}
					if ((dataRow["class_id"].ToString().Trim().Length == 8))
					{
						cmbElemento.Items.Add(dataRow["class_descricao"].ToString());
					}
					if ((dataRow["class_id"].ToString().Trim().Length == 8))
					{
						this.lblCodigo.Text = dataRow["class_id"].ToString();
						this.lblDescricao.Text = dataRow["class_descricao"].ToString();
					}
				}
			}
		}

		/// <sumary>
		/// Procurar a organizacao
		/// </sumary>
		private void btnProcurar_Click(object sender, System.EventArgs e)
		{
			if (Request.QueryString["tipopesquisa"] == "empresa")
			{
				this.procuraNomes();
			}
			else if (Request.QueryString["tipopesquisa"] == "oferta")
			{
				//Obter o código activo
				//Vai buscar o codigo da taxonomia
				Taxonomia tax = new Taxonomia();
				string descricaoServico = this.cmbElemento.SelectedItem.Text;
				string codigo = tax.CodigoTaxonomia(descricaoServico); 
				this.procuraCategoria(codigo);
			}
		}

		private void btnFamilia_Click(object sender, System.EventArgs e)
		{
			string seleccao = cmbFamilia.SelectedItem.Text;

			this.cmbClasse.Items.Clear();
			this.cmbElemento.Items.Clear();
			this.MostrarTaxonomias(seleccao);

			this.btnClasse.Enabled = true;
			this.cmbClasse.Enabled = true;
		}

		private void btnClasse_Click(object sender, System.EventArgs e)
		{
			string seleccao = cmbClasse.SelectedItem.Text;

			this.cmbElemento.Items.Clear();
			this.MostrarTaxonomias(seleccao);

			this.cmbElemento.Enabled = true;
		}
	}
}