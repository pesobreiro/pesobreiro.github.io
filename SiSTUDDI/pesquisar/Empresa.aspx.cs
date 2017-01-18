using System;
using System.Xml;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

//Meu UDDI
using SiST.UddiCliente;
using SiST.UddiAPI;
using SiST.UddiAPI.UddiMensagem;
using SiST.UddiAPI.UddiData;

namespace SiSTUddi.pesquisar
{
	/// <summary>
	/// Permite a pesquisa de organizações pelo nome no 
	/// UDDI.
	/// </summary>
	public class Empresa : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Table tblLista;
		protected System.Web.UI.WebControls.Label lblMensagem;

		//public static string PesquisaNome
		//{
		//}
		public Empresa()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			NameValueCollection qstr=Request.QueryString;
			string empresaId = qstr.Get("id");
			
			//Obter as empresas na categoria
			this.CarregarEmpresas(empresaId);
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
			this.ID = "Pesquisar";
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion


		private void CarregarEmpresas(string businessKey)
		{
			//Determinar o nome da empresa
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();
			string resultado = sXML.getBusinessDetail(businessKey);
			businessDetail bd = dsXML.getBusinessDetail(resultado);

			TableRow r = new TableRow();
        
			TableCell c = new TableCell();

			c.Controls.Add(new LiteralControl("<p class='TituloTabela'>" + bd.businessEntity[0].name[0].Value + "</p>"));
			c.Controls.Add(new LiteralControl("<p class='TextoNormal'><b>BusinessKey:</b>" + bd.businessEntity[0].businessKey + "<br>"));

			if (bd.businessEntity[0].description == null)
			{
				c.Controls.Add(new LiteralControl("<b>Descricao: N&atilde;o d&iacute;sponivel</b><br>"));
			}
			else
			{
				c.Controls.Add(new LiteralControl("<b>Descricao:</b>" + bd.businessEntity[0].description[0].Value.ToString() + "<br>"));
			}

			//Contactos
			if (bd.businessEntity[0].contacts == null)
			{
				c.Controls.Add(new LiteralControl("<b>Contactos: N&atilde;o d&iacute;sponivel</b><br>"));
			}
			else 
			{
				c.Controls.Add(new LiteralControl("<b>Contactos:</b><br>"));
				foreach ( contact contacto in bd.businessEntity[0].contacts)
				{
					c.Controls.Add(new LiteralControl("Tipo:" + contacto.useType + "<br>"));
					c.Controls.Add(new LiteralControl("Nome:" + contacto.personName + "<br>"));
					c.Controls.Add(new LiteralControl("Morada:" + contacto.address + "<br>"));
					c.Controls.Add(new LiteralControl("Obs:" + contacto.description + "<br>"));
					c.Controls.Add(new LiteralControl("Telefone:" + contacto.phone + "<br>"));
					c.Controls.Add(new LiteralControl("email:" + contacto.email + "<br>"));
				}
			}

			//Outros servicos
			if (bd.businessEntity[0].categoryBag == null)
			{
				c.Controls.Add(new LiteralControl("<b>Outros serviços: N&atilde;o d&iacute;sponivel</b><br>"));
			}
			else
			{
				c.Controls.Add(new LiteralControl("<b>Outros serviços:</b><br>"));
				foreach ( keyedReference kr in bd.businessEntity[0].categoryBag)
				{
					c.Controls.Add(new LiteralControl("Tipo:" + kr.keyValue + "&#x0009;Nome:" + kr.keyName + "<br>"));
				}
			}
			//Linha em branco
			c.Controls.Add(new LiteralControl("<br>"));

			r.Cells.Add(c);
			this.tblLista.Rows.Add(r);
		}
	}
}