﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(adil-altun\SQLEXPRESS);Database=Northwind;Trusted_Connection=true");
            //base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }

    }
}
