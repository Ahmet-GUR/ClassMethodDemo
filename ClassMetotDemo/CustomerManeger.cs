using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManeger
    {
        public void GetList(Customer customer)
        {
            Console.WriteLine( customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age);
        }

        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added!" +" = "+ customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Delete!" + " = " + customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Update!" + " = " + customer.Id + " " + customer.FirstName + " " + customer.LastName + " " + customer.Age);
        }

    }
}
