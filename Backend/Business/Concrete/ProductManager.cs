using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetList()
        {
            return _productDal.GetList().ToList();
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(p=> p.CategoryId == categoryId).ToList();
        }

        public Product Add(Product product)
        {
            if (product == null) throw new ArgumentNullException("Product cannot be empty");
            var ProductAdd = _productDal.Add(product);
            return ProductAdd;
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product Update(Product product)
        {
            var ProductUpdate = _productDal.Update(product);
            return ProductUpdate;
        }

    }
}
