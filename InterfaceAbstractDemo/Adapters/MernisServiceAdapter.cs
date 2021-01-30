using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient();

            //return client.TCKimlikNoDogrulaAsync(customer.NationalityId,
            //    customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);

            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;

        }


    }
}
