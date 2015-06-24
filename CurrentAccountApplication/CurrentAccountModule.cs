using Autofac;
using Banking;
using CurrentAccountApplication;
using ManyConsole;
namespace CurrentAccountApplication
{

    public class CurrentAccountModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<User>().As<IUser>();
       //     builder.RegisterType<CurrentAccount>().As<IBankAccount>();
            builder.RegisterAssemblyTypes(typeof(CurrentAccount).Assembly)
               .AssignableTo<ConsoleCommand>()
               .As<ConsoleCommand>()
               .AsSelf();
        }

    }

}