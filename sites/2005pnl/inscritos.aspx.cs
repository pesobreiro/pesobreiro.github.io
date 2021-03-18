using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace pnl
{
	/// <summary>
	/// Summary description for inscritos.
	/// </summary>
	public class inscritos : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.DataGrid DataGridLista;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			
			OdbcConnection ligacaoOdbc = new OdbcConnection("dsn=pnl2005");
			ligacaoOdbc.Open();
			OdbcDataAdapter daOdbc = new OdbcDataAdapter("Select * from inscricao",ligacaoOdbc);
			DataSet ds = new DataSet();
			daOdbc.Fill(ds,"inscricao");
			DataGridLista.DataSource = ds;
			DataGridLista.DataBind();	

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
	}
}
