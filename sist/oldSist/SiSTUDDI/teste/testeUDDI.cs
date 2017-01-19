using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Microsoft.Uddi;
using System.Xml;
using System.Xml.Serialization;

using System.Net;
using System.IO;
using System.Text;
using System.Net.Sockets;

namespace testes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
				if (components != null) 
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Dados Empresa";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 40);
			this.button2.TabIndex = 1;
			this.button2.Text = "Descrever Serviços";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(16, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(128, 40);
			this.button3.TabIndex = 2;
			this.button3.Text = "Enviar XML findBus";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(160, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 40);
			this.button4.TabIndex = 3;
			this.button4.Text = "HTTP Post";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(160, 64);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 40);
			this.button5.TabIndex = 4;
			this.button5.Text = "Socket";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button5,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "TesteUDDI";
			this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				// Configure for the site that are going to access
				Publish.Url = "http://localhost:9080/uddisoap/publishapi";
				Publish.User = "db2admin";
				Publish.Password = "radical";

				// Create an object to save a business
				SaveBusiness sb = new SaveBusiness();

				// Add a business entity and allocate a name
				sb.BusinessEntities.Add();
				sb.BusinessEntities[0].Names.Add("Uma empresa qualquer");

				// Add multi-language descriptions for the business
				sb.BusinessEntities[0].Descriptions.Add("en", " *** Business description in English *** ");
				sb.BusinessEntities[0].Descriptions.Add("fr", " *** Description d'affaires en français *** ");


				// Add contact details for relevant individuals
				sb.BusinessEntities[0].Contacts.Add();
				sb.BusinessEntities[0].Contacts[0].PersonName = "Jane Doe";
				sb.BusinessEntities[0].Contacts[0].UseType = "Web Developer";
				sb.BusinessEntities[0].Contacts[0].Addresses.Add("My Sort Code", "Work Address");
				sb.BusinessEntities[0].Contacts[0].Addresses[0].AddressLines.Add("1 My Street");
				sb.BusinessEntities[0].Contacts[0].Addresses[0].AddressLines.Add("My Town");
				sb.BusinessEntities[0].Contacts.Add("John Smith","CEO");

				// Send the prepared save business request
				BusinessDetail savedB = sb.Send();
    
				// Interpret the returned business detail to examine the allocated business key
				MessageBox.Show("Business: " + savedB.BusinessEntities[0].Names[0].Text + 
								"\n" + "Allocated key: " + savedB.BusinessEntities[0].BusinessKey,"Dados Enviados");
			}
			catch (UddiException ex){
				MessageBox.Show("UDDI exception: " + ex.Number + " - " + ex.Message);
			}
			catch (Exception ex) {
				MessageBox.Show("General exception: " + ex.Message);
			}		
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			//Fazer a serializacao do documento XML e enviar para o URL
			// Initialize the WebRequest.
			WebRequest myRequest = WebRequest.Create("http://localhost:9080/uddisoap/inquiryapi");

			string uriString;
			uriString = "http://localhost:9080/uddisoap/inquiryapi";

			//documento xml
			string postData = "<s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>"
							 +"<s:Body>"
							 +"<find_business generic='2.0' xmlns='urn:uddi-org:api_v2'>"
							 +"<name>%</name>"
							 +"</find_business>"
							 +"</s:Body>"
							 +"</s:Envelope>";
			// Apply ASCII encoding to obtain an array of bytes .
			byte[] postArray = Encoding.ASCII.GetBytes(postData);

			// Create a new WebClient instance.
			WebClient myWebClient = new WebClient();

			Console.WriteLine("Uploading to {0} ...",  uriString);                  
			Stream postStream = myWebClient.OpenWrite(uriString,"POST");
			try 
			{
				postStream.Write(postArray,0,postArray.Length);
			}
			catch(Exception ex) 
			{
				MessageBox.Show(ex.ToString());	
			}

			// Close the stream and release resources.
			postStream.Close();
			//Console.WriteLine("\nSuccessfully posted the data.");
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			string uriString;
			uriString = "http://localhost:9080/uddisoap/inquiryapi";

			// Create a new WebClient instance.
			WebClient myWebClient = new WebClient();

			string fileName = "C:\\tese\\prototipo\\sistuddi\\testes\\testes\\find_business.xml";

			Console.WriteLine("Uploading {0} to {1} ...",fileName,uriString);                  
			byte[] responseArray;
			try 
			{			 	
				// Upload the file to the URL using the HTTP 1.0 POST.
				responseArray = myWebClient.UploadFile(uriString,"POST",fileName);
				MessageBox.Show("\nResponse Received.The contents of the file uploaded are: \n{0}",Encoding.ASCII.GetString(responseArray));
			}
			catch (Exception ex) 
			{
				MessageBox.Show(ex.ToString());
			}
			// Decode and display the response.
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			string server = "localhost";
			//Sets up variables and a string to write to the server
			Encoding ASCII = Encoding.ASCII;
			
			string find_business_xml = "C:\\tese\\prototipo\\sistuddi\\testes\\testes\\find_business.xml";
			string find_business;			
			//Ler o conteudo do ficheiro
	
			string result = "";
			StreamReader stream = new StreamReader(File.OpenRead(find_business_xml));

			string linha;
            //For each line of the file, read it in and append it to the String result.
            while ((linha = stream.ReadLine()) != null)
            {
                result = result + linha + "\r\n";
            }
            //Close the BufferedReader
            stream.Close();
			
			find_business = result;
			
			string nomeEmpresa = "%";
			
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
 
			// IPAddress and IPEndPoint represent the endpoint that will
			//   receive the request.
			// Get the first IPAddress in the list using DNS.
			IPAddress hostadd = Dns.Resolve(server).AddressList[0];
			IPEndPoint EPhost = new IPEndPoint(hostadd, 9080);
 
			//Creates the Socket for sending data over TCP.
			Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
				ProtocolType.Tcp );
 
			// Connects to the host using IPEndPoint.
			s.Connect(EPhost);
			if (!s.Connected)
			{
				strRetPage = "Unable to connect to host";
			}
 
			// Sends the GET text to the host.
			s.Send(ByteGet, ByteGet.Length, SocketFlags.None);
 
			// Receives the page, looping until all bytes are received
			Int32 bytes = s.Receive(RecvBytes, RecvBytes.Length, 0);
			strRetPage = "Default HTML page on " + server + ":\r\n";
			strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
 
			MessageBox.Show(strRetPage);
			while (bytes > 0)
			{
				bytes = s.Receive(RecvBytes, RecvBytes.Length, SocketFlags.None);
				strRetPage = strRetPage + ASCII.GetString(RecvBytes, 0, bytes);
			}
			MessageBox.Show(strRetPage);
		}
	}
}
