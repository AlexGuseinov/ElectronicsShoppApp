using DataAccess.Abstract;
using Entities;
using Entities.LocalDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDal : IProductDal

    {
        public void add(Product product)
        {
            LocalStorage.GetAllProducts().Add(product);
        }

        public List<Product> getAll()
        {
            return LocalStorage.GetAllProducts();
        }

        public List<Product> getById(int id)
        {
            Product result = new Product();
            foreach (var product in LocalStorage.GetAllProducts())
            {
                if (product.Id==id)
                {
                    return getAll();
                }
            }
            return null;
        }

        public void remove(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
