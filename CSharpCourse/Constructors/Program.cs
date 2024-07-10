using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.List();

            Product product = new Product();
            Product product2 = new Product(2, "Computer");

            Console.WriteLine(product2.Name);

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;

            Utilities.Validate();

            // sınıfın static methodunu çağırırken nesnesinin oluşturulması gerekmez.
            Manager.DoSomething();

            // Sınıfın static olmayan methodunu çağırırken nesnesinin oluşturulması gerekir.
            Manager manager = new Manager();
            manager.DoSomething2();


            Console.ReadLine();

        }
    }

    class CustomerManager
    {

        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        // Overloading yapılabilir. Kısayol olarak ctor yazıp 2 adet tab tuşuna basımda constructor'u idemiz kendisi oluşturuyor.
        // Overloading nedir peki -> overloading aynı isimle birden fazla method olması durumudur.

        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    class Product
    {


        public Product()
        {

        }

        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }


        public int Id { get; set; }
        public string Name { get; set; }

    }


    interface ILogger
    {
        void Log();
    }


    class DatabasLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {

        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message", _entity);
        }

    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }


    static class Teacher
    {
        public static int Number { get; set; }
    } 

    // static sınıfıların özelliklerine nesnesi oluşturulmadan da erişilebilir. Ayrıca static sınıflarda fieldlar da static olmak zorunda.
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }

    // static olmayan bir sınıfın içerisinde static methodlar da oluşturulabilir. Bu main methodunun altında açıklaması yapılan kısımlarla ilişkilidir.
    class Manager
    {

        static Manager()
        {
            
        }
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }
    }
}
