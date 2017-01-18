using System;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using SiSTUddi.administrar;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Summary description for index.
	/// </summary>
	public class RegistrarServico : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlConteudo;
		protected System.Web.UI.WebControls.Panel pnlLoginSemSucesso;
		protected System.Web.UI.WebControls.LinkButton btnTeste;
		protected System.Web.UI.WebControls.Panel pnlPublicarTaxonomias;
		protected System.Web.UI.HtmlControls.HtmlForm login;
		protected System.Web.UI.WebControls.DropDownList cmbFamilia;
		protected System.Web.UI.WebControls.Button btnFamilia;
		protected System.Web.UI.WebControls.DropDownList cmbClasse;
		protected System.Web.UI.WebControls.Button btnClasse;
		protected System.Web.UI.WebControls.DropDownList cmbElemento;
		protected System.Web.UI.WebControls.Label lblCodigo;
		protected System.Web.UI.WebControls.Label lblDescricao;
		protected System.Web.UI.WebControls.Button btnVerServicos;
		protected System.Web.UI.WebControls.DropDownList cmbEmpresas;
		protected System.Web.UI.WebControls.Button btnRegistrarServico;
		protected System.Web.UI.WebControls.DropDownList cmbTemp;
		protected System.Web.UI.WebControls.Panel pnlRegistrarServico;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button btnPublicarServicos;
		protected System.Web.UI.WebControls.LinkButton Linkbutton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			try
			{
				if (Session["nome_user"].ToString() != null)
				{
					pnlLoginSemSucesso.Visible = false;
					pnlConteudo.Visible = true;
					CarregarEmpresas();
				}
				else { 
					pnlLoginSemSucesso.Visible = true; 
					pnlConteudo.Visible = false;
				}
			}
			catch (Exception ex)
			{
				pnlLoginSemSucesso.Visible = true;
				pnlConteudo.Visible = false;
			}
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
			this.btnVerServicos.Click += new System.EventHandler(this.btnVerServicos_Click);
			this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
			this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
			this.btnRegistrarServico.Click += new System.EventHandler(this.btnRegistrarServico_Click);
			this.btnPublicarServicos.Click += new System.EventHandler(this.btnPublicarServicos_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void CarregarEmpresas()
		{
			int seleccionado = this.cmbEmpresas.SelectedIndex;
			this.cmbEmpresas.Items.Clear();

			//Carregar a combobox com as empresas registradas
			Empresa empresa = new Empresa();
					
			//Colocar num datatable
			DataTable dt = empresa.ObterEmpresas(Session["id_user"].ToString());
			//Carregar as empresas
			foreach ( DataRow dataRow in dt.Rows)
			{
				cmbEmpresas.Items.Add(dataRow["empresa_ID"].ToString());
			}

			this.cmbEmpresas.SelectedIndex = seleccionado;
		}

		private void btnRegistrarEmpresa_Click(object sender, System.EventArgs e)
		{
			//Determinar o Utilizador
			int id_User = System.Convert.ToInt16(Session["id_user"]);

			//Vou Adicionar a empresa ao Servidor
			PublicarEmpresa pe = new PublicarEmpresa();
		}

		private void btnVerServicos_Click(object sender, System.EventArgs e)
		{
			Servicos servicos = new Servicos();
			DataTable dt = servicos.ObterServicos(cmbEmpresas.SelectedItem.Text);

			//Carregar as familias
			foreach ( DataRow dataRow in dt.Rows)
			{
					cmbTemp.Items.Add(dataRow["class_descricao"].ToString());
			}
			
			//Sessao com a empresa activa
			Session["id_empresa"] = this.cmbEmpresas.SelectedItem.Text;
			//Percorrer o data set e carregar a combo box
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
			this.btnRegistrarServico.Enabled = true;
		}

		private void btnRegistrarServico_Click(object sender, System.EventArgs e)
		{
			string businessKey;
			//Obter o BusinessKey da empresa Activa no session
			Empresa empresa = new Empresa();
			businessKey = empresa.ObterBusinessKey(Session["id_empresa"].ToString());
			
			//registrar a empresa
			Servicos servicos = new Servicos();
			servicos.RegistrarServico(businessKey, Session["id_empresa"].ToString(), Session["id_user"].ToString(),this.lblDescricao.Text,this.lblCodigo.Text);
		}

		private void btnPublicarServicos_Click(object sender, System.EventArgs e)
		{
			this.pnlRegistrarServico.Visible = true;

			this.MostrarTaxonomias("");
		}
	}
}
