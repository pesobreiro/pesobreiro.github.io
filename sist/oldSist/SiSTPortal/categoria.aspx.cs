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

namespace SiSTPortal
{
	/// <summary>
	/// Summary description for categorias.
	/// </summary>
	public class categoria : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Table tblLista;
		protected System.Web.UI.WebControls.Panel pnlLista;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			DataTable dt = empresa.ObterEmpresas(categoriaId);
			//Carregar as empresas
			foreach ( DataRow dataRow in dt.Rows)
			{
				TableRow r = new TableRow();
                
				TableCell c = new TableCell();
				c.Controls.Add(new LiteralControl("<p>" + dataRow["EmpClass_Empresa_ID"].ToString() + "</p>"));
				r.Cells.Add(c);
                this.tblLista.Rows.Add(r);
			}
		}
	}
}
