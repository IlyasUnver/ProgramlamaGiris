using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added! : " + customer.Name);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted! : " + customer.Name);
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Customer Listed! : " + customer.Name);
        }


    }
}
