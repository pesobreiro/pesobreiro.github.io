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
using SiST.UddiCliente;
using SiST.UddiAPI.UddiData;
using SiST.UddiAPI.UddiMensagem;


namespace SiSTUddi.publicar
{
	/// <summary>
	/// Summary description for index.
	/// </summary>
	public class index : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlConteudo;
		protected System.Web.UI.WebControls.Panel pnlLoginSemSucesso;
		protected System.Web.UI.WebControls.LinkButton btnTeste;
		protected System.Web.UI.HtmlControls.HtmlForm login;
		protected System.Web.UI.WebControls.DataGrid DataGridEmpresas;
		protected System.Web.UI.WebControls.Label lblMessagem;
		protected System.Web.UI.WebControls.LinkButton Linkbutton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			try
			{
				if (Session["nome_user"].ToString() != null)
				{
					pnlLoginSemSucesso.Visible = false;
					pnlConteudo.Visible = true;

					//Criar a Sessao com o token
					SiST.UddiAPI.UddiData.authToken token = new SiST.UddiAPI.UddiData.authToken();
					SiST.UddiCliente.SerializadorXML sXML = new SiST.UddiCliente.SerializadorXML();
					token = sXML.obterToken(Session["nome_user"].ToString(),Session["password"].ToString());
					Session["token"] = token.authInfo;

					if (!IsPostBack){
						this.CarregarEmpresas();
					}

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
			this.DataGridEmpresas.CancelCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridEmpresas_CancelCommand);
			this.DataGridEmpresas.EditCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridEmpresas_EditCommand);
			this.DataGridEmpresas.UpdateCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridEmpresas_UpdateCommand);
			this.DataGridEmpresas.DeleteCommand += new System.Web.UI.WebControls.DataGridCommandEventHandler(this.DataGridEmpresas_DeleteCommand);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion



		public void Bindgrid() 
		{
			CarregarEmpresas();
			DataGridEmpresas.DataKeyField = "businessKey";
			DataGridEmpresas.DataBind();
		}
    
		/// <summary>
		/// Carrega as empresas registadas num datagrid
		/// </summary>
		private void CarregarEmpresas()
		{
			//Carregar a combobox com as empresas registradas
			Empresa empresa = new Empresa();
					
			//Colocar num datatable
			DataTable dt = empresa.ObterEmpresas(Session["id_user"].ToString());
			
			//Criar um dataset
			DataSet ds = new DataSet();
			//Criar um typed datatable
			DataTable dtEmpresa = ds.Tables.Add("Empresas");

			dtEmpresa.PrimaryKey = new DataColumn[] {dtEmpresa.Columns["BusinessKey"]};

			dtEmpresa.Columns.Add("BusinessKey",typeof(string));
			dtEmpresa.Columns.Add("Nome",typeof(string));
			dtEmpresa.Columns.Add("Descricao",typeof(string));
			dtEmpresa.Columns.Add("Contacto",typeof(string));
			dtEmpresa.Columns.Add("FuncaoContacto",typeof(string));

			//dtEmpresa.PrimaryKey[0] = dtEmpresa.Columns["BusinessKey"];

			//Carregar as empresas
			foreach ( DataRow dataRow in dt.Rows)
			{
				//Determinar o nome da empresa
				SerializadorXML sXML = new SerializadorXML();
				DeserializadorXML dsXML = new DeserializadorXML();

				string resultado = sXML.getBusinessDetail(dataRow["empresa_BusinessKey"].ToString().Trim());
				businessDetail bd = dsXML.getBusinessDetail(resultado);

				dtEmpresa.NewRow();
				DataRow dr = dtEmpresa.NewRow();
				dr["BusinessKey"] = bd.businessEntity[0].businessKey;
				dr["Nome"] = bd.businessEntity[0].name[0].Value;
				dr["Descricao"] = bd.businessEntity[0].description[0].Value;
				dr["Contacto"] = bd.businessEntity[0].contacts[0].personName;
				dr["FuncaoContacto"] = bd.businessEntity[0].contacts[0].useType;

				dtEmpresa.Rows.Add(dr);
			}
			DataGridEmpresas.DataSource = ds;
			DataGridEmpresas.DataBind();
		}

		/// <summary>
		/// Trata botao edit DataGrid
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void DataGridEmpresas_EditCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
				DataGridEmpresas.EditItemIndex = e.Item.ItemIndex;
				DataGridEmpresas.DataBind();
				Bindgrid();
		}

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
				WebControl button = (WebControl)e.Item.Cells[1].Controls[0];
				button.Attributes.Add ("onclick", "return confirm (\"Tem a certeza?\");");
			}
		}


		/// <summary>
		/// Trata botao update DataGrid
		/// Actualiza a informacao da empresa
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void DataGridEmpresas_UpdateCommand(object source, DataGridCommandEventArgs e)
		{
			TextBox txtNome, txtDescricao, txtContacto, txtFuncao;
			string businessKey, nome, descricao, contacto, funcao;
			//Nao vai buscar a informacao actualizada do DataGrid Control
			//Nao é um bound control basta identificar a coluna e aceder ao valor
			//Bound controls é o controle 0
			businessKey = e.Item.Cells[2].Text;
			txtNome = (TextBox)e.Item.Cells[3].Controls[0];
			txtDescricao = (TextBox)e.Item.Cells[4].Controls[0];
			txtContacto = (TextBox)e.Item.Cells[5].Controls[0];
			txtFuncao = (TextBox)e.Item.Cells[6].Controls[0];

			nome = txtNome.Text;
			descricao = txtDescricao.Text;
			contacto = txtContacto.Text;
			funcao = txtFuncao.Text;

			//Vou actualizar a informacao da empresa no registry
			//Fazer o update
			SiST.Registro.Empresa empresa = new SiST.Registro.Empresa();
			empresa.Alterar(Session["token"].ToString(),businessKey,nome,descricao,contacto,funcao);

			DataGridEmpresas.EditItemIndex = -1;
			Bindgrid();
		}


		/// <summary>
		/// Trata botao cancel DataGrid
		/// </summary>
		/// <param name="source"></param>
		/// <param name="e"></param>
		private void DataGridEmpresas_CancelCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			DataGridEmpresas.EditItemIndex = -1; //Cancelar a edicao
			CarregarEmpresas();
			DataGridEmpresas.DataBind();
		}

		private void DataGridEmpresas_DeleteCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
		{
			if (e.CommandName == "Delete")
			{
				//Eliminar a empresa
				string businessKey;
				//Nao vai buscar a informacao actualizada do DataGrid Control
				//Nao é um bound control basta identificar a coluna e aceder ao valor
				//Bound controls é o controle 0
				businessKey = e.Item.Cells[2].Text;

				//Vou actualizar a informacao da empresa no registry
				PublicarEmpresa publicarEmpresa = new PublicarEmpresa();
				publicarEmpresa.Eliminar(Session["id_user"].ToString(),Session["token"].ToString(),businessKey);

				DataGridEmpresas.EditItemIndex = -1; //Cancelar a edicao
				CarregarEmpresas();
				DataGridEmpresas.DataBind();
			}
		}

	}
}
