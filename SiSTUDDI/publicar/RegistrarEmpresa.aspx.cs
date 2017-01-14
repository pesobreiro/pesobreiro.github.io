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
	public class RegistrarEmpresa : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlConteudo;
		protected System.Web.UI.WebControls.Panel pnlLoginSemSucesso;
		protected System.Web.UI.WebControls.LinkButton btnTeste;
		protected System.Web.UI.WebControls.Panel pnlPublicarTaxonomias;
		protected System.Web.UI.HtmlControls.HtmlForm login;
		protected System.Web.UI.WebControls.TextBox txtNome;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvNome;
		protected System.Web.UI.WebControls.TextBox txtDescricao;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvDescricao;
		protected System.Web.UI.WebControls.TextBox txtContacto;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvContacto;
		protected System.Web.UI.WebControls.TextBox txtFuncaoContacto;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvFuncaoContacto;
		protected System.Web.UI.WebControls.Button btnRegistrarEmpresa;
		protected System.Web.UI.WebControls.Label lblErro;
		protected System.Web.UI.WebControls.Panel pnlErro;
		protected System.Web.UI.WebControls.RequiredFieldValidator rfvClassificacao;
		protected System.Web.UI.WebControls.DropDownList cmbRegiao;
		protected System.Web.UI.WebControls.Label lblMensagem;
		protected System.Web.UI.WebControls.LinkButton Linkbutton1;
	
		private void Page_Load(object sender, System.EventArgs e){
			string scriptString = "<script language=JavaScript> function DoClick() {";
			scriptString += "alert('Here is my message');}</script>";

			if(!this.IsClientScriptBlockRegistered("clientScript"))
				this.RegisterClientScriptBlock("clientScript", scriptString);
		


			try{
				if (Session["nome_user"].ToString() != null){
					pnlLoginSemSucesso.Visible = false;
					pnlConteudo.Visible = true;

					this.CarregartModels();
				}
				else { 
					pnlLoginSemSucesso.Visible = true;
					pnlConteudo.Visible = false;
				}
			}
			catch (Exception ex){
				pnlLoginSemSucesso.Visible = true;
				pnlConteudo.Visible = false;
			}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{  
			this.btnRegistrarEmpresa.Init += new System.EventHandler(this.btnRegistrarEmpresa_Init);
			this.btnRegistrarEmpresa.Click += new System.EventHandler(this.btnRegistrarEmpresa_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		/// <summary>
		/// Carrega os tModels disponiveis na combobox
		/// </summary>
		private void CarregartModels()
		{
			int seleccionado = this.cmbRegiao.SelectedIndex;

			//Carregar a combobox com os tModels
			this.cmbRegiao.Items.Clear();

			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();

			string resultado = sXML.findtModel("distritos%"); //Obtem os tModels
			tModelInfo[] tmis = dsXML.findtModel(resultado);
			//Carregar os tmodels
			foreach (tModelInfo tmi in tmis)
			{
				cmbRegiao.Items.Add(tmi.name);
				//guarda o id
				cmbRegiao.Items[cmbRegiao.Items.Count-1].Value = tmi.tModelKey;
			}
			this.cmbRegiao.SelectedIndex = seleccionado;
		}



		private void btnRegistrarEmpresa_Click(object sender, System.EventArgs e)
		{
			//Determinar o Utilizador
			int id_User = System.Convert.ToInt16(Session["id_user"]);
			//Obter os dados do tModel
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();

			string resultado = sXML.gettModelDetail(cmbRegiao.SelectedItem.Value); //Obtem os tModels

			tModelInfo tmi = dsXML.gettModelDetail(resultado);

			//Vou Adicionar a empresa ao Servidor
			PublicarEmpresa publicarEmpresa = new PublicarEmpresa();
			publicarEmpresa.Registrar(id_User,Session["token"].ToString(),this.txtNome.Text, this.txtDescricao.Text, this.txtContacto.Text, this.txtFuncaoContacto.Text,tmi.name,tmi.description,tmi.tModelKey);

			//Registrar o tModel da empresa
			this.lblErro.Text = "Empresa registrada";

			//Mostra uma mensagem de alerta
			RegisterClientScriptBlock("MeuScript", "<script language=JavaScript>" +
												   "alert('Empresa " +txtNome.Text+ " registada com sucesso.')</script>");
			//Limpar
			this.txtNome.Text = "";
			this.txtDescricao.Text = "";
			this.txtContacto.Text = "";
			this.txtFuncaoContacto.Text = "";

			//Response.Redirect("index.aspx");
		}

		private void btnRegistrarEmpresa_Init(object sender, System.EventArgs e)
		{
			this.lblMensagem.Text = "Entrei!!!!!!!!!!!!!!!!!";
			this.btnRegistrarEmpresa.Attributes.Add("onclick", "return confirm (\"Tem a certeza?\");");
		}

	}
}
