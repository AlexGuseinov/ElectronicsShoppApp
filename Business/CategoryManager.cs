using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CategoryManager
    {
        public CategoryDal _categoryService { get; set; }
        public CategoryManager()
        {
            _categoryService = new CategoryDal(); 
        }

        public Category GetById(int id)
        {
            return _categoryService.getById(id);
        }
        public List<Category> GetAll()
        {
            return _categoryService.getAll();
        }
        public void CategoryRemove(Category category)
        {
            _categoryService.remove(category);
        }

        public void CategoryAdder(Category category)
        {
            _categoryService.add(category);
        }
        
    }
}
