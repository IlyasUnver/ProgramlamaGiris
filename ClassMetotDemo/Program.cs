using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ilyas";
            customer1.Surname = "Unver";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Ahmet";
            customer2.Surname = "Mehmet";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Veli";
            customer3.Surname = "Deli";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customer3);

        }
    }
}
