﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number1 = 10;


            int number2 = 20;

            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);


            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" }; //101 referans numarası
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };//102 referans numarası

            cities2 = cities1;
            cities1[0] = "İstanbul";

            Console.WriteLine(cities2[0]);

            DataTable dataTable = new DataTable();
            DataTable dataTable2 = new DataTable();

            dataTable2 = dataTable;

            Console.ReadLine();
        }
    }


}
