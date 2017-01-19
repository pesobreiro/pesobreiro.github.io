using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
//
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using teste;

namespace SiSTUDDI.administrar
{
	/// <summary>
	/// Summary description for SerializacaoSOAP.
	/// </summary>
	public class SerializacaoSOAP : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtTexto;
		private System.Windows.Forms.Button btnEnviar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SerializacaoSOAP()
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
			this.txtTexto = new System.Windows.Forms.TextBox();
			this.btnEnviar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTexto
			// 
			this.txtTexto.Location = new System.Drawing.Point(16, 16);
			this.txtTexto.Multiline = true;
			this.txtTexto.Name = "txtTexto";
			this.txtTexto.Size = new System.Drawing.Size(520, 192);
			this.txtTexto.TabIndex = 0;
			this.txtTexto.Text = "";
			// 
			// btnEnviar
			// 
			this.btnEnviar.Location = new System.Drawing.Point(216, 224);
			this.btnEnviar.Name = "btnEnviar";
			this.btnEnviar.TabIndex = 1;
			this.btnEnviar.Text = "Enviar";
			this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
			// 
			// SerializacaoSOAP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 269);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnEnviar,
																		  this.txtTexto});
			this.Name = "SerializacaoSOAP";
			this.Text = "SerializacaoSOAP";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnEnviar_Click(object sender, System.EventArgs e)
		{
/*			bool isValid = true;

			XmlTextReader xml = new XmlTextReader("find_business_xml.xml");
			XmlValidatingReader xsd = new XmlValidatingReader(xml);
			xsd.ValidationType = ValidationType.Schema;

			while (xsd.Read())
			{
			}
			xsd.Close();

			if (isValid)
				txtTexto.Text = "Document is valid";
			else
				txtTexto.Text = "Document is invalid";

*/

			// Validar o documento XML

			XmlValidatingReader myXmlValidatingReader = null;
			XmlTextReader myXmlTextReader = null;

			txtTexto.Text = ("Validation XML file booksSchema.xml with schema file schema.xsd ...");
			myXmlTextReader = new XmlTextReader ("find_business_xml.xml");
			myXmlValidatingReader = new XmlValidatingReader(myXmlTextReader);


			XmlSchemaCollection myXmlSchemaCollection = new XmlSchemaCollection();


			myXmlValidatingReader.Schemas.Add(myXmlSchemaCollection);
			myXmlValidatingReader.ValidationType = ValidationType.Schema;
			
			
			try
			{
				// Read XML data
				while (myXmlValidatingReader.Read()){}
				txtTexto.Text = "Validation finished";
			}
			catch (XmlException xmlex)
			{
				txtTexto.Text = "XmlException: " + xmlex.ToString();
			}

			catch (Exception ex)
			{
				txtTexto.Text = "Exception: " + ex.ToString();
			}




			XmlSerializer serializer = new XmlSerializer(typeof(businessEntity));

			TextReader reader = new StreamReader("find_business_xml.xml");
			businessEntity po;
			try
			{
				po = (businessEntity)serializer.Deserialize(reader);
				reader.Close();

				TextWriter writer = new StreamWriter("PurchaseOrder2.xml");
				serializer.Serialize(writer, po);
				writer.Close();
			}
			catch(XmlException xmlex)
			{
				txtTexto.Text = "XmlException: " + xmlex.ToString();
			}
			catch (Exception ex)
			{
				txtTexto.Text = "Exception: " + ex.ToString();
			}


		}

/*		static void Main()
		{
			Application.Run(new SerializacaoSOAP());
		}*/
	}
}