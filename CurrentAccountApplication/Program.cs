using System;
using Autofac;
using Autofac.Core;
using Banking;

namespace CurrentAccountApplication
{
    public class Program
    {
        private static IContainer Container { get; set; }
        private static IUser CurrentUser { get; set; }

        private static void Main(string[] args)
        {
            CurrentUser = new User();
            var builder = new ContainerBuilder();
            builder.RegisterType<CurrentAccount>().As<IBankAccount>();
            builder.RegisterType<User>().As<IUser>();

            builder.RegisterType<CurrentAccountDispatcher>()
                .As<IDispatcher>();
            builder.RegisterInstance(CurrentUser)
               .As<IUser>()
               .SingleInstance();
            IModule module = new CurrentAccountModule();
               
                builder.RegisterModule(module);
            


            Container = builder.Build();

         
            Dispatch(args);
            Console.Read();
        }


        private static void Dispatch(string[] args)
        {
            using (var scope = Container.BeginLifetimeScope(cfg =>
            {
                cfg.RegisterInstance(CurrentUser);

            }))
            {
                var dispatch = scope.Resolve<IDispatcher>();
                
                
                
                var response = dispatch.Dispatch(args);
            }
        }
    }
}

