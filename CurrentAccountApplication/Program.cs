using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using Banking;

namespace CurrentAccountApplication
{
    public class Program
    {
        private static IContainer Container { get; set; }
        private static IUser CurrentUser { get; set; }
        private static IBankAccount CurrentAccount { get; set; }
        private static void Main(string[] args)
        {
            CurrentUser = new User();
            CurrentAccount = new CurrentAccount();
            var builder = new ContainerBuilder();
            builder.RegisterType<CurrentAccountDispatcher>()
                .As<IDispatcher>();
            IModule module = new CurrentAccountModule();

            builder.RegisterModule(module);
            


            Container = builder.Build();
            
         
            Dispatch(args);
            Console.WriteLine(CurrentUser.Name);
            Console.Read();
        }


        private static void Dispatch(string[] args)
        {
            using (var scope = Container.BeginLifetimeScope(cfg =>
    {
               
                cfg.RegisterInstance(CurrentUser);
                cfg.RegisterInstance(CurrentAccount);

            }))
        {
                var dispatch = scope.Resolve<IDispatcher>();
                var response = dispatch.Dispatch(args);
            }
        }
    }
}

