using System;
using Banking;
using ManyConsole;

namespace CurrentAccountApplication
{
    public class CreateAccountCommandLine :ConsoleCommand
    {
        private readonly IBankAccount _currentAccount;
        private readonly IUser _user;
        private string  _balance ;
        private string _name;
        private string _address;
        private string _birthDate;
        public CreateAccountCommandLine(IUser user, IBankAccount currentAccount)
        {
            _user = user;
            _currentAccount = currentAccount;
            IsCommand("addaccount");
            HasRequiredOption("n|name=", "Enter _name", v => _name = v);
            HasOption("a|address=", "Enter address", v => _address = v);
            HasRequiredOption("b|openingbalance=", "Enter Balance", v => _balance = v);
         }

        public override int Run(string[] remainingArguments)
        {
            if (!string.IsNullOrEmpty(_name))
            {
                _user.Name = _name;
            }
            if (!string.IsNullOrEmpty(_address))
            {
                _user.Address = _address;
            }

            float balance = 0;
            if (!string.IsNullOrEmpty(_balance))
            {
                float.TryParse(_balance, out balance);
            }
            _currentAccount.Balance = balance;
            _currentAccount.CreationDate = DateTime.Now;
            _currentAccount.AccountId = "Acc" + RandomeNumberGenerator().ToString();
            Console.WriteLine("Account created for user {0}", _user.Name);
            Console.WriteLine("Balance for account {0} is {1}", _currentAccount.AccountId , _currentAccount.Balance);


            return 0;
        }

        private int RandomeNumberGenerator()
        {
            Random r = new Random();
            return  r.Next(20000);
        }
    }
}
