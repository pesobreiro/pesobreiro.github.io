using System;
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

using SiST;
using SiST.UddiCliente;
using SiST.UddiAPI;
using SiST.UddiAPI.UddiMensagem;
using SiST.UddiAPI.UddiData;

namespace SiSTPortal
{
	/// <summary>
	/// Summary description for categorias.
	/// </summary>
	public class zona : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Table tblLista;
		protected System.Web.UI.WebControls.Panel pnlLista;
		private void Page_Load(object sender, System.EventArgs e)
		{
			NameValueCollection qstr=Request.QueryString;
			string categoriaId = qstr.Get("id");
			
			//Obter as empresas na categoria
			this.CarregarEmpresas(categoriaId);
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void CarregarEmpresas(string categoriaId)
		{
			//Carregar a combobox com as empresas registradas
			Empresa empresa = new Empresa();

			//Colocar num datatable
			businessEntity[] bes = empresa.obterEmpresastModel(categoriaId);

			//verificar se existem empresas nesta categoria
			if (bes.Length == 0)
			{
				TableRow r = new TableRow();
				TableCell c = new TableCell();

				c.Controls.Add(new LiteralControl("<p class='TituloTabela' align='center'>Não existem empresas nesta zona!</p>"));

				r.Cells.Add(c);
				this.tblLista.Rows.Add(r);
			}
			else {
				//Carregar as empresas
				foreach ( businessEntity be in bes)
				{
					TableRow r = new TableRow();
                
					TableCell c = new TableCell();

					businessDetail bd = empresa.ObterDetalhe(be.businessKey);
				
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
	}
}
