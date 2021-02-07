
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GameKamp.Entities;

namespace GameKamp.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
