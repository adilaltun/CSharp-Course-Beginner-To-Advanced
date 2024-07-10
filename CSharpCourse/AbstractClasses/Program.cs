using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Database database = new MySql();
            database.Add();
            database.Delete();

            Database database1 = new Oracle();
            database1.Add();
            database1.Delete();

            Console.ReadLine();
        }
    }

    // abstract classlarda içi dolu ve boş methodlar oluşturabiliriz. Burada için dolu olan her sınıf için ortak boş olan ise virtual method gibi override edilendir.
    // abstract class lar new anahtar kelimesiyle nesnesi oluşturulamaz.
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        // abstract method için dolu olmayan virtual methoddur aslında. 
        public abstract void Delete();  
    }

    class MySql : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by MySql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
