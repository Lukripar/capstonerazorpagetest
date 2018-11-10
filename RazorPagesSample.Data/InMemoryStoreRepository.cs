using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RazorPagesSample.Entities;

namespace RazorPagesSample.Data
{
    public class InMemoryStoreRepository : IStoreRepository
    {
        public ICollection<Store> Stores { get; set; }

        public InMemoryStoreRepository()
        {
            var store1 = new Store()
            {
                Id = 1,
                Address = new Address("123 Jamie Lane", "Eleanor", "WV", "25313")
            };
            var gameboy = new Product(1, "Gameboy", 50);
            var xbox = new Product(2, "Xbox", 300);
            store1.AddStock(gameboy);
            store1.AddStock(gameboy);
            store1.AddStock(xbox);
            var store2 = new Store()
            {
                Id = 2,
                Address = new Address("333 Lorem Ave", "Ipsum", "NC", "23456")
            };
            store2.AddStock(gameboy);

            Stores = new List<Store>();
            Stores.Add(store1);
            Stores.Add(store2);
        }

        public void Add(Store store)
        {
            Stores.Add(store);
        }

        public Store Get(int id)
        {
            return Stores.FirstOrDefault(st => st.Id == id);
        }

        public ICollection<Store> GetAll()
        {
            return Stores;
        }
    }
}
