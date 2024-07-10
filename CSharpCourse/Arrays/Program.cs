using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3];
            students[0] = "deneme";
            students[1] = "deneme1";
            students[2] = "deneme2";

            string[] students2 = { "deneme", "deneme1", "deneme2" };

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            //Multi dimensional array -> 
            string[,] bolgeler = new string[7, 3]
            {
                {"","","" },
                { "","",""},
                { "","",""},
                { "","",""},
                { "","",""},
                { "","",""},
                { "","",""},
            };

            for (int i = 0; i < bolgeler.GetUpperBound(0); i++)
            {
                for (int j = 0;j <=bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i,j]);
                }
                Console.WriteLine("********");
            }

            Console.ReadLine();
        }
    }
}
