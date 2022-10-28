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
    public class CategoryDal : ICategoryDal
    {
        public void add(Category category)
        {
            Console.WriteLine("New category element added!!");
            LocalStorage.GetByCategory().Add(category);
        }

        public List<Category> getAll()
        {
            return LocalStorage.GetByCategory();
        }

        public Category getById(int id)
        {
            Category result = new Category();
            foreach (var item in LocalStorage.GetByCategory()) 
            {
                if(result.CategoryId == id)
                    result = item;
                break;
            }
            
            return result;
        }

        public void remove(Category category)
        {
            LocalStorage.GetByCategory().Remove(category);
        }
    }
}
