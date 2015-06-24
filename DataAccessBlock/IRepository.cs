using Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessBlock
{
    public interface IAccountRepository
    {
        List<IBankAccount> GetAll();
        IBankAccount Find(int? id);
        IBankAccount Add(IBankAccount employee);
        IBankAccount Update(IBankAccount employee);
        void DeleteAccount(int id);
    }

    public interface IUserRepository
    {
        List<IUser> GetAll();
        IUser Find(int? id);
        IUser Add(IUser employee);
        IUser Update(IUser employee);
        void DeleteUser(int id);
    }
}
