using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessBlock
{
    public class AccountRepository : IAccountRepository
    {
        private IDbConnection _db = null;

        public AccountRepository(string connectionString)
        {
            _db = new SqlConnection(connectionString);
        }

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
        private IDbConnection _db = null;

        public UserRepository(string connectionString)
        {
            _db = new SqlConnection(connectionString);
        }

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
