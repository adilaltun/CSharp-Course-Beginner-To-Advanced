using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Deneme123";

            int length = sentence.Length;
            var result1= sentence.Clone();
            
            bool endsWith = sentence.EndsWith("23");
            bool startsWith = sentence.StartsWith("My name");

            int indexOf = sentence.IndexOf("name");
            int lastIndexOf = sentence.LastIndexOf(" ");

            var result2 = sentence.Insert(0, "Hello, ");

            var result3 = sentence.Substring(3);
            var result4 = sentence.Substring(3,4);

            var result5 = sentence.ToLower();
            var result6 = sentence.ToUpper();

            var result7 = sentence.Replace(" ", "-");

            var result8 = sentence.Remove(2);
            var result9 = sentence.Remove(2,5);

            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);

            Console.WriteLine(endsWith);
            Console.WriteLine(startsWith);
            Console.WriteLine(indexOf);

            Console.WriteLine(length); 

            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara";

            Console.WriteLine(city[0]);

            foreach (var cities in city)
            {
                Console.WriteLine(cities);
            }

            string city2 = "İstanbul";

            //string birlestirme = city + " " + city2;

            //Console.WriteLine(birlestirme);


            //String.Format'ı kullanarak bellekte yeni bir değişken oluşturmadan birleştirme işlemini yapar  
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
