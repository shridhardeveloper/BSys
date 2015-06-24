using System;
using Banking;
using ManyConsole;

namespace CurrentAccountApplication
{


    public class CreateUserCommandLine : ConsoleCommand
    {
        
        private readonly IUser _user;
        public string Name;
        public string Address;
        public string BirthDate;

        public CreateUserCommandLine(IUser user )
        {
            _user =user;
            IsCommand("adduser");

            HasOption("n|name=", "Enter Name", v => Name = v);
            HasOption("a|address=", "Enter address", v => Address = v);
           // HasOption("d|BirthDate=", "Enter Birthdate (dd-mm-yyyy)", v => BirthDate = v);
        }



        public override int Run(string[] remainingArguments)
        {

            if (!string.IsNullOrEmpty(Name))
            {
                _user.Name = Name;
            }
            if (! string.IsNullOrEmpty(Address))
            {
                _user.Address = Address;
            }


            Console.WriteLine("Welcome {0}", _user.Name);


            return 0;

        }


    }
}