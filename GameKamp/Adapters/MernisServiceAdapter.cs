using System;
using System.Collections.Generic;
using System.Text;
using GameKamp.Abstract;
using GameKamp.Entities;

using MernisServiceReference;

namespace GameKamp.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, 
                customer.FirstName,customer.LastName,customer.DateOfBirth.Year);

        }
    }
}
