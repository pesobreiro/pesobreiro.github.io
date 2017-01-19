using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Summary description for index.
	/// </summary>
	public class index : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlConteudo;
		protected System.Web.UI.WebControls.Panel pnlLoginSemSucesso;
		protected System.Web.UI.WebControls.LinkButton btnTeste;
		protected System.Web.UI.WebControls.Panel pnlPublicarTaxonomias;
		protected System.Web.UI.WebControls.LinkButton lbtnTaxonomias;
		protected System.Web.UI.HtmlControls.HtmlForm login;
		protected System.Web.UI.WebControls.LinkButton lbl;
		protected System.Web.UI.WebControls.Panel pnlRegistrarUser;
		protected System.Web.UI.WebControls.LinkButton Linkbutton1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			try
			{
				if (Session["user"].ToString() != null)
				{
					pnlLoginSemSucesso.Visible = false;
					pnlConteudo.Visible = true;
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
			this.lbtnTaxonomias.Click += new System.EventHandler(this.lbtnTaxonomias_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Serializador s = new Serializador();
		}

		private void lbtnTaxonomias_Click(object sender, System.EventArgs e)
		{
			this.pnlPublicarTaxonomias.Visible = true;
		}

	}
}
