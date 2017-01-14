using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using SiST.UddiAPI.UddiData;
using SiST.UddiAPI.UddiMensagem;

namespace SiST.UddiCliente
{
	/// <summary>
	/// Vou construir e formatar a mensagem para enviar
	/// ao servidor UDDI
	/// A resposta obtida vai ser tratada pelo deserializadorXML
	/// </summary>
	public class SerializadorXML
	{
		XmlSerializer serializa;
		Parametros param;

		public SerializadorXML()
		{
			param = new Parametros();
		}

		/// <summary>
		/// Obter o token
		/// </summary>
		/// <param name="user">Nome do user</param>
		/// <param name="pass">Password</param>
		/// <returns>O Token</returns>
		public authToken obterToken(string user, string pass)
		{
			get_authToken obtemAutorizacao = new get_authToken();
			obtemAutorizacao.userID = user;
			obtemAutorizacao.cred = pass;
			serializa = new XmlSerializer(typeof(get_authToken));
			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,obtemAutorizacao);
			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);
			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);
			
			DeserializadorXML dsXML = new DeserializadorXML();
			authToken token = dsXML.obterToken(resultado);
			return token;
		}


		/// <summary>
		/// Construir e formatar a mensagem find_business
		/// ao servidor UDDI
		/// </summary>
		/// <param name="name">string para pesquisar</param>
		/// <returns>Documento XML com o resultado</returns>
		public string findBusiness(string name)
		{
			find_business fb = new find_business();
			fb.name = name;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_business));

			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,fb);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			//xmlDoc.Load(param.ficheirosXml + "fb.xml");
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
            Mensagem msg = new Mensagem(strMensagem);
			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);
			return resultado;
		}


		/// <summary>
		/// Construir e formatar a mensagem find_business
		/// ao servidor UDDI
		/// </summary>
		/// <param name="name">string para pesquisar</param>
		/// <returns>Documento XML com o resultado</returns>
		public string findBusinesstModel(string tModel)
		{
			find_business fb = new find_business();
			SerializadorXML sXML = new SerializadorXML();
			DeserializadorXML dsXML = new DeserializadorXML();

			//Obter o tModelKey
			string doc = sXML.findtModel(tModel);
			tModelInfo[] tmis = dsXML.findtModel(doc);

			doc = sXML.gettModelDetail(tmis[0].tModelKey);
			tModelInfo tmi = new tModelInfo();
			tmi = dsXML.gettModelDetail(doc);

			keyedReference[] kr = new keyedReference[1];
			kr[0] = new keyedReference();
			kr[0].tModelKey = tmi.tModelKey;
			kr[0].keyValue = tmi.description;

			fb.categoryBag = kr;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_business));

			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,fb);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);
			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);
			return resultado;
		}


		/// <summary>
		/// Procurar serviços registrados numa businessKey
		/// para servidor UDDI
		/// </summary>
		/// <param name="businessKey">string para pesquisar</param>
		/// <returns>Documento XML com o resultado</returns>
		public string findServiceKey(string businessKey)
		{
			find_service fs = new find_service();
			fs.businessKey = businessKey;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_service));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,fs);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}


		/// <summary>
		/// Construir e formatar a mensagem find_service
		/// para servidor UDDI
		/// </summary>
		/// <param name="name">string para pesquisar</param>
		/// <returns>Documento XML com o resultado</returns>
		public string findServiceName(string nome, string businessKey)
		{
			find_service fs = new find_service();

			fs.businessKey = businessKey;
			fs.name = nome;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_service));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,fs);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}


		/// <summary>
		/// Construir e formatar a mensagem find_tModel
		/// para servidor UDDI
		/// </summary>
		/// <param name="name">string para pesquisar</param>
		/// <returns>Documento XML com o resultado</returns>
		public string findtModel(string nome)
		{
			find_tModel ftm = new find_tModel();
			ftm.name = nome;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(find_tModel));
			
			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,ftm);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}


		/// <summary>
		/// Construir e formatar a mensagem save_business
		/// para o servidor UDDI
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="be">Business entity para registrar</param>
		/// <returns>Estrutura XML com Resultado da operacao</returns>
		public string saveBusiness(string authInfo, businessEntity be)
		{
			save_business sb = new save_business();
			sb.authInfo = authInfo;
			sb.businessEntity = be;
			//Serializar o objecto para XML	
			serializa = new XmlSerializer(typeof(save_business));
			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,sb);
			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);

			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);
			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);
			return resultado;
		}


		/// <summary>
		/// Construir e formatar a mensagem save_service
		/// para registrar os webservices
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="bs">Business Service para registrar</param>
		/// <param name="businessKey">Business Key da empresa que se pretende registrar o serviço</param>
		/// 
		/// <returns>Estrutura XML com Resultado da operacao</returns>
		public string saveService(string authInfo, businessService bs)
		{
			save_service ss = new save_service();
			ss.authInfo = authInfo;
			ss.businessService = bs;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(save_service));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,ss);


			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);

			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}


		/// <summary>
		/// Criar uma classificacao de servicos fornecidos pela empresa
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="businessKey">Business Key da empresa que se pretende registrar o serviço</param>
		/// <param name="keyName">Designacao do codigo de classificacao ex. Hotel</param>
		/// <param name="keyValue">Codigo de classificacao ex. 90....</param>
		/// <param name="tModelKey">Codigo uuid: do tmodels</param>
		/// 
		/// <returns>Estrutura XML com Resultado da operacao</returns>
		public string saveService(string authInfo, string businessKey, string keyValue, string keyName, string tModelKey)
		{
			//Obtencao dos dados da empresa
			//Get Business Detail
			DeserializadorXML dsXML = new DeserializadorXML();
			SerializadorXML sXML = new SerializadorXML();
			string resultado = sXML.getBusinessDetail(businessKey);
			businessDetail bd = new businessDetail();
			bd = dsXML.getBusinessDetail(resultado);

			//Envio do businessService no businessDetail
			save_business sb = new save_business();
			businessEntity be = new businessEntity();
			
			//Adicionar o business detail a business entity
			be = bd.businessEntity[0];
			sb.authInfo = authInfo;

			//Determinar o numero de business services
			int tamanho = 0;
			if (be.categoryBag == null)
			{
				tamanho = 1;
			}
			else
			{
				tamanho = be.categoryBag.Length + 1;
			}
			//Obter os business services

			//Contruir o nome
			keyedReference[] kr = new keyedReference[tamanho];
			kr[tamanho-1] = new keyedReference();
			kr[tamanho-1].keyName = keyName;
			kr[tamanho-1].keyValue = keyValue;
			kr[tamanho-1].tModelKey = tModelKey;

            for (int i = 0; i < tamanho-1 ; i++)
			{
				kr[i] = be.categoryBag[i];	
			}
	
			be.categoryBag = kr;
			sb.businessEntity = be;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(save_business));

			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,sb);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}


		/// <summary>
		/// Construir e formatar a mensagem save_service
		/// para classificacao servicos/actividade empresa
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="businessKey">Business Key da empresa que se pretende registrar o web service</param>
		/// <param name="nomeServico">Nome do servico que se pretende registrar</param>
		/// <param name="descricaoServico">Descricao do servico que se pretende registrar</param>
		/// <param name="tModelKey">Identificacao do tModel para classificacao e identificacao DUNs, UNSPSC, ...</param>
		/// <param name="keyName">Descricao do codigo identificador ou actividade</param>
		/// <param name="keyValue">Codigo identificador to tipo de servico ou actividade</param>
		/// 
		/// <returns>Estrutura XML com Resultado da operacao</returns>
		public string saveService(string authInfo, string businessKey, string nomeServico, string descricaoServico, string keyName, string keyValue, string tModelKey)
		{
			//Obtencao dos dados da empresa
			//Get Business Detail
			DeserializadorXML dsXML = new DeserializadorXML();
			SerializadorXML sXML = new SerializadorXML();
			string resultado = sXML.getBusinessDetail(businessKey);
			businessDetail bd = new businessDetail();
			bd = dsXML.getBusinessDetail(resultado);

			//Envio do businessService no businessDetail
			save_business sb = new save_business();
			businessEntity be = new businessEntity();
			
			//Adicionar o business detail a business entity
			be = bd.businessEntity[0];
			sb.authInfo = authInfo;

			int tamanho = 0;
			if (be.categoryBag == null)
			{
				tamanho = 0;
			}
			else
			{
				tamanho = be.categoryBag.Length;
			}
			
			//Contruir o nome
			name[] nome = new name[1];
			nome[0] = new name();
			nome[0].Value = nomeServico;

			//Construir o category bag
			keyedReference[] categorybag = new keyedReference[1];
			categorybag[0] = new keyedReference();
			categorybag[0].keyName = keyName;
			categorybag[0].keyValue = keyValue;
			categorybag[0].tModelKey = tModelKey;

			//Obter as classificacoes
			keyedReference[] kr = new keyedReference[tamanho + 1];
			for (int i = 0; i < tamanho ; i++)
			{
				kr[i] = be.categoryBag[i];	
			}
			
			//Adicionar o novo elemento
			kr[tamanho] = categorybag[0];

			//Gravar o category bag
			be.categoryBag = kr;

			sb.businessEntity = be;


			//Gravar os business services

			//TODO:........

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(save_business));
			
			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,sb);


			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();

			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		
		/// <summary>
		/// Construir e formatar a mensagem save_business
		/// para classificacao servicos/actividade empresa
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="businessKey">Business Key da empresa que se pretende registrar o web service</param>
		/// <param name="nomeServico">Nome do serviço a registrar</param>
		/// <param name="descricaoServico">Descricao do servico registrado</param>
		/// <param name="tipoURL">Tipo de URL: http, mailto, etc..</param>
		/// <param name="pontoAcesso">URL ponto de acesso para o servico</param>
		/// <param name="descricaoPontoAcesso">Como utilizar o servico</param>
		/// <param name="tModelKey">tModelKey que indica que o servico a ser criada tem detalhes de implementacao especificado pelo o tModel que referencia.</param>
		/// <param name="descricaotModelKey">O Papel que tem o tModel na descricao do servico</param>
		/// <param name="txtDocPontoAcesso">Documento que descreve o servico</param>
		/// <param name="urlDocPontoAcesso">Url para o documento que descreve o servico</param>
		/// <returns>Estrutura XML com Resultado da operacao</returns>
		public string saveWebServiceSb(string authInfo, string businessKey, string nomeServico, string descricaoServico, string tipoURL, string pontoAcesso, string descricaoPontoAcesso, string tModelKey, string descricaotModelKey, string urlDocPontoAcesso, string txtDocPontoAcesso)
		{
			//Obtencao dos dados da empresa
			DeserializadorXML dsXML = new DeserializadorXML();
			SerializadorXML sXML = new SerializadorXML();
			string resultado = sXML.getBusinessDetail(businessKey);
			businessDetail bd = new businessDetail();
			bd = dsXML.getBusinessDetail(resultado);

			//Envio do businessService no businessDetail
			save_business sb = new save_business();
			businessEntity be = new businessEntity();
			//Adicionar o business detail a business entity
			be = bd.businessEntity[0];
			sb.authInfo = authInfo;
			
			int tamanho = 0;
			if (be.businessServices == null)
			{
				tamanho = 0;
			}
			else
			{
				tamanho = be.businessServices.Length;
			}

			businessService[] servicos = new businessService[tamanho+1];
			for (int i = 0; i < tamanho ; i++)
			{
				servicos[i] = be.businessServices[i];	
			}

			servicos[tamanho] = new businessService();
			//Contruir o nome
			name[] nome = new name[1];
			nome[0] = new name();
			nome[0].Value = nomeServico;
			servicos[tamanho].name = nome;

			//Construir a descricao do business service
			Description[] descricao = new Description[1];
			descricao[0] = new Description();
			descricao[0].Value = descricaoServico;
			servicos[tamanho].description = descricao;

			//Construir o access point;
			accessPoint ap = new accessPoint();
			ap = new accessPoint();
			ap.URLType = URLType.http;
			ap.Value = pontoAcesso;

			//Construir os bindings templates
			bindingTemplate[] pontosAcesso = new bindingTemplate[1];
			pontosAcesso[0] = new bindingTemplate();
			pontosAcesso[0].bindingKey = "";
			pontosAcesso[0].serviceKey = "";
			pontosAcesso[0].description = descricaoPontoAcesso;
			pontosAcesso[0].accessPoint = ap;

			tModelInstanceInfo[] tii = new tModelInstanceInfo[1];
			tii[0] = new tModelInstanceInfo();
			tii[0].tModelKey = tModelKey;
			tii[0].description = descricaotModelKey;
			//tii[0].instanceDetails.description = txtDocPontoAcesso;

			overviewDoc documento = new overviewDoc();
			documento.description = urlDocPontoAcesso;
			documento.overviewURL = txtDocPontoAcesso;
			instanceDetails detalhesInstancia = new instanceDetails();
			detalhesInstancia.overviewDoc = documento;
			tii[0].instanceDetails = detalhesInstancia;

			pontosAcesso[0].tModelInstanceDetails = tii;

			servicos[tamanho].serviceKey = "";
			servicos[tamanho].businessKey = businessKey;
			servicos[tamanho].name = nome;
			servicos[tamanho].description = descricao;
			servicos[tamanho].bindingTemplates = pontosAcesso;

			be.businessServices = servicos;
			sb.businessEntity = be;
			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(save_business));
			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,sb);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();

			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		
		/// <summary>
		/// Construir e formatar a mensagem save_service
		/// para classificacao servicos/actividade empresa
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="businessKey">Business Key da empresa que se pretende registrar o web service</param>
		/// <param name="nomeServico">Nome do serviço a registrar</param>
		/// <param name="descricaoServico">Descricao do servico registrado</param>
		/// <param name="tipoURL">Tipo de URL: http, mailto, etc..</param>
		/// <param name="pontoAcesso">URL ponto de acesso para o servico</param>
		/// <param name="descricaoPontoAcesso">Como utilizar o servico</param>
		/// <param name="tModelKey">tModelKey que indica que o servico a ser criada tem detalhes 
		/// de implementacao especificado pelo o tModel que referencia.</param>
		/// <param name="descricaotModelKey">O Papel que tem o tModel na descricao do servico</param>
		/// <param name="txtDocPontoAcesso">Documento que descreve o servico</param>
		/// <param name="urlDocPontoAcesso">Url para o documento que descreve o servico</param>
		/// <returns>Estrutura XML com Resultado da operacao</returns>
		public string saveWebServiceSs(string authInfo, string businessKey, string nomeServico, string descricaoServico, string tipoURL, string pontoAcesso, string descricaoPontoAcesso, string tModelKey, string descricaotModelKey, string urlDocPontoAcesso, string txtDocPontoAcesso)
		{
			DeserializadorXML dsXML = new DeserializadorXML();
			SerializadorXML sXML = new SerializadorXML();
			string resultado;
	

			//Ia aqui!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
			//Estruturar a mensagem de save service
			
			businessService bs = new businessService();
			//Contruir o nome
			name[] nome = new name[1];
			nome[0] = new name();
			nome[0].Value = nomeServico;
			bs.name = nome;

			//Construir a descricao do business service
			Description[] descricao = new Description[1];
			descricao[0] = new Description();
			descricao[0].Value = descricaoServico;
			bs.description = descricao;

			//Construir o access point;
			accessPoint ap = new accessPoint();
			ap = new accessPoint();
			ap.URLType = URLType.http;
			ap.Value = pontoAcesso;

			//Construir os bindings templates
			bindingTemplate[] pontosAcesso = new bindingTemplate[1];
			pontosAcesso[0] = new bindingTemplate();
			pontosAcesso[0].bindingKey = "";
			pontosAcesso[0].serviceKey = "";
			pontosAcesso[0].description = descricaoPontoAcesso;
			pontosAcesso[0].accessPoint = ap;

			tModelInstanceInfo[] tii = new tModelInstanceInfo[1];
			tii[0] = new tModelInstanceInfo();
			tii[0].tModelKey = tModelKey;
			tii[0].description = descricaotModelKey;
			//tii[0].instanceDetails.description = txtDocPontoAcesso;

			overviewDoc documento = new overviewDoc();
			documento.description = urlDocPontoAcesso;
			documento.overviewURL = txtDocPontoAcesso;
			instanceDetails detalhesInstancia = new instanceDetails();
			detalhesInstancia.overviewDoc = documento;
			tii[0].instanceDetails = detalhesInstancia;

			pontosAcesso[0].tModelInstanceDetails = tii;

			bs.serviceKey = "";
			bs.businessKey = businessKey;
			bs.name = nome;
			bs.description = descricao;
			bs.bindingTemplates = pontosAcesso;

			//Serializar o objecto para XML
			
			return resultado = this.saveService(authInfo,bs);
		}

	
		/// <summary>
		/// Construir a mensagem save_tModel
		/// </summary>
		/// <param name="authInfo">Username para registrar</param>
		/// <param name="nome">Nome do tModel</param>
		/// <param name="descricao">Descricao do tModel</param>
		/// <param name="tModelKey">Identificação do tModel</param>
		/// <param name="docDescricao">Descrição do tModel</param>
		/// <param name="docURL">URL com a descricão do tModel</param>
		/// <returns>Estrutura XML com o resultado da operacao</returns>
		public string savetModel(string authInfo, string nome, string descricao, string tModelKey, string docDescricao, string docURL)
		{
			string resultado;
			save_tModel stm = new  save_tModel();
			stm.authInfo = authInfo;

			tModel tm = new tModel();
			tm.tModelKey = tModelKey;
			tm.name = nome;
			tm.description = descricao;
			
			overviewDoc doc = new overviewDoc();
			doc.description = docDescricao;
			doc.overviewURL = docURL;
			tm.overviewDoc = doc;
		
			stm.tModel = tm; //Guardar a estrutura do tModel

			//Serializar o objecto para XML	
			serializa = new XmlSerializer(typeof(save_tModel));
			MemoryStream memStream = new MemoryStream();
			serializa.Serialize(memStream,stm);
			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);

			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();
			Mensagem msg = new Mensagem(strMensagem);
			//Enviar Para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);
			return resultado;	
		}


		/// <summary>
		/// Eliminar a empresa
		/// </summary>
		/// <param name="authInfo">token</param>
		/// <param name="businessKey">Identificacao da empresa a eliminar</param>
		/// <returns>Estrutura XML com o resultado da operacao</returns>
		public string deleteBusiness(string authInfo, string businessKey)
		{
			string resultado;
			delete_business db = new delete_business();
			db.authInfo = authInfo.Trim();
			db.businessKey = businessKey.Trim();

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(delete_business));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,db);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(false,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		/// <summary>
		/// Eliminar o servico
		/// </summary>
		/// <param name="authInfo">token</param>
		/// <param name="serviceKey">Identificacao do servico</param>
		public string deleteService(string authInfo, string serviceKey)
		{
			string resultado;
			delete_service db = new delete_service();
			db.authInfo = authInfo;
			db.serviceKey = serviceKey;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(delete_service));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,db);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		/// <summary>
		/// Construir a mensagem eliminar o tModel
		/// </summary>
		/// <param name="tModelKey">Identificacao do tModel a eliminar</param>
		/// <returns></returns>
		public string deletetModel(string authInfo, string tModelKey)
		{
			string resultado;

			delete_tModel dtm = new delete_tModel();
			dtm.authInfo = authInfo;
			dtm.tModelKey = tModelKey;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(delete_tModel));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,dtm);

			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar para o servidor
			Router router = new Router();
			resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		/// <summary>
		/// Construir e formatar a mensagem get_businessDetail
		/// </summary>
		/// <param name="businessKey">Business Key da empresa que se pretende obter os resultados</param>
		public string getBusinessDetail(string businessKey)
		{
			get_businessDetail gbd = new get_businessDetail();
			gbd.businessKey = businessKey;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(get_businessDetail));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,gbd);
			
			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		/// <summary>
		/// Construir e formatar a mensagem get_serviceDetail
		/// </summary>
		/// <param name="serviceKey">serviceKey de que se pretende obter os resultados</param>
		public string getServiceDetail(string serviceKey)
		{
			get_serviceDetail gsd = new get_serviceDetail();
			gsd.serviceKey = serviceKey;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(get_serviceDetail));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,gsd);
			
			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

		public string gettModelDetail(string tModelKey)
		{
			
			get_tModelDetail gtd = new get_tModelDetail();
			gtd.tModelKey = tModelKey;

			//Serializar o objecto para XML
			serializa = new XmlSerializer(typeof(get_tModelDetail));

			MemoryStream memStream = new MemoryStream();

			serializa.Serialize(memStream,gtd);
			
			//Construir envelope
			XmlDocument xmlDoc = new XmlDocument();
			memStream.Seek(0,0);
			TextReader tr = new StreamReader(memStream);
			string strMensagem = tr.ReadToEnd();

			Mensagem msg = new Mensagem(strMensagem);

			//Enviar Para o servidor
			Router router = new Router();
			string resultado = router.EnviarStr(true,msg.mensagem,msg.tamanhoMensagem);

			return resultado;
		}

	}

} 
