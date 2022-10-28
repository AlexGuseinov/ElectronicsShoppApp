using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void add(Product product);
        void remove(Product product);
        List<Product> getById(int id);
        List<Product> getAll();
    }
}
