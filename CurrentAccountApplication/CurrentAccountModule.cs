using Autofac;
using Banking;
using CurrentAccountApplication;

namespace CurrentAccountApplication
{

    public class CurrentAccountModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<User>().As<IUser>();
            builder.RegisterType<CurrentAccount>().As<IBankAccount>();
        }
    }

}