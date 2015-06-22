using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking;

namespace SavingAccountApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SavingAccount>().As<IBankAccount>();
            builder.RegisterType<User>().As<IUser>();
            var container = builder.Build();

            container.Resolve<IBankAccount>().BalanceEnquiry();
            //container.Resolve<IUser>().GetProfile();
            Console.ReadLine();  
        }
    }
}
