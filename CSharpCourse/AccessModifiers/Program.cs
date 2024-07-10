using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Customer
    {
        //Default private gelir. Sadece tanımlandığı blok içerisinde geçerlidir.
        //int id;

        // protected ise tanımlandığı blok içerisinde ve inherit edildiği sınıfı içerisinde de kullanılabilir.

        protected int Id { get; set; }

        public void Save()
        {
           
        }
    }

    class Student:Customer
    {


        public void Save2()
        {

        }
    }

    // classların başında herhangi bir access modifier yazmazsa default olarak gelen access modifier internaldır.
    // burada projenin içerisinde nerede olursa olsun bu sınıfa erişim izni verir.
    public class Course
    {
        public string Name { get; set; }

        private class NestedClass
        {

        }
    }


}
