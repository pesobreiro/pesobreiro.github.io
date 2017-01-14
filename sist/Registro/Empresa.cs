using SiST.UddiCliente;
using SiST.UddiAPI.UddiData;

namespace SiST.Registro
{
	public class Empresa
	{
		private string businessKey;
		public string nome;
		public Servico[] servicos;
		public Classificacao[] classificacoes;
		public tModel[] tModels;
		SerializadorXML sXML;
		DeserializadorXML dsXML;

		/// <summary>
		/// Construtor Empresa - Inicializacao
		/// </summary>
		public Empresa()
		{
			sXML = new SiST.UddiCliente.SerializadorXML();
			dsXML = new SiST.UddiCliente.DeserializadorXML();
		}
		/// <summary>
		/// Adicionar uma empresa ao servidor UDDI
		/// </summary>
		/// <param name="authInfo">Token</param>
		/// <param name="nome">Nome da empresa</param>
		/// <param name="descricao">Descricao da empresa</param>
		/// <param name="contacto">Nome do contacto</param>
		/// <param name="funcaoContacto">Função do contacto</param>
		/// <returns>Codigo da empresa criada</returns>
		public string Criar(string authInfo, string nome, string descricao, string contacto, string funcaoContacto)
		{
			businessEntity be = new businessEntity();

			be.businessKey = "";

			//Nome
			name[] nomes = new name[1];
			nomes[0] = new name();
			nomes[0].Value = nome;
			be.name = nomes;

			//Descricao
			Description[] descricoes = new Description[1];
			descricoes[0] = new Description();
			descricoes[0].Value = descricao;
			be.description = descricoes;

			//Contactos
			contact[] contactos = new contact[1];
			contactos[0] = new contact();
			contactos[0].useType = funcaoContacto;
			contactos[0].personName = contacto;
			contactos[0].description = "";
			contactos[0].address = "";
			contactos[0].email = "";
			contactos[0].phone = "";
			be.contacts = contactos;

			string resposta = sXML.saveBusiness(authInfo,be);
			be = dsXML.saveBusiness(resposta);

			return be.businessKey;
		}


		/// <summary>
		/// Adicionar uma empresa no servidor UDDI
		/// </summary>
		/// <param name="authInfo">Token</param>
		/// <param name="nome">Nome da empresa</param>
		/// <param name="descricao">Descricao da empresa</param>
		/// <param name="contacto">Nome do contacto</param>
		/// <param name="funcaoContacto">Função do contacto</param>
		/// <param name="categoria">Categoria da empresa, taxonomia para industria, produto ou geográfica</param>
		/// <returns>Codigo da empresa criada</returns>
		public string Criar(string authInfo, string nome, string descricao, string contacto, string funcaoContacto, string keyName, string keyValue, string tModelKey)
		{
			businessEntity be = new businessEntity();

			be.businessKey = "";

			//Nome
			name[] nomes = new name[1];
			nomes[0] = new name();
			nomes[0].Value = nome;
			be.name = nomes;

			//Descricao
			Description[] descricoes = new Description[1];
			descricoes[0] = new Description();
			descricoes[0].Value = descricao;
			be.description = descricoes;

			//Contactos
			contact[] contactos = new contact[1];
			contactos[0] = new contact();
			contactos[0].useType = funcaoContacto;
			contactos[0].personName = contacto;
			contactos[0].description = "";
			contactos[0].address = "";
			contactos[0].email = "";
			contactos[0].phone = "";
			be.contacts = contactos;

			// Ia aqui ..............................................


			//Categoria
			//Construir o category bag
			keyedReference[] categoryBag = new keyedReference[1];
			categoryBag[0] = new keyedReference();
			categoryBag[0].keyName = keyName;
			categoryBag[0].keyValue = keyValue;
			categoryBag[0].tModelKey = tModelKey;

			be.categoryBag = categoryBag;


			string resposta = sXML.saveBusiness(authInfo,be);
			be = dsXML.saveBusiness(resposta);

			return be.businessKey;
		}


		/// <summary>
		/// Eliminar uma empresa
		/// </summary>
		/// <param name="authInfo">token</param>
		/// <param name="businessKey">businessKey</param>
		public string Eliminar(string authInfo, string businessKey)
		{
			string resultado = sXML.deleteBusiness(authInfo, businessKey);

			return resultado;
		}


		/// <summary>
		/// Alterar a informacao de uma empresa no servidor UDDI
		/// </summary>
		/// <param name="authInfo">token</param>
		/// <param name="businessKey">businessKey</param>
		/// <param name="nome">Nome da empresa</param>
		/// <param name="descricao">Descricao da empresa</param>
		/// <param name="contacto">Nome do contacto</param>
		/// <param name="funcaoContacto">Funcao do contacto</param>
		public void Alterar(string authInfo, string businessKey, string nome, string descricao, string contacto, string funcaoContacto)
		{
			string resultado = sXML.getBusinessDetail(businessKey);
			businessDetail be = dsXML.getBusinessDetail(resultado);

			be.businessEntity[0].name[0].Value = nome;
			be.businessEntity[0].description[0].Value = descricao;
			be.businessEntity[0].contacts[0].personName = contacto;
			be.businessEntity[0].contacts[0].useType = funcaoContacto;

			sXML.saveBusiness(authInfo, be.businessEntity[0]);
		}
	}
} 
