using Class08.Collections.HM.Data;
using Class08.Collections.HM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class08.Collections.HM.Business
{
   public class Services : MemoryRepository
   {
        public Services() : base()
        {

        }
        public void SearchByCategory(string category)
        {
          foreach(var product in Products)
          {
               if(category.ToUpper() == product.Category.ToString().ToUpper())
               {
                    Console.WriteLine(product.Info());
               }
          }
        }

        public void FilterByPriceRange(int min, int max)
        {
            foreach(var product in Products)
            {
                if(product.Price >= min && product.Price <= max)
                {
                    Console.WriteLine(product.Info());
                }
            }
        }

        public void PartOfName(string namePart)
        {

            foreach(var product in Products)
            {
                if (product.Name.ToUpper().Contains(namePart.ToUpper()))
                {
                    Console.WriteLine(product.Info());
                }
            }
            
        }

        public void GetIdsOnly()
        {
            foreach(var product in Products)
            {
                Console.WriteLine(product.Id);
            }
        }

        public void GetPrice(int productId)
        {
            foreach(var product in Products)
            {
                if(product.Id == productId)
                {
                    Console.WriteLine(product.Price);
                }
            }
        }

        public void GetCheapestProduct()
        {
            double price = double.MaxValue;
            Product product = null;
            foreach (var item in Products)
            {
                if (price > item.Price)
                {
                    price = item.Price;
                    product = item;
                }
            }
            Console.WriteLine(product.Info());
        }

        public void GetExpensiveProduct()
        {
            double price = 0;
            Product product = null;
            foreach (var item in Products)
            {
                if (item.Price > price)
                {
                    price = item.Price;
                    product = item;
                }
            }
            Console.WriteLine(product.Info());
        }
    }
}
