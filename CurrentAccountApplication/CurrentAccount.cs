using Banking;
using System;
namespace CurrentAccountApplication
{
   public class CurrentAccount :  IBankAccount
    {
        public   string AccountId { get; set; }
        public float Balance { get; set; }
        public DateTime CreationDate { get; set; }

        public void Debit(float amount)
        {
            throw new System.NotImplementedException();
        }

        public void Credit(float amount)
        {
            throw new System.NotImplementedException();
        }

        public void CalculateInterest()
        {
            throw new System.NotImplementedException();
        }

        public void BalanceEnquiry()
        {
            throw new System.NotImplementedException();
        }
    }
}
