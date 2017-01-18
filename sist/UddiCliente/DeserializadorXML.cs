// Static Model
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using SiST.UddiAPI.UddiMensagem;
using SiST.UddiAPI.UddiData;


namespace SiST.UddiCliente
{

	public class DeserializadorXML
	{
		Parametros param;
		/// <summary>
		/// Inicializacao do Deserializador XML
		/// </summary>
		public DeserializadorXML()
		{
			param = new Parametros();
		}

		/// <summary>
		/// Tratamento da estrutura do contacto
		/// </summary>
		/// <param name="no">ArrayList com os contactos</param>
		/// <returns>Array</returns>
		public ArrayList TratarContactos(XmlNode no)	
		{
			//Contacts
			ArrayList arrayContactos = new ArrayList();


			foreach (XmlNode noContacto in no.ChildNodes)
			{
				contact contacto = new contact();
				contacto.useType = noContacto.Attributes["useType"].InnerText;
				foreach (XmlNode cadaContacto in noContacto.ChildNodes)
				{
					switch ( cadaContacto.Name)
					{
						case "description":
							contacto.description = cadaContacto.InnerText;
							break;

						case "personName":
							contacto.personName = cadaContacto.InnerText;
							break;
										
						case "phone":
							contacto.phone = cadaContacto.InnerText;
							break;
										
						case "email":
							contacto.email = cadaContacto.InnerText;
							break;
										
						case "address":
							foreach (XmlNode morada in cadaContacto.ChildNodes)
							{
								contacto.address = morada.InnerText;
							}
							break;
					}
				}
				arrayContactos.Add(contacto);
			}
			return arrayContactos;
		}


		/// <summary>
		/// Tratamento da estrutura bindingTemplates
		/// </summary>
		/// <param name="no">ArrayList com os bindingTemplates</param>
		/// <returns>Array</returns>
		public ArrayList TratarBindingTemplates(XmlNode no)	
		{
			//Contacts
			ArrayList arrayBindingTemplates = new ArrayList();
			bindingTemplate bt = new bindingTemplate();

			foreach (XmlNode noBindingTemplate in no.ChildNodes)
			{
				bt.bindingKey = noBindingTemplate.Attributes["bindingKey"].InnerText;
				bt.serviceKey = noBindingTemplate.Attributes["serviceKey"].InnerText;

				foreach (XmlNode cadaBindingTemplate in noBindingTemplate.ChildNodes)
				{
					switch ( cadaBindingTemplate.Name)
					{
						case "description":
							bt.description = cadaBindingTemplate.InnerText;
							break;

						case "accessPoint":
							accessPoint pontoAcesso = new accessPoint();
							pontoAcesso.Value = cadaBindingTemplate.InnerText;
							switch (cadaBindingTemplate.Attributes["URLType"].InnerText)
							{
								case "fax":
									pontoAcesso.URLType = URLType.fax;
									break;
								case "ftp":
									pontoAcesso.URLType = URLType.ftp;
									break;
								case "http":
									pontoAcesso.URLType = URLType.http;
									break;
								case "https":
									pontoAcesso.URLType = URLType.https;
									break;
								case "mailto":
									pontoAcesso.URLType = URLType.mailto;
									break;
								case "other":
									pontoAcesso.URLType = URLType.other;
									break;
								case "phone":
									pontoAcesso.URLType = URLType.phone;
									break;
							}
							bt.accessPoint = pontoAcesso;
							break;

						case "tModelInstanceDetails":

							ArrayList arraytModelInstanceInfo = new ArrayList();
							foreach (XmlNode notModelInstanceInfo in cadaBindingTemplate.ChildNodes)
							{
								tModelInstanceInfo tModelInstance = new tModelInstanceInfo();
								//cada tModelInstanceInfo
								tModelInstance.tModelKey   = notModelInstanceInfo.Attributes["tModelKey"].InnerText;

								foreach (XmlNode cadaInstanceInfo in notModelInstanceInfo.ChildNodes)
								{
									// cada elemento tModelInstanceInfo
									switch (cadaInstanceInfo.Name)
									{
										case "description":
											tModelInstance.description = cadaInstanceInfo.InnerText;
											break;

										// cada elemento instanceDetails
										case "instanceDetails":
											instanceDetails id = new instanceDetails();
											foreach (XmlNode noInstanceDetails in cadaInstanceInfo.ChildNodes)
											{
												switch (noInstanceDetails.Name)
												{
													case "description":
														id.description = noInstanceDetails.InnerText;
														break;

													case "instanceParams":
														id.instanceParms = noInstanceDetails.InnerText;
														break;

													case "overviewDoc":
														overviewDoc overDoc = new overviewDoc();
														foreach (XmlNode noOverviewDoc in noInstanceDetails.ChildNodes)
														{
															if (noOverviewDoc.Name == "description") 
															{ 
																overDoc.description = noOverviewDoc.InnerText;
															}
															if (noOverviewDoc.Name == "overviewURL") 	
															{
																overDoc.overviewURL = noOverviewDoc.InnerText;
															}
														}
														id.overviewDoc = overDoc;
														break;
												}
											}
											tModelInstance.instanceDetails = id;
											break;
											//Fim do instance Details
									}//Fim tModelInstanceInfo
								}
								arraytModelInstanceInfo.Add(tModelInstance);
							}
							//Colocar o array instance details no instance info
							tModelInstanceInfo[] tii = (tModelInstanceInfo[]) arraytModelInstanceInfo.ToArray( typeof(tModelInstanceInfo));
							bt.tModelInstanceDetails = tii;
							break;
					}
				}
				arrayBindingTemplates.Add(bt);
			}
			return arrayBindingTemplates;
		}

		/// <summary>
		/// Tratamento da estrutura businessEntity
		/// </summary>
		/// <param name="no"></param>
		/// <returns>Array</returns>
		public businessEntity TratarBusinessEntity(XmlNode no)
		{
			businessEntity be = new businessEntity();
			be.businessKey = no.Attributes["businessKey"].InnerText;
			foreach (XmlNode noFilho in no.ChildNodes)
			{
				switch (noFilho.Name)
				{
					case "discoveryURLs":
						// Discovery URL
						ArrayList arrayDiscoveryURL = new ArrayList();

						foreach (XmlNode noDiscoveryURL in noFilho.ChildNodes)
						{
							discoveryURL url = new discoveryURL();
							url.Value = noDiscoveryURL.InnerText;
							arrayDiscoveryURL.Add(url);
						}
						discoveryURL[] urls = (discoveryURL[]) arrayDiscoveryURL.ToArray( typeof(discoveryURL) );
						be.discoveryURLs = urls;
						break;

					case "name":
						//Nome
						ArrayList arrayNome = new ArrayList();

						foreach (XmlNode noNome in noFilho.ChildNodes)
						{
							name nome = new name();
							nome.Value = noNome.InnerText;
							arrayNome.Add(nome);
						}

						name[] nomes = (name[]) arrayNome.ToArray( typeof(name) );
						be.name = nomes;
						break;

					case "description":
						//Descricao
						ArrayList arrayDescricao = new ArrayList();

						foreach (XmlNode noDescricao in noFilho.ChildNodes)
						{
							Description descricao = new Description();
							descricao.Value = noDescricao.InnerText;
							arrayDescricao.Add(descricao);
						}

						Description[] descricoes = (Description[]) arrayDescricao.ToArray( typeof(Description) );
						be.description = descricoes;
						break;

					case "identifierBag":
						//Identifier Bag
							
						ArrayList arrayIdentifierBag = new ArrayList();
						foreach (XmlNode noIdentifierBag in noFilho.ChildNodes)
						{
							keyedReference kr = new keyedReference();
							kr.keyName = noIdentifierBag.Attributes["keyName"].InnerText;
							kr.keyValue = noIdentifierBag.Attributes["keyValue"].InnerText;
							kr.tModelKey = noIdentifierBag.Attributes["tModelKey"].InnerText;
							arrayIdentifierBag.Add(kr);
						}
							
						keyedReference[] keyedReferences = (keyedReference[]) arrayIdentifierBag.ToArray( typeof(keyedReference));
						be.identifierBag = keyedReferences;
						break;
					
					case "categoryBag":
						//Category Bag

						ArrayList arrayCategoryBag = new ArrayList();
						foreach (XmlNode noCategoryBag in noFilho.ChildNodes)
						{
							keyedReference kr = new keyedReference();
							kr.keyName = noCategoryBag.Attributes["keyName"].InnerText;
							kr.keyValue = noCategoryBag.Attributes["keyValue"].InnerText;
							kr.tModelKey = noCategoryBag.Attributes["tModelKey"].InnerText;
							arrayCategoryBag.Add(kr);
						}
						keyedReferences = (keyedReference[]) arrayCategoryBag.ToArray( typeof(keyedReference));
						be.categoryBag = keyedReferences;
						break;
				}
			}
			return be;
		}
	

		public authToken obterToken(string mensagem)
		{
			authToken token = new authToken();
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);
            			
			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:authToken",nsmgr);

			foreach (XmlNode node in nodes)
			{
				token.@operator = node.Attributes["operator"].InnerText;
				token.authInfo = node.InnerText;
			}
			return token;
		}


		/// <summary>
		/// Tratamento da resposta obtida pelo o envio 
		/// de uma mensagem tipo find_business.
		/// Analise de uma mensagem com o businessList
		/// relativamente ás empresas obtidas
		/// </summary>
		/// <param name="name"></param>
		/// <returns>Array de Business Entities</returns>
		public businessEntity[] findBusiness(string mensagem)
		{
			find_business fb = new find_business();
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);

			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:businessInfo",nsmgr);

			//BusinessEntities
			ArrayList arrayBusinessEntity = new ArrayList();

			foreach (XmlNode node in nodes)
			{
				businessEntity be = this.TratarBusinessEntity(node);
				arrayBusinessEntity.Add(be);
			}
		
			businessEntity[] bes = (businessEntity[]) arrayBusinessEntity.ToArray( typeof(businessEntity) );
			return bes;
		}

		/// <summary>
		/// Tratamento da resposta obtida pelo envio
		/// de uma mensagem do tipo find_service
		/// Analise da service list
		/// </summary>
		/// <param name="mensagem"></param>
		public serviceInfo[] findService(string mensagem)
		{
			find_service fs = new find_service();
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);

			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:serviceInfos",nsmgr);

			//ServiceList
			ArrayList arrayServiceInfo = new ArrayList();

			foreach (XmlNode node in nodes)
			{
				foreach (XmlNode noSi in node)
				{
					serviceInfo si = new serviceInfo();
					si.serviceKey = noSi.Attributes["serviceKey"].InnerText;
					si.businessKey = noSi.Attributes["businessKey"].InnerText;
					si.name = noSi.InnerText;

					arrayServiceInfo.Add(si);
				}
			}

			serviceInfo[] sis = (serviceInfo[]) arrayServiceInfo.ToArray( typeof(serviceInfo));
			return sis;
		}

		/// <summary>
		/// Tratamento da resposta obtida pelo envio 
		/// de uma mensagem tipo find_tmodel.
		/// 
		/// </summary>
		public tModelInfo[] findtModel(string mensagem)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);

			//Criar um XmlNameSpaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:tModelInfo",nsmgr);

			//tModelInfos
			ArrayList arraytModelInfo = new ArrayList();

			foreach (XmlNode node in nodes)
			{
				tModelInfo tmi = new tModelInfo();
				tmi.tModelKey = node.Attributes["tModelKey"].InnerText;
				tmi.name = node.InnerText;

				arraytModelInfo.Add(tmi);
			}

			tModelInfo[] tmis = (tModelInfo[]) arraytModelInfo.ToArray( typeof(tModelInfo));
			return tmis;
		}

		/// <summary>
		/// Tratamento da resposta obtida pelo o envio 
		/// de uma mensagem tipo save_business.
		/// </summary>
		/// <param name="name"></param>
		/// <returns>Estrutura Business Entity</returns>
		public businessEntity saveBusiness(string mensagem)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);

			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:businessDetail//uddi:businessEntity",nsmgr);

			businessEntity be = new businessEntity();
			foreach (XmlNode node in nodes)
			{
				be = this.TratarBusinessEntity(node);
			}
			return be;
		}
		


		/// <summary>
		/// Tratamento da resposta obtida pelo envio
		/// de uma mensagem do tipo save_service com 
		/// web services.
		/// </summary>
		/// <param name="name"></param>
		/// <returns>Estrutura Business Service</returns>
		public businessService saveWebService(string mensagem)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);

			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:businessService",nsmgr);

			businessService bs = new businessService();
			foreach (XmlNode node in nodes)
			{
				bs.serviceKey  = node.Attributes["serviceKey"].InnerText;
				bs.businessKey = node.Attributes["businessKey"].InnerText;
				foreach (XmlNode noFilho in node.ChildNodes)
				{
					switch (noFilho.Name)
					{
						case "name":
							//Nome
							ArrayList arrayNome = new ArrayList();
							foreach (XmlNode noNome in noFilho.ChildNodes)
							{
								name nome = new name();
								nome.Value = noNome.InnerText;
								arrayNome.Add(nome);
							}
							name[] nomes = (name[]) arrayNome.ToArray( typeof(name) );
							bs.name = nomes;
							break;
						
						case "bindingTemplates":

							ArrayList arrayBindingTemplates = this.TratarBindingTemplates(noFilho);
							bindingTemplate[] bindingTemplates = (bindingTemplate[]) arrayBindingTemplates.ToArray( typeof(bindingTemplate));
							bs.bindingTemplates = bindingTemplates;
							break;
					}
				}
			}
			return bs;
		}


		/// <summary>
		/// Tratamento da resposta obtida pelo envio
		/// de uma mensagem do tipo save_service com 
		/// classificacao de servicos.
		/// </summary>
		/// <param name="name"></param>
		/// <returns>Estrutura Business Service</returns>
		public businessEntity saveService(string mensagem)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);

			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:businessEntity",nsmgr);

			businessEntity be = new businessEntity();

			foreach (XmlNode node in nodes)
			{
				be = this.TratarBusinessEntity(node);
			}
			return be;
		}
		

		public void savetModel()
		{
			
		}

		/// <summary>
		/// Tratamento da resposta do delete business
		/// </summary>
		public void deleteBusiness(string resposta)
		{
			
		}


		/// <summary>
		/// Tratamento da resposta do delete service
		/// </summary>
		public void deleteService(string resposta)
		{
			
		}


		public void deletetModel()
		{
			
		}


		/// <summary>
		/// Tratamento da resposta obtida pelo o envio 
		/// de uma mensagem tipo get_businessDetail.
		/// Analise de uma mensagem com o businessDetail
		/// </summary>
		/// <param name="name"></param>
		/// <returns>Array de Business Entity</returns>
		public businessDetail getBusinessDetail(string mensagem)
		{
			get_businessDetail gbd = new get_businessDetail();

			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);
			

			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:businessEntity",nsmgr);

			businessDetail bd = new businessDetail();
			businessEntity be = new businessEntity();
			foreach (XmlNode node in nodes)
			{
				// Tratamento do business detail da empresa
				be.businessKey = node.Attributes["businessKey"].InnerText;
				foreach (XmlNode noFilho in node.ChildNodes)
				{
					switch (noFilho.Name)
					{
						case "discoveryURLs":
							//Obter os discovery URLs
							ArrayList arrayDiscoveryURL = new ArrayList();
							foreach (XmlNode noDiscoveryURL in noFilho.ChildNodes)
							{
								discoveryURL discoveryURLs = new discoveryURL();
								discoveryURLs.useType = noDiscoveryURL.Attributes["useType"].InnerText;
								discoveryURLs.Value = noDiscoveryURL.InnerText;
								arrayDiscoveryURL.Add(discoveryURLs);
							}

							discoveryURL[] URLs = (discoveryURL[]) arrayDiscoveryURL.ToArray( typeof(discoveryURL));
							be.discoveryURLs = URLs;
							break;

						case "name":
							//Nome
							ArrayList arrayNome = new ArrayList();
							foreach (XmlNode noNome in noFilho.ChildNodes)
							{
								name nome = new name();
								nome.Value = noNome.InnerText;
								arrayNome.Add(nome);
							}
							name[] nomes = (name[]) arrayNome.ToArray( typeof(name) );
							be.name = nomes;
							break;

						case "description":
							//Descricao
							ArrayList arrayDescricao = new ArrayList();

							foreach (XmlNode noDescricao in noFilho.ChildNodes)
							{
								Description descricao = new Description();
								descricao.Value = noDescricao.InnerText;
								arrayDescricao.Add(descricao);
							}
							Description[] descricoes = (Description[]) arrayDescricao.ToArray( typeof(Description));
							be.description = descricoes;
							break;

						case "contacts":
							//Contactos
							ArrayList arrayContacto = this.TratarContactos(noFilho);
							contact[] contactos = (contact[]) arrayContacto.ToArray( typeof(contact));
							be.contacts = contactos;
							break;

						case "identifierBag":
							//Identifier Bag
							
							ArrayList arrayIdentifierBag = new ArrayList();
							foreach (XmlNode noIdentifierBag in noFilho.ChildNodes)
							{
								keyedReference kr = new keyedReference();
								kr.keyName = noIdentifierBag.Attributes["keyName"].InnerText;
								kr.keyValue = noIdentifierBag.Attributes["keyValue"].InnerText;
								kr.tModelKey = noIdentifierBag.Attributes["tModelKey"].InnerText;
								arrayIdentifierBag.Add(kr);
							}
							
							keyedReference[] keyedReferences = (keyedReference[]) arrayIdentifierBag.ToArray( typeof(keyedReference));
							be.identifierBag = keyedReferences;
							break;
					
						case "categoryBag":
							//Category Bag

							ArrayList arrayCategoryBag = new ArrayList();
							foreach (XmlNode noCategoryBag in noFilho.ChildNodes)
							{
								keyedReference kr = new keyedReference();
								kr.keyName = noCategoryBag.Attributes["keyName"].InnerText;
								kr.keyValue = noCategoryBag.Attributes["keyValue"].InnerText;
								kr.tModelKey = noCategoryBag.Attributes["tModelKey"].InnerText;
								arrayCategoryBag.Add(kr);
							}
							keyedReferences = (keyedReference[]) arrayCategoryBag.ToArray( typeof(keyedReference));
							be.categoryBag = keyedReferences;
							break;
						
						case "businessServices":
							//Business Services
							//Tratamento dos business services
							//Estrutura semelhante aos binding Templates

							ArrayList arrayBusinessServices = new ArrayList();
							foreach (XmlNode noBusinessService in noFilho.ChildNodes)
							{
								businessService bs = new businessService();
								bs.serviceKey = noBusinessService.Attributes["serviceKey"].InnerText;
								bs.businessKey = noBusinessService.Attributes["businessKey"].InnerText;
								//Tratamento dos elementos no business service
								foreach (XmlNode noFilhoBS in noBusinessService.ChildNodes)
								{
									switch (noFilhoBS.Name)
									{
										case "name":
											//Nome
											ArrayList arrayNomeBS = new ArrayList();
											foreach (XmlNode noNome in noFilhoBS.ChildNodes)
											{
												name nome = new name();
												nome.Value = noNome.InnerText;
												arrayNomeBS.Add(nome);
											}
											name[] nomesBS = (name[]) arrayNomeBS.ToArray( typeof(name) );
											bs.name = nomesBS;
											break;
						
										case "bindingTemplates":

											ArrayList arrayBindingTemplates = this.TratarBindingTemplates(noFilhoBS);
											bindingTemplate[] bindingTemplates = (bindingTemplate[]) arrayBindingTemplates.ToArray( typeof(bindingTemplate));
											bs.bindingTemplates = bindingTemplates;
											break;
									}
								}
								arrayBusinessServices.Add(bs);
							}
							//retornar o Business Service
							businessService[] businessServices = (businessService[]) arrayBusinessServices.ToArray( typeof(businessService));
							be.businessServices  = businessServices;
							break;
					}
				}
				businessEntity[] bes = new businessEntity[1];
				bes[0] = new businessEntity();
				bes[0] = be;
				bd.businessEntity = bes;
			}
			return bd;
		}
	

		public void getServiceDetail()
		{
			
		}


		public tModelInfo gettModelDetail(string mensagem)
		{
			get_tModelDetail gtd = new get_tModelDetail();

			XmlDocument doc = new XmlDocument();
			doc.LoadXml(mensagem);
			
			//Criar um XmlNamespaceManager para resolver os namespaces.
			XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
			nsmgr.AddNamespace("soap", "http://schemas.xmlsoap.org/soap/envelope/");
			nsmgr.AddNamespace("uddi", "urn:uddi-org:api_v2");

			XmlNodeList nodes = doc.SelectNodes("//uddi:tModel",nsmgr);

			tModelInfo tmi = new tModelInfo();

			foreach (XmlNode no in nodes)
			{
				tmi.tModelKey = no.Attributes["tModelKey"].InnerText;
				foreach (XmlNode noFilho in no.ChildNodes)
				{
					switch (noFilho.Name)
					{
						case "name":
							//Nome
							tmi.name = noFilho.InnerText;
							break;
						
						case "description":
							//Descricao
							tmi.description = noFilho.InnerText;
							break;
					}
				}
			}
			return tmi;
		}
	}
}
