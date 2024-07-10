using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            string[] students2 = { "deneme", "deneme1", "deneme2" };


            if (isPrime(7))
            {
                Console.WriteLine("This Number is a prime");
            }
            else
            {
                Console.WriteLine("Not a prime");
            }

            foreach (string student in students2) 
            { 
                Console.WriteLine(student);
                Console.WriteLine();
            }

            Console.ReadLine();

            void ForLoop()
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            }

            void WhileLoop()
            {
                int number = 100;
                while (number >= 0)
                {
                    Console.WriteLine(number);
                    number--;
                }
            }

            bool isPrime(int number)
            {
                bool prime = false;

                for (int i = 0; i <= number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        prime = true;
                        break;
                    }
                }

                return prime;

            }
        }

       

    }
}
