using System;
using System.Xml.Schema;


namespace Banking
{
    public class User : IUser
    {

        public User()
        {

        }

        public User(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
    }


    public class Address
    {
        public Address()
        {
        }

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Address(string line1, string city, string country)
        {
        }
    }

}