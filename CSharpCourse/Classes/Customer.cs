﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {

        //Field
        //public string Name;


        //Property -> sınıfın özelliklerini anlatan bir şey tanımlayacaksak kullanılır.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
