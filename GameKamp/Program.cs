
using System;
using GameKamp.Abstract;
using GameKamp.Concrete;
using GameKamp.Entities;



namespace GameKamp
{
    class Program
    {

        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new PlayerCustomerManager();
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2001, 1, 16),FirstName="Aynur",LastName="Balcı",NationalityId="14204793392"});
            Console.ReadLine();

        }
      


    }
}
