using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductManager
    {
        public ProductDal _ProductDal { get; set; }
        public ProductManager()
        {
            _ProductDal = new ProductDal();
        }

        public void add(Product product)
        {
            _ProductDal.add(product);
        }
        public void getById(int id)
        {
            _ProductDal.getById(id);
        }
        public List<Product> GetAll()
        {
            return  _ProductDal.getAll();
        }
        public List<Product> GetByCategory(Category category)
        {
            List<Product> result = new List<Product>();

            foreach (var product in _ProductDal.getAll())
            {
                if (product.CategoryId == category.CategoryId)
                    result.Add(product);
            }

            return result;
        }
    }
}
