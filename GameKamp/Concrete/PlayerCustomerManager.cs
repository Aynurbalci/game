using GameKamp.Abstract;
using GameKamp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GameKamp.Concrete
{
    public class PlayerCustomerManager :BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person");

            }
        }

        
    }
}
