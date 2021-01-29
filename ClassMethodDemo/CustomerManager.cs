using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
       public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + customer.Surname "succesfully added.");

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + customer.Surname "succesfully deleted.");

        }
        public void ListCustomers(List<Customer>customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Id: " + customer.Id);
                Console.WriteLine("Customer Name: " + customer.Name);
                Console.WriteLine("Customer Surname: " + customer.Surname);
                Console.WriteLine("Customer Mail: " + customer.mail);
               
            }

        }
        
    }
}
