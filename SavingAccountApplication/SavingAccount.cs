using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace SavingAccountApplication
{
    class SavingAccount : IBankAccount
    {
        public string AccountId { get; set; }
        public float Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public IUser _user;

        public SavingAccount(IUser user)
        {
            _user = user;
        }

        public void Debit(float amount)
        {
            Console.WriteLine("Amount {0} has been debited.", amount);
        }

        public void Credit(float amount)
        {
            Console.WriteLine("Amount {0} has been credited.", amount);
        }

        public void CalculateInterest()
        {
            Console.WriteLine("Interest Calculated");
        }

        public void BalanceEnquiry()
        {
            Console.WriteLine("Balance Enquiry");
        }
    }
}
