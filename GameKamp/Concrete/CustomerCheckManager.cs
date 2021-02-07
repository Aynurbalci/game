using System;
using System.Collections.Generic;
using System.Text;
using GameKamp.Abstract;
using GameKamp.Entities;

namespace GameKamp.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
