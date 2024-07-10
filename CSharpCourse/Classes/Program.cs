using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine("----------------");

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Console.WriteLine("----------------");

            Customer customer = new Customer();
            customer.Id = 1;
            customer.City = "Ankara";
            customer.FirstName = "Test";
            customer.LastName = "Test";

            Console.WriteLine(customer.FirstName);


            

        }
    }
}
