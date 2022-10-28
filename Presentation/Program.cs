using Business;
using Entities;
using System.ComponentModel;

namespace Presentation
{
    public class Program
    {
        public static ProductManager productService = new ProductManager();
        public static CategoryManager categoryService = new CategoryManager();
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE ELECRONICS SHOP!!!");
            Console.WriteLine("PLEASE INSERT NUMBERS ACCORDINGLY IN ORDER TO PROCEED!");
            Console.WriteLine();
            Console.WriteLine("NUM-1: to Get all the Products and information about them");
            Console.WriteLine("NUM-2: to Get all the Products and information about them by ID");
            Console.WriteLine("NUM-3: to Get all the Products and information about them by Category");
            OperationsFunction(int.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
        public static void OperationsFunction(int i)
        {
            int commandID = i;
            if (commandID == 1)
                getAllProductsScreen();
            if(commandID == 2)
            {
                Console.WriteLine("please enter the id of product that u wanna buy");
                int commandOfGetByIdScreen = int.Parse(Console.ReadLine());
                getByIdScreen(commandOfGetByIdScreen);
            }
            if(commandID == 3)
            {
                Console.WriteLine("Please enter category Id");
                Console.WriteLine("1-phone, 2-Tv, 3-House Holds");
                int givenIdFromConsole = int.Parse(Console.ReadLine());
                if (givenIdFromConsole == 1)
                {
                    getByCategory((int)CategoryEnum.Phone);
                }
                else if (givenIdFromConsole==2)
                {
                    getByCategory((int)CategoryEnum.Tv);
                }
                else if (givenIdFromConsole==3)
                {
                    getByCategory((int)CategoryEnum.HouseHold);
                }
                Console.ReadKey();
            }


        }//opeartion function does as ur input number matches!
        public static void getAllProductsScreen()
        {
            List<Product> products = productService.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine("----------------");
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Color: {item.Color}, Price: {item.Price}, Describtion: {item.Describtion}");
                Console.WriteLine("----------------");
            }
        } //gets all products (working!)
        public static void getByIdScreen(int id)//ONLY BY ID!!
        {
            List<Product> products = productService.GetAll();
            foreach (var item in products)
            {
                if(item.Id==id)
                    Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Color: {item.Color}, Price: {item.Price}, Describtion: {item.Describtion}");

            }
        }
        public static void getByCategory(int categoryId)
        {
            Category catgoryFilterer = categoryService.GetById(categoryId);
            List<Product> filteredProduct = productService.GetByCategory(catgoryFilterer);

            foreach (var item in filteredProduct)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Color: {item.Color}, Price: {item.Price}, Describtion: {item.Describtion}");
                Console.WriteLine("yel dartan");
            }
            
        }
    }
}