using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new Customer
            {
                 Id = 17,
                 Name = "Nuri",
                 Surname = "Urtekin",
            });
            customerManager.Update(new Customer
            {
                Id = 17,
                Name = "Nuri",
                Surname = "Urtekin",
            });
            customerManager.Delete(new Customer
            {
                Id = 17,
                Name = "Nuri",
                Surname = "Urtekin",
            });


            Console.ReadLine();
        }
    }
}
