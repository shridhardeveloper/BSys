using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessBlock
{
    public class AccountRepository : IAccountRepository
    {
        public List<Banking.IBankAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public Banking.IBankAccount Find(int? id)
        {
            throw new NotImplementedException();
        }

        public Banking.IBankAccount Add(Banking.IBankAccount employee)
        {
            throw new NotImplementedException();
        }

        public Banking.IBankAccount Update(Banking.IBankAccount employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }
    }

    public class UserRepository : IUserRepository
    {
        public List<Banking.IUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public Banking.IUser Find(int? id)
        {
            throw new NotImplementedException();
        }

        public Banking.IUser Add(Banking.IUser employee)
        {
            throw new NotImplementedException();
        }

        public Banking.IUser Update(Banking.IUser employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
