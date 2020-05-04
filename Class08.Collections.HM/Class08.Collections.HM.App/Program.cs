using Class08.Collections.HM.Business;
using Class08.Collections.HM.Data;
using Class08.Collections.HM.Models;
using System;

namespace Class08.Collections.HM.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new Services();

            Console.WriteLine("Enter the category you want to search: ItEquipment, LapTop, PC, TV");
            string category = Console.ReadLine();
            services.SearchByCategory(category);

            Console.WriteLine("Filter products by price range, enter minminum price and maximum");
            int min;
            int.TryParse(Console.ReadLine(), out min);
            int max;
            int.TryParse(Console.ReadLine(), out max);
            services.FilterByPriceRange(min, max);

            Console.WriteLine("Find product by part of name, enter part of the name of the product");
            string partOfName = Console.ReadLine();
            services.PartOfName(partOfName);

            Console.WriteLine("Get only the ids of the products");
            services.GetIdsOnly();

            Console.WriteLine("Get product price by its id, enter the product id");
            int productId;
            int.TryParse(Console.ReadLine(), out productId);
            services.GetPrice(productId);

            Console.WriteLine("Get the cheapest product");
            services.GetCheapestProduct();

            Console.WriteLine("Get the most expensive product");
            services.GetExpensiveProduct();

            Console.ReadLine();
        }
    }
}
