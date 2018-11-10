using RazorPagesSample.Entities.Abstract;
using System;

namespace RazorPagesSample.Entities
{
    public class Customer : IPerson
    {
        public Customer()
        {
            FirstName = "John";
            LastName = "Doe";
        }

        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{LastName}, {FirstName}";
    }
}
