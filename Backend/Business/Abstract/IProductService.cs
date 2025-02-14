﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {

        Product GetById(int productId);

        List<Product> GetList();
        List<Product> GetListByCategory(int categoryId);
        Product Add(Product product);
        void Delete(Product product);
        Product Update(Product product);

    }
}
