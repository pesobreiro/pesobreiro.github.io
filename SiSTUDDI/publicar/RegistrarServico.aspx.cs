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

//Meu UDDI
using SiST.UddiCliente;
using SiST.UddiAPI.UddiData;

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
		protected System.Web.UI.WebControls.Button btnPublicarServicos;
		protected System.Web.UI.WebControls.Panel pnlErro;
		protected System.Web.UI.WebControls.Label lblErro;
		protected System.Web.UI.WebControls.Button btnEliminarServicos;
		protected System.Web.UI.WebControls.Panel pnlEliminarTaxonomias;
		protected System.Web.UI.WebControls.DataGrid DataGridEliminarTaxonomias;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			try
			{
				if (Session["nome_user"].ToString() != null)
				{
					pnlLoginSemSucesso.Visible = false;
					pnlErro.Visible = false;
					pnlConteudo.Visible = true;
					CarregarEmpresas();
				}
				else { 
					pnlLoginSemSucesso.Visible = true; 
					pnlErro.Visible = false;
					pnlConteudo.Visible = false;
				}
			}
			catch (Exception ex)
			{
				pnlErro.Visible = true;
				lblErro.Text = ex.ToString();
				pnlLoginSemSucesso.Visible = false;
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
			this.btnPublicarServicos.Click += new System.EventHandler(this.btnPublicarServicos_Click);
			this.btnEliminarServicos.Click += new System.EventHandler(this.btnEliminarServicos_Click);
			this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
			this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
			this.btnRegistrarServico.Click += new System.EventHandler(this.btnRegistrarServico_Click);
			this.DataGridEliminarTaxonomias.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridEliminarTaxonomias_DeleteCommand);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion



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
						cmbEmpresas.Items[cmbEmpresas.Items.Count-1].Value = dataRow["class_id"].ToString();

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

		/// <summary>
		/// Carrega as empresas registadas
		/// </summary>
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
				//Determinar o nome da empresa
				SerializadorXML sXML = new SerializadorXML();
				DeserializadorXML dsXML = new DeserializadorXML();

				string resultado = sXML.getBusinessDetail(dataRow["empresa_BusinessKey"].ToString().Trim());
				businessDetail bd = dsXML.getBusinessDetail(resultado);
							
				cmbEmpresas.Items.Add(bd.businessEntity[0].name[0].Value);
				//Guarda o ID da empresa
				cmbEmpresas.Items[cmbEmpresas.Items.Count-1].Value = dataRow["empresa_BusinessKey"].ToString();
			}

			this.cmbEmpresas.SelectedIndex = seleccionado;
		}
		/// <summary>
		/// Carrega os servicos registados num datagrid
		/// </summary>
		private void CarregarServicos()
		{
			Servicos servico = new Servicos();

			//Obter os servicos da empresa activa
			DataTable dt = servico.ObterServicos(cmbEmpresas.SelectedItem.Value);

			//Criar um dataset
			DataSet ds = new DataSet();
			//Criar um typed datatable
			DataTable dtServico = ds.Tables.Add("Servico");

			dtServico.PrimaryKey = new DataColumn[] {dtServico.Columns["BusinessKey"]};

			dtServico.Columns.Add("BusinessKey",typeof(string));
			dtServico.Columns.Add("Descricao",typeof(string));

			//Carregar os servicos
			foreach ( DataRow dataRow in dt.Rows)
			{
				dtServico.NewRow();
				DataRow dr = dtServico.NewRow();
				dr["BusinessKey"] = dataRow["EmpClass_Empresa_BusinessKey"].ToString();
				dr["Descricao"] = dataRow["class_descricao"].ToString();

				dtServico.Rows.Add(dr);
			}
					
			DataGridEliminarTaxonomias.DataSource = ds;
			DataGridEliminarTaxonomias.DataBind();
		}


		#region Tratamento de eventos do web form
		private void btnRegistrarEmpresa_Click(object sender, System.EventArgs e)
		{
			//Determinar o Utilizador
			int id_User = System.Convert.ToInt16(Session["id_user"]);

			//Vou Adicionar a empresa ao Servidor
			PublicarEmpresa pe = new PublicarEmpresa();
		}
		/// <summary>
		/// Analisar o valor seleccionado na lista e obter
		/// os servicos registrados
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnVerServicos_Click(object sender, System.EventArgs e)
		{
			this.btnEliminarServicos.Visible = true;
			this.btnPublicarServicos.Visible = true;
			this.cmbTemp.Items.Clear();
			Servicos servico = new Servicos();

			DataTable dt = servico.ObterServicos(cmbEmpresas.SelectedItem.Value);

			//Carregar as familias
			foreach ( DataRow dataRow in dt.Rows)
			{
				cmbTemp.Items.Add(dataRow["class_descricao"].ToString());
			}
			
			//Sessao com a empresa activa
			Session["id_empresa"] = this.cmbEmpresas.SelectedItem.Value;
			//Percorrer o data set e carregar a combo box
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
			string empresaId;
			//Obter o BusinessKey da empresa Activa no session
			Empresa empresa = new Empresa();
			empresaId = Session["id_empresa"].ToString().Trim();
			
			businessKey = Session["id_empresa"].ToString().Trim();
			
			//registrar a empresa
			Servicos servico = new Servicos();
			int indiceServico = this.cmbElemento.SelectedIndex; //servico seleccionado
			string descricaoServico = this.cmbElemento.SelectedItem.Text; //descricao do servico seleccionado
			//Vai buscar o codigo da taxonomia
			Taxonomia tax = new Taxonomia();
			string codigoServico = tax.CodigoTaxonomia(descricaoServico); //codigo da taxonomia

			servico.RegistrarServico(Session["id_user"].ToString(),Session["token"].ToString() ,businessKey,descricaoServico.Trim(),descricaoServico.Trim(),codigoServico.Trim(),Parametros.UNSPSC31);

			//Mostra uma mensagem de alerta
			RegisterClientScriptBlock("MeuScript", "<script language=JavaScript>" +
				"alert('Serviço " +descricaoServico.Trim()+ " registado com sucesso.')</script>");
		}

		private void btnPublicarServicos_Click(object sender, System.EventArgs e)
		{
			this.pnlRegistrarServico.Visible = true;
			this.pnlEliminarTaxonomias.Visible = false;
			this.MostrarTaxonomias("");
		}

		private void btnEliminarServicos_Click(object sender, System.EventArgs e)
		{
			this.pnlEliminarTaxonomias.Visible = true;
			this.pnlRegistrarServico.Visible = false;
			
			this.CarregarServicos();
		}

		#endregion
		#region Datagrid

		/// <summary>
		/// Associar ao botao delete
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ScriptDelete (object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if (e.Item.ItemType == ListItemType.Item || 
				e.Item.ItemType == ListItemType.AlternatingItem) 
			{
				WebControl button = (WebControl)e.Item.Cells[0].Controls[0];
				button.Attributes.Add ("onclick", "return confirm (\"Tem a certeza?\");");
			}
		}

		private void DataGridEliminarTaxonomias_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName == "Delete")
			{
				//Eliminar o servico
				string servico;
				string businessKey = cmbEmpresas.SelectedItem.Value.Trim();
				//Nao vai buscar a informacao actualizada do DataGrid Control
				//Nao é um bound control basta identificar a coluna e aceder ao valor
				//Bound controls é o controle 0
				servico = e.Item.Cells[2].Text.Trim();
				//Vou actualizar a informacao do servico no registry

				PublicarServico publicarServico = new PublicarServico();
				publicarServico.Eliminar(businessKey,Session["token"].ToString(),servico);

				DataGridEliminarTaxonomias.EditItemIndex = -1; //Cancelar a edicao
				CarregarServicos();
				DataGridEliminarTaxonomias.DataBind();
			}
		}
		#endregion
	}
}
