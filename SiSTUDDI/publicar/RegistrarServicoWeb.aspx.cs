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

//Meu UDDI
using SiST.UddiCliente;
using SiSTUddi.administrar;
using SiST.UddiAPI.UddiData;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Summary description for index.
	/// </summary>
	public class RegistrarServicoWeb : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlConteudo;
		protected System.Web.UI.WebControls.Panel pnlLoginSemSucesso;
		protected System.Web.UI.WebControls.LinkButton btnTeste;
		protected System.Web.UI.WebControls.Panel pnlPublicarTaxonomias;
		protected System.Web.UI.HtmlControls.HtmlForm login;
		protected System.Web.UI.WebControls.Panel pnlRegistrarServicoWeb;
		protected System.Web.UI.WebControls.DropDownList cmbEmpresas;
		protected System.Web.UI.WebControls.TextBox txtDescricaoPAcesso;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvDescricaoPAcesso;
		protected System.Web.UI.WebControls.DropDownList cmbTiposUrl;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvURLPontoAcesso;
		protected System.Web.UI.WebControls.DropDownList cmbtModel;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvClassificacao;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvURLDescricao;
		protected System.Web.UI.WebControls.Button btnCriarBinding;
		protected System.Web.UI.WebControls.TextBox txtURLPontoAcesso;
		protected System.Web.UI.WebControls.TextBox txtDocPontoAcesso;
		protected System.Web.UI.WebControls.TextBox txtURLDocPontoAcesso;
		protected System.Web.UI.WebControls.Button btnVerServicos;
		protected System.Web.UI.WebControls.DropDownList cmbServicos;
		protected System.Web.UI.WebControls.Panel pnlDefinirPontos;
		protected System.Web.UI.WebControls.Button btnDefinirBinding;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvDescricao;
		protected System.Web.UI.WebControls.TextBox txtDescricao;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvNome;
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.Button btnAdicionar;
		protected System.Web.UI.WebControls.LinkButton Linkbutton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
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
			this.btnCriarBinding.Click += new System.EventHandler(this.btnCriarBinding_Click);
			this.btnDefinirBinding.Click += new System.EventHandler(this.btnDefinirBinding_Click);
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		/// <summary>
		/// Carrega as empresas disponiveis na combobox
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
		/// Carrega os tModels disponiveis na combobox
		/// </summary>
		private void CarregartModels()
		{
			//Carregar a combobox com os tModels
			this.cmbtModel.Items.Clear();

			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();

			string resultado = sXML.findtModel("%"); //Obtem os tModels
			tModelInfo[] tmis = dsXML.findtModel(resultado);

			//Carregar os tmodels
			foreach (tModelInfo tmi in tmis)
			{
				this.cmbtModel.Items.Add(tmi.name);
				//guarda o id
				this.cmbtModel.Items[cmbtModel.Items.Count-1].Value = tmi.tModelKey;
			}


		}

		private void btnDefinirBinding_Click(object sender, System.EventArgs e)
		{
			//Carregar a lista de tipos de urls

			//Carregar os tModels
			this.CarregartModels();
			this.pnlRegistrarServicoWeb.Visible = true;
		}

		private void btnCriarBinding_Click(object sender, System.EventArgs e)
		{
			string businessKey;
			//Obter o BusinessKey da empresa Activa
			businessKey = cmbEmpresas.SelectedItem.Value.Trim();
			
			//Registrar o servico
			Servicos servico = new Servicos();

			//Tem servicos ?
			if  (this.cmbServicos.Items.Count == 0) {
				servico.RegistrarServicoWeb(Session["token"].ToString(),businessKey,txtNome.Text,txtDescricao.Text,cmbTiposUrl.SelectedItem.Text, txtURLPontoAcesso.Text, txtDescricaoPAcesso.Text,cmbtModel.SelectedItem.Value,cmbtModel.SelectedItem.Text,txtURLDocPontoAcesso.Text,txtDocPontoAcesso.Text);

				//Mostra uma mensagem de alerta
				RegisterClientScriptBlock("MeuScript", "<script language=JavaScript>" +
					"alert('Serviço registado com sucesso.')</script>");
			}
			else {
				//Gravar o novo servico com a mensagem save service
				SerializadorXML sXML = new SerializadorXML();
				sXML.saveWebServiceSs(Session["token"].ToString(),businessKey,txtNome.Text,txtDescricao.Text,cmbTiposUrl.SelectedItem.Text, txtURLPontoAcesso.Text, txtDescricaoPAcesso.Text,cmbtModel.SelectedItem.Value,cmbtModel.SelectedItem.Text,txtURLDocPontoAcesso.Text,txtDocPontoAcesso.Text);

				//Mostra uma mensagem de alerta
				RegisterClientScriptBlock("MeuScript", "<script language=JavaScript>" +
					"alert('Serviço registado com sucesso.')</script>");

			}
		}


		/// <summary>
		/// Mostra os serviços web registrados numa empresa
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnVerServicos_Click(object sender, System.EventArgs e)
		{
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();
			

			this.cmbServicos.Items.Clear();

			string businessKey = cmbEmpresas.SelectedItem.Value.Trim();


			string resposta = sXML.findServiceKey(businessKey);
			serviceInfo[] sis = dsXML.findService(resposta);

			//Carregar os tmodels
			foreach (serviceInfo si in sis)
			{
				this.cmbServicos.Items.Add(si.name);
				//guarda o id
				this.cmbServicos.Items[cmbServicos.Items.Count-1].Value = si.serviceKey;
			}

		}

		private void btnAdicionar_Click(object sender, System.EventArgs e)
		{
			this.pnlDefinirPontos.Visible = true;
		}

	}
}
