using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExcepitonIntro();


            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();
            });
            Console.ReadLine();

        }


        //Action Delegations
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Exception: {exception.Message}");
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Ali", "Veli", "Hasan" };

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found.");
            }
            else
            {
                Console.WriteLine("Record Found.");
            }


        }

        private static void ExcepitonIntro()
        {
            try
            {
                string[] students = new string[3] { "Adil", "Mehmet", "Salih" };
                students[3] = "Ahmet";
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }


}
