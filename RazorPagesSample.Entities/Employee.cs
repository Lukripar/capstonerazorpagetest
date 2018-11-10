using RazorPagesSample.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesSample.Entities
{

    public class Employee : IPerson
    {
        public Employee()
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
