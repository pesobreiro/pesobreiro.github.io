using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace teste
{
	/// <summary>
	/// Summary description for Serializar.
	/// </summary>
	public class Serializar : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnSerializar;
		private System.Windows.Forms.TextBox txtMensagem;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Serializar()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSerializar = new System.Windows.Forms.Button();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnSerializar
			// 
			this.btnSerializar.Location = new System.Drawing.Point(240, 256);
			this.btnSerializar.Name = "btnSerializar";
			this.btnSerializar.Size = new System.Drawing.Size(104, 32);
			this.btnSerializar.TabIndex = 0;
			this.btnSerializar.Text = "Serializar";
			this.btnSerializar.Click += new System.EventHandler(this.btnSerializar_Click);
			// 
			// txtMensagem
			// 
			this.txtMensagem.Location = new System.Drawing.Point(16, 16);
			this.txtMensagem.Multiline = true;
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(568, 224);
			this.txtMensagem.TabIndex = 1;
			this.txtMensagem.Text = "";
			// 
			// Serializar
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(600, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.txtMensagem,
																		  this.btnSerializar});
			this.Name = "Serializar";
			this.Text = "Serializar";
			this.ResumeLayout(false);

		}
		#endregion

		private void MostrarXML()
		{
			TextReader tr = new StreamReader(@"c:\teste.xml");
			string result = "";
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = tr.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			tr.Close();

			txtMensagem.Text = result;

		}
		private void btnSerializar_Click(object sender, System.EventArgs e)
		{
			//Construcao da objecto serializado
			find_business fb = new find_business();
			fb.name = "xico";

			XmlSerializer serializer = new XmlSerializer(typeof(find_business));
			
			//Não vou gravar um ficheiro
			TextWriter gravatexto = new StreamWriter(@"c:\teste.xml");
		
			serializer.Serialize(gravatexto,fb);
			//Gravei isto!!
			/*  <?xml version="1.0" encoding="utf-8" ?> 
				<find_business xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns="urn:uddi-org:api_v2">
					<name>xico</name> 
				</find_business> */

			gravatexto.Close();


			//Tenho de criar isto !!!
			/*	<s:Envelope xmlns:s="http://schemas.xmlsoap.org/soap/envelope/">
					<s:Body>  
						<find_business generic="2.0" xmlns="urn:uddi-org:api_v2">    
							<name>%</name>  
						</find_business>
					</s:Body>
				</s:Envelope> */

			//Adicionar o formato SOAP
			TextReader tr = new StreamReader(@"c:\teste.xml");
			string result = "";
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante

			//Vou passar a primeira linha
			result = @"<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>" + "\r\n";
			result = result + @"<s:Body>" +"\r\n";
			tr.ReadLine();
			while ((linha = tr.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			result = result + @"</s:Body>" + "\r\n";
			result = result + @"</s:Envelope>";
			//Fecha o reader
			tr.Close();

			//Gravar as alterações
			gravatexto = new StreamWriter(@"c:\teste.xml");
			gravatexto.Write(result);
			gravatexto.Close();

			MostrarXML();

		}
/*		static void Main()
		{
			Application.Run(new Serializar());
		}*/

	}
}
