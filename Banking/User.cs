using System;


namespace Banking
{
    public class User : IUser
    {

        public string Name { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
    }

}