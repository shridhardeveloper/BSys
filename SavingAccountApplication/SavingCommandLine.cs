using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;
using ManyConsole;

namespace SavingAccountApplication
{
    public class SavingCommandLine : ConsoleCommand
    {
        public IUser _user;
        public string _name;
        public string _address;

        public SavingCommandLine(IUser user)
        {
            _user = user;
            IsCommand("User");
            HasOption("n|name=", "Enter Name", name => _name = name);
            HasOption("a|address=", "Enter address", address => _address = address);
        }

        public override int Run(string[] remainingArguments)
        {
            Console.WriteLine("User Details: {0}", remainingArguments[0]);
            return 0;
        }
    }
}
