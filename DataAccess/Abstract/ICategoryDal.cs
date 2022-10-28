using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal
    {
        void add(Category category);
        void remove(Category category);
        Category getById(int id);
        List<Category> getAll();
    }
}
