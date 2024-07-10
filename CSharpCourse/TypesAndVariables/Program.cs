using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool condition = true;
            char character = 'a';
            int number1 = 2141312;
            long number2 = 231321321;
            short number3 = 14531;
            byte number4 = 255;

            //double veri türü virgülden sonra 15-16 karakter tutabiliyor
            double number5 = 2135.46547;

            //decimal veri türü virgülden sonra 56-57 karakter tutabiliyor ve sonuna m istiyor.
            decimal number6 = 123132.54654m;

            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Hello World");
            Console.WriteLine("Char: " +character);
            Console.WriteLine("Integer: " +number1);
            Console.WriteLine("Long: " +number2);
            Console.WriteLine("Short: " +number3);
            Console.WriteLine("Byte: " +number4);

            Console.WriteLine("Var: " +number7);

            
            Console.WriteLine("Double: " +number5);
            Console.WriteLine("Boolean: " +condition);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();

        }
    }

    enum Days
    {
        Monday=10,Tuesday=20,Wedneday=30,Thursday=40,Friday=50,Saturday=60,Sunday=70
    }
}
