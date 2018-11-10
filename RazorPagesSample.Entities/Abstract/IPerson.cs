using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesSample.Entities.Abstract
{
    /// <summary>
    /// This is our first interface. Any class that implements IPerson must have an Id and FullName property.
    /// </summary>
    public interface IPerson
    {
        int Id { get; }
        string FullName { get; }
    }
}
