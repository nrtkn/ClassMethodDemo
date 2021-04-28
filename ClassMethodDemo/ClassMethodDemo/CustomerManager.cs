using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name+" "+customer.Surname+" Added!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + "'s informations updated!");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " Deleted!");
        }
    }
}
