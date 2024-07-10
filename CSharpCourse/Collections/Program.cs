using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //ListMethods();

            Dictionary<string,string> dictionary = new Dictionary<string,string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        private static void ListMethods()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();

            customers.Add(new Customer { Id = 1, firstName = "Adil" });
            customers.Add(new Customer { Id = 2, firstName = "Merve" });


            //listenin eleman sayısını döndürür.
            var count = customers.Count();
            Console.WriteLine(count);

            // listedeki bütün elemanları siler.
            //customers.Clear();
            //var count2 = customers.Count();
            //Console.WriteLine(count2);

            // Listenin içerisinde verilen string var mı yok mu onu kontrol eder.
            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var item in customers)
            {
                Console.WriteLine("Customer id : " + item.Id);
            }
        }

        private static void ArrayList()
        {
            string[] cities = new string[2]
                        {
                "Ankara","İstanbul"
                        };

            // Eğer çalışacağımız listede typesafe bir durum yoksa, birden fazla veri tipi varsa ArrayList kullanırız.
            ArrayList cities1 = new ArrayList();
            cities1.Add("Ankara");
            cities1.Add("ADana");

            foreach (string city in cities1)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
    }
}
