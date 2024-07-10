using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            int number1 = 10;
            int newNumber = Sum(ref number1);
            Console.WriteLine(number1);
            Console.WriteLine(newNumber);
            Console.WriteLine(Multiply(1,20));
            Console.ReadLine();
        }

        static void Add() 
        {
            Console.WriteLine("Added!");
        }

        // Default parametreli methodlarda default değerleri verebiliriz. Fakat buradaki default verdiğin parametre
        // sonda olmalıdır.
        static int Sum(ref int number1, int number2=30) 
        {
            number1 = 30;
            int sum = number1 + number2;
            return sum;
        }

        static int Sum2(out int number1, int number2 = 30)
        {
            number1 = 30;
            int sum = number1 + number2;
            return sum;
        }

        static int Multiply(int number1, int number2) 
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }

        static int add4(params int[] numbers) {
            return numbers.Sum();
        }
        }
}
