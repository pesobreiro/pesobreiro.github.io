using System;
//UDDI
using Microsoft.Uddi;
using Microsoft.Uddi.Business;
using Microsoft.Uddi.Service;
using Microsoft.Uddi.Binding;
using Microsoft.Uddi.ServiceType;
using Microsoft.Uddi.Api;

namespace SiSTUddi.publicar
{
	/// <summary>
	/// Esta classe permite publicar informação relativamente
	/// aos servicos  que se pretendem registrar.                            
	/// </summary>
	public class PublicarEmpresa
	{
		public PublicarEmpresa()
		{
			// Parametros gerais

		}
		
		/// <summary>
		/// Registrar a empresa
		/// </summary>
		/// <param name="nome"></param>
		/// <param name="descricao"></param>
		/// <param name="contacto"></param>
		/// <param name="funcaoContacto"></param>
		public void Registrar(int userID, string nome, string descricao, string contacto, string funcaoContacto)
		{
			try
			{
				Publish.Url = "http://localhost:9080/uddisoap/publishapi";
				Publish.User = "db2admin";
				Publish.Password = "radical";

				// Create an object to save a business
				SaveBusiness sb = new SaveBusiness();

				// Add a business entity and allocate a name
				sb.BusinessEntities.Add();
				sb.BusinessEntities[0].Names.Add(nome);

				// Add multi-language descriptions for the business
				sb.BusinessEntities[0].Descriptions.Add("pt", descricao);

				// Add classification and identification information for this business
				//sb.BusinessEntities[0].CategoryBag.Add("NAICS: Software Publisher", "51121", "uuid:c0b9fe13-179f-413d-8a5b-5004db8e5bb2");
				//sb.BusinessEntities[0].CategoryBag.Add("Washington", "US-WA", "uuid:4e49a8d6-d5a2-4fc2-93a0-0411d8d19e88");
				//sb.BusinessEntities[0].IdentifierBag.Add("D-U-N-S", "00-000-0000", "uuid:8609c81e-ee1f-4d5a-b202-3eb13ad01823");

				// Add contact details for relevant individuals
				sb.BusinessEntities[0].Contacts.Add();
				sb.BusinessEntities[0].Contacts[0].PersonName = contacto;
				sb.BusinessEntities[0].Contacts[0].UseType = funcaoContacto;
				//sb.BusinessEntities[0].Contacts[0].Addresses.Add("My Sort Code", "Work Address");
				//sb.BusinessEntities[0].Contacts[0].Addresses[0].AddressLines.Add("1 My Street");
				//sb.BusinessEntities[0].Contacts[0].Addresses[0].AddressLines.Add("My Town");
				//sb.BusinessEntities[0].Contacts.Add("John Smith","CEO");

				
				// Send the prepared save business request
				BusinessDetail savedB = sb.Send();

				//Actualizar a Base de dados com os dados adicionados ao UDDI.
				ActualizarBD(userID,savedB.BusinessEntities[0].BusinessKey.ToString());
			}
			catch (UddiException e)
			{Console.WriteLine("UDDI exception: " + e.Number + " - " + e.Message);}
			catch (Exception e)
			{Console.WriteLine("General exception: " + e.Message);}

		}
		/// <summary>
		/// Actualizar a base de dados
		/// </summary>
		/// <param name="businessKey"></param>
		private void ActualizarBD(int userID,string businessKey)
		{
			Empresa empresa = new Empresa();

			empresa.CriarEmpresa(userID,businessKey);
			
		}

		private void ProcurarTipoServico()
		{
			//Em construcao
		}
	}
}
