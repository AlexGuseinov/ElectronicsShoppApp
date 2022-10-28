using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.LocalDataBase
{
    public static class LocalStorage
    {
        public static List<Product> GetAllProducts()
        {
            return new List<Product>()
            {
                new Product(){Id=1,Name="samsung", Color="white", Price= 2799.99m,CategoryId=1 },
                new Product(){Id=2,Name="iphone se", Color="red Product", Price= 1899m,CategoryId=1 },
                new Product(){Id=3,Name="iphone 12", Color="Silver", Price= 1758.99m, CategoryId=1},
                new Product(){Id=4,Name="Lg 123", Color="blue", Price= 1600m, CategoryId=1},
                new Product(){Id=5,Name="Huawei mate 20 pro", Color="ocean blue", Price= 1059.99m,CategoryId=1 },
                new Product(){Id=6,Name="Xiaomi mi9", Color="black", Price= 1879m, CategoryId=1},
                new Product(){Id=7,Name="iphone 14 pro", Color="pink", Price= 4699.99m, CategoryId=1},
                new Product(){Id=9,Name="Panasonic", Color="black", Price= 1200.9m, CategoryId=2},
                new Product(){Id=10,Name="samsung", Color="black", Price= 1788.99m, CategoryId=2},
                new Product(){Id=11,Name="LG tv", Color="black", Price= 2600m, CategoryId=2},
                new Product(){Id=12,Name="Sony", Color="black", Price= 3099.99m, CategoryId=2},
                new Product(){Id=13,Name="Vestel", Color="black", Price= 499m, CategoryId=3},
                new Product(){Id=13,Name="Bosch", Color="black", Price= 339m, CategoryId=3},
                new Product(){Id=13,Name="apple remote", Color="black", Price= 5009m, CategoryId=3},
            };
        }
        public static List<Category> GetByCategory()
        {
            return new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "smart Phones" },
                new Category() { CategoryId = 2, CategoryName = "TV" },
                new Category() { CategoryId = 3, CategoryName = "House Holds" },
            };
        }
    }
}
