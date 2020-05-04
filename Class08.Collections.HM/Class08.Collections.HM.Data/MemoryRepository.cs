using Class08.Collections.HM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.Collections.HM.Data
{
    public  class MemoryRepository
    {
        public List<Product> Products { get; set; }

        public MemoryRepository()
        {
            InitalizeProducts();
        }
        public void InitalizeProducts()
        {
            Products = new List<Product>
            {
                new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            }; 
        }

        public Product AddProduct()
        {
            var newproduct = new Product();
            newproduct.Name = Console.ReadLine();
            double price;  
            double.TryParse(Console.ReadLine(), out price);
            newproduct.Price = price;
            string productCategory = Console.ReadLine();
            Category category = (Category)Enum.Parse(typeof(Category), productCategory);
            newproduct.Category = category;

            Products.Add(newproduct);
            Console.WriteLine($"You succesfully added a new product: {newproduct}");
            return newproduct;
        }

        public void RemoveProduct()
        {
            int productId;
            int.TryParse(Console.ReadLine(), out productId);

            foreach(var product in Products)
            {
                if(product.Id == productId)
                {
                    Products.Remove(product);
                    Console.WriteLine("You succesfully removed a product!");
                }   
            }
        }
    }
}
