using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Text;
using System.Net.Sockets;

namespace teste
{
	/// <summary>
	/// Summary description for SOAP.
	/// </summary>
	public class SOAP : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_findBusiness;
		private System.Windows.Forms.TextBox txtMensagem;
		private System.Windows.Forms.TextBox txtEmpresa;
		private System.Windows.Forms.Button btn_savebusiness;
		private System.Windows.Forms.Button btn_taxonomy;
		private System.Windows.Forms.Button btnCategorias;
		private System.Windows.Forms.Button updateBusiness;
		private System.Windows.Forms.Button btn_findTModel;
		private System.Windows.Forms.Button deleteBusiness;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SOAP()
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
			this.label1 = new System.Windows.Forms.Label();
			this.btn_findBusiness = new System.Windows.Forms.Button();
			this.txtMensagem = new System.Windows.Forms.TextBox();
			this.txtEmpresa = new System.Windows.Forms.TextBox();
			this.btn_savebusiness = new System.Windows.Forms.Button();
			this.btn_taxonomy = new System.Windows.Forms.Button();
			this.btnCategorias = new System.Windows.Forms.Button();
			this.updateBusiness = new System.Windows.Forms.Button();
			this.btn_findTModel = new System.Windows.Forms.Button();
			this.deleteBusiness = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(720, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mensagens SOAP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_findBusiness
			// 
			this.btn_findBusiness.Location = new System.Drawing.Point(248, 56);
			this.btn_findBusiness.Name = "btn_findBusiness";
			this.btn_findBusiness.Size = new System.Drawing.Size(96, 32);
			this.btn_findBusiness.TabIndex = 1;
			this.btn_findBusiness.Text = "find_business";
			this.btn_findBusiness.Click += new System.EventHandler(this.btn_findBusiness_Click);
			// 
			// txtMensagem
			// 
			this.txtMensagem.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.txtMensagem.Location = new System.Drawing.Point(16, 152);
			this.txtMensagem.Multiline = true;
			this.txtMensagem.Name = "txtMensagem";
			this.txtMensagem.Size = new System.Drawing.Size(776, 296);
			this.txtMensagem.TabIndex = 2;
			this.txtMensagem.Text = "";
			// 
			// txtEmpresa
			// 
			this.txtEmpresa.Location = new System.Drawing.Point(16, 64);
			this.txtEmpresa.Name = "txtEmpresa";
			this.txtEmpresa.Size = new System.Drawing.Size(224, 20);
			this.txtEmpresa.TabIndex = 3;
			this.txtEmpresa.Text = "";
			// 
			// btn_savebusiness
			// 
			this.btn_savebusiness.Location = new System.Drawing.Point(352, 56);
			this.btn_savebusiness.Name = "btn_savebusiness";
			this.btn_savebusiness.Size = new System.Drawing.Size(96, 32);
			this.btn_savebusiness.TabIndex = 4;
			this.btn_savebusiness.Text = "save_business";
			this.btn_savebusiness.Click += new System.EventHandler(this.btn_savebusiness_Click);
			// 
			// btn_taxonomy
			// 
			this.btn_taxonomy.Location = new System.Drawing.Point(584, 56);
			this.btn_taxonomy.Name = "btn_taxonomy";
			this.btn_taxonomy.Size = new System.Drawing.Size(96, 32);
			this.btn_taxonomy.TabIndex = 5;
			this.btn_taxonomy.Text = "taxonomy";
			this.btn_taxonomy.Click += new System.EventHandler(this.btn_taxonomy_Click);
			// 
			// btnCategorias
			// 
			this.btnCategorias.Location = new System.Drawing.Point(688, 56);
			this.btnCategorias.Name = "btnCategorias";
			this.btnCategorias.Size = new System.Drawing.Size(96, 32);
			this.btnCategorias.TabIndex = 6;
			this.btnCategorias.Text = "Categorias";
			this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
			// 
			// updateBusiness
			// 
			this.updateBusiness.Location = new System.Drawing.Point(464, 56);
			this.updateBusiness.Name = "updateBusiness";
			this.updateBusiness.Size = new System.Drawing.Size(104, 32);
			this.updateBusiness.TabIndex = 7;
			this.updateBusiness.Text = "update_business";
			this.updateBusiness.Click += new System.EventHandler(this.updateBusiness_Click);
			// 
			// btn_findTModel
			// 
			this.btn_findTModel.Location = new System.Drawing.Point(248, 96);
			this.btn_findTModel.Name = "btn_findTModel";
			this.btn_findTModel.Size = new System.Drawing.Size(96, 32);
			this.btn_findTModel.TabIndex = 8;
			this.btn_findTModel.Text = "find_tModel";
			this.btn_findTModel.Click += new System.EventHandler(this.btn_findTModel_Click);
			// 
			// deleteBusiness
			// 
			this.deleteBusiness.Location = new System.Drawing.Point(352, 96);
			this.deleteBusiness.Name = "deleteBusiness";
			this.deleteBusiness.Size = new System.Drawing.Size(96, 32);
			this.deleteBusiness.TabIndex = 9;
			this.deleteBusiness.Text = "delete_business";
			this.deleteBusiness.Click += new System.EventHandler(this.button1_Click);
			// 
			// SOAP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(808, 461);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.deleteBusiness,
																		  this.btn_findTModel,
																		  this.updateBusiness,
																		  this.btnCategorias,
																		  this.btn_taxonomy,
																		  this.btn_savebusiness,
																		  this.txtEmpresa,
																		  this.txtMensagem,
																		  this.btn_findBusiness,
																		  this.label1});
			this.Name = "SOAP";
			this.Text = "SOAP";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Pesquisa uma empresa
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_findBusiness_Click(object sender, System.EventArgs e)
		{
			string server = "localhost";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;
			
			string find_business_xml = "C:\\Inetpub\\wwwroot\\SiSTUDDI\\teste\\xml\\find_business.xml";
			string find_business;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(find_business_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			
			find_business = result;
			
			string nomeEmpresa = txtEmpresa.Text;
			
			//Substituir com o nome pretendido
			string s1 = find_business.Substring(0, find_business.IndexOf("<name>") + 6);
			string s2 = find_business.Substring(find_business.IndexOf("</name>"));
			find_business = s1 + nomeEmpresa + s2;

			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/inquiryapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + find_business.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				find_business +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
			txtMensagem.Text = strRetPage;
		}

		/// <summary>
		/// Cria uma empresa
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_savebusiness_Click(object sender, System.EventArgs e)
		{
			string server = "localhost";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;
			
			string save_business_xml = @"C:\Inetpub\wwwroot\SiSTUDDI\teste\SiSTUddi.xml.save_business.xml";
			string save_business;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(save_business_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			
			save_business = result;
			
			string nomeEmpresa = txtEmpresa.Text;

			//Substituir com o nome pretendido
			//string s1 = save_business.Substring(0, save_business.IndexOf("<name>") + 6);
			//string s2 = save_business.Substring(save_business.IndexOf("</name>"));
			//save_business = s1 + nomeEmpresa + s2;

			//Substituir o auth info
			//string authInfo = "db2admin";
			//s1 = save_business.Substring(0, save_business.IndexOf("<authInfo>") + 10);
			//s2 = save_business.Substring(save_business.IndexOf("</authInfo>"));
			//save_business = s1 + authInfo + s2; 


			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/publishapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + save_business.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				save_business +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
			txtMensagem.Text = strRetPage;
		}
		/// <summary>
		/// Criar uma taxonomia ficticia para classificação
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_taxonomy_Click(object sender, System.EventArgs e)
		{
			string server = "localhost";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;
			
			string create_tmodel_xml = @"C:\Inetpub\wwwroot\SiSTUDDI\teste\xml\create_tmodel.xml";
			string create_tmodel;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(create_tmodel_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			
			create_tmodel = result;
			
			//Substituir o auth info
			string authInfo = "db2admin";
			string s1 = create_tmodel.Substring(0, create_tmodel.IndexOf("<authInfo>") + 10);
			string s2 = create_tmodel.Substring(create_tmodel.IndexOf("</authInfo>"));
			create_tmodel = s1 + authInfo + s2; 


			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/publishapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + create_tmodel.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				create_tmodel +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
			txtMensagem.Text = strRetPage;
		}

		/// <summary>
		/// Cria uma classificacao ficticia
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCategorias_Click(object sender, System.EventArgs e)
		{
			string server = "localhost";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;
			
			string create_tmodel_xml = @"C:\Inetpub\wwwroot\SiSTUDDI\teste\xml\create_tmodelClass.xml";
			string create_tmodel;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(create_tmodel_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			
			create_tmodel = result;
			
			//Substituir o auth info
			string authInfo = "db2admin";
			string s1 = create_tmodel.Substring(0, create_tmodel.IndexOf("<authInfo>") + 10);
			string s2 = create_tmodel.Substring(create_tmodel.IndexOf("</authInfo>"));
			create_tmodel = s1 + authInfo + s2; 


			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/publishapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + create_tmodel.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				create_tmodel +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
			txtMensagem.Text = strRetPage;
		}

		/// <summary>
		/// Ponto de entrada da aplicacao.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new SOAP());
		}

		private void updateBusiness_Click(object sender, System.EventArgs e)
		{
			string server = "localhost";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;

			//Obter o business ja publicado

			string save_business_xml = @"C:\Inetpub\wwwroot\SiSTUDDI\teste\sistuddi.xml.save_business.xml";
			//string save_business_xml = @"C:\Inetpub\wwwroot\SiSTUDDI\teste\get_businessdetail.xml";
			string save_business;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(save_business_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			
			save_business = result;
			
			string nomeEmpresa = txtEmpresa.Text;

			//Substituir com o nome pretendido
			//string s1 = save_business.Substring(0, save_business.IndexOf("<name>") + 6);
			//string s2 = save_business.Substring(save_business.IndexOf("</name>"));
			//save_business = s1 + nomeEmpresa + s2;

			//Substituir o auth info
			//string authInfo = "db2admin";
			//s1 = save_business.Substring(0, save_business.IndexOf("<authInfo>") + 10);
			//s2 = save_business.Substring(save_business.IndexOf("</authInfo>"));
			//save_business = s1 + authInfo + s2; 


			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/publishapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + save_business.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				save_business +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);

			// remove os cabecalhos
			strRetPage = strRetPage.Remove(0,176);
			txtMensagem.Text = strRetPage;

			// Adicionar a informacao

			//enviar novamente



		}

		private void btn_findTModel_Click(object sender, System.EventArgs e)
		{
			string server = "sist.esdrm.pt";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;
			
			string find_tModel_xml = "C:\\Inetpub\\wwwroot\\SiSTUDDI\\teste\\xml\\find_tModel.xml";
			string find_tModel;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(find_tModel_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			
			find_tModel = result;
			
			string nomeTModel = txtEmpresa.Text;
			
			//Substituir com o nome pretendido
			string s1 = find_tModel.Substring(0, find_tModel.IndexOf("<name>") + 6);
			string s2 = find_tModel.Substring(find_tModel.IndexOf("</name>"));
			find_tModel = s1 + nomeTModel + s2;

			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/inquiryapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + find_tModel.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				find_tModel +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
			txtMensagem.Text = strRetPage;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			string server = "sist.esdrm.pt";
			// Define as variáveis e uma string para escrever para o servidor
			Encoding ASCII = Encoding.ASCII;
			
			string find_tModel_xml = "C:\\Inetpub\\wwwroot\\SiSTUDDI\\teste\\xml\\delete_business.xml";
			string find_tModel;			

			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(find_tModel_xml));
			string linha;
			//Para cada linha do ficheiro ler e adicionar a String resultante
			while ((linha = stream.ReadLine()) != null)
			{
				result = result + linha + "\r\n";
			}
			//Fecha o reader
			stream.Close();
			string businessKey = "3A9A2077-38BF-4EA3-BF97-2B3207FC2E49";
			find_tModel = result;
			//Need to replace dummy businessKey in delete_business with valid one.
			string s1 = find_tModel.Substring(0, find_tModel.IndexOf("<businessKey>") + 13);
			string s2 = find_tModel.Substring(find_tModel.IndexOf("</businessKey>"));
			find_tModel = s1 + businessKey + s2;
        			
			//string nomeTModel = txtEmpresa.Text;
			
			//Substituir com o nome pretendido
			//string s1 = find_tModel.Substring(0, find_tModel.IndexOf("<name>") + 6);
			//string s2 = find_tModel.Substring(find_tModel.IndexOf("</name>"));
			//find_tModel = s1 + nomeTModel + s2;

			//Enviar a mensagem
			string Get = "POST " + "/uddisoap/inquiryapi" + " HTTP/1.0\r\n" +
				"User-Agent: Sample UDDI agent\r\n" +
				"Content-Type: text/xml; charset=\"utf-8\"\r\n" +
				"Content-length: " + find_tModel.Length + "\r\n"	 + 
				"SOAPAction: " + "\"\"" + "\r\n" +
				"\r\n" +
				find_tModel +
				"\r\n";
							
			MessageBox.Show(Get);
			Byte[] ByteGet = ASCII.GetBytes(Get);
			Byte[] RecvBytes = new Byte[256];
			String strRetPage = null;
 
			// IPAddress e IPEndPoint representam para onde vai ser enviado
			// a mensagem SOAP
			// Obter o primeiro endereço ip atraves da resolucao DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Cria o Socket para enviar os dados via TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// liga ao host através IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Envia o POST para o host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Recebe a página de resposta 
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
			txtMensagem.Text = strRetPage;		
		}
	}
}

