using System;
using Autofac;
using System.Collections.Generic;
using ManyConsole;
using Banking;
using System.Linq;

namespace CurrentAccountApplication
{
    internal class CurrentAccountDispatcher :IDispatcher
    {
         readonly ILifetimeScope _scope;
         


        public CurrentAccountDispatcher(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public IEnumerable<ConsoleCommand> GetCommands()
        {
            return _scope.Resolve<IEnumerable<ConsoleCommand>>()
                .OrderBy(c => c.Command);
        }

        public object Dispatch(string[] args)
        {

           var response = ConsoleCommandDispatcher.DispatchCommand(GetCommands(), args, Console.Out);
            return response;
        }
    }
}
