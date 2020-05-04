using System;
using System.Collections.Generic;
using System.Text;

namespace Class08.Collections.HM.Models
{
    public class Product
    {
        private static int _idGenerator = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }


        public Product()
        {
            _idGenerator++;
            Id = _idGenerator;
          
        }

        public string Info()
        {
            return $"Product id: {Id}, name: {Name}, price: {Price}, category {Category}";
        }

        public static int GetIdGenerator()
        {
            return _idGenerator;
        }

        
    }
}
