namespace RazorPagesSample.Entities
{
    /// <summary>
    /// This is an example of an Immutable class. Notice that all the properties are {get;}, meaning that they 
    /// are all read-only and I cannot change anything about this address, I have to create a new one. 
    /// </summary>
    public class Address
    {
        public Address(string streetAddress, string city, string state, string zip)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public string StreetAddress { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }

        public override string ToString()
        {
            return $"{StreetAddress}, {City}, {State} {Zip}";
        }
    }
}