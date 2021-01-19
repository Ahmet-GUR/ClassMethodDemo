using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "GÜR";
            customer1.Age = 16;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Hasan";
            customer2.LastName = "ALTUNDAĞ";
            customer2.Age = 25;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Pelin";
            customer3.LastName = "YILMAZ";
            customer3.Age = 20;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Merve";
            customer4.LastName = "ASLANOBA";
            customer4.Age = 35;

            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.FirstName = "Hakan";
            customer5.LastName = "KALDIRIM";
            customer5.Age = 30;

            CustomerManeger customerManeger = new CustomerManeger();

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            foreach (var customer in customers)
            {
                customerManeger.GetList(customer);
            }

            Line();

            customerManeger.Add(customer1);

            Line();

            customerManeger.Delete(customer2);

            Line();

            customerManeger.Update(customer3);

            Console.ReadLine();
        }

        private static void Line()
        {
            Console.WriteLine("---------------------");
        }
    }
}
