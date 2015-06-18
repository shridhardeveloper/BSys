using System;

namespace Banking
{
   public interface IBankAccount
    {
       string AccountId { get; set; }
       float Balance { get; set; }
       DateTime CreationDate { get; set; }
       void Debit(float amount);
       void Credit(float amount);
       void CalculateInterest();
       void BalanceEnquiry();







    }
}
