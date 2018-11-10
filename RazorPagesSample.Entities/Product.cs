using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesSample.Entities
{
    public class Product
    {
        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}
