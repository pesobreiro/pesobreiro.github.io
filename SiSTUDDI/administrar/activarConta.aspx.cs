using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace SiSTUddi.administrar
{
	/// <summary>
	/// Ve o parametro e activa a conta
	/// </summary>
	public class activarConta : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Panel pnlSucesso;
		protected System.Web.UI.WebControls.Label lblMensagem;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			;
			//DataRow dr;
			DataSet ds;

			//Vou inspeccionar a query string 
			NameValueCollection qstr=Request.QueryString;
			string userName = qstr.Get("user");

			//Actualizar o estado do utilizador
			string cmdSQL = "select * from Utilizador where Utilizador_Username ='" + userName + "'";

			SqlDataAdapter dataAdapter = new SqlDataAdapter(cmdSQL, Parametros.strConexaoBD);
			SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(dataAdapter);

			ds = new DataSet("myDs");
			dataAdapter.Fill(ds, "Utilizador"); //Cria uma datatable User
			DataTable dataTableUser = ds.Tables["Utilizador"];

			DataRow dr = dataTableUser.Rows[0];
			dr["Utilizador_Activo"] = true;

			// Update SqlServer
			try
			{
				dataAdapter.Update(ds, "Utilizador");
			}
			catch (SqlException  ex)
			{
				lblMensagem.Text = ex.ToString();
				//dataAdapter.
			}

			string caminho = Request.ApplicationPath;

			Response.AppendHeader("refresh","10; URL=../Administrar/login.aspx?origem=publicar");

			Response.Redirect(caminho + "/Administrar/login.aspx?origem=publicar");
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
