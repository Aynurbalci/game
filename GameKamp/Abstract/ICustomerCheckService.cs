using GameKamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameKamp.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
   
    }
}
