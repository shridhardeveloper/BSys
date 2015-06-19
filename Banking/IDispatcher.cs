using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
   public interface  IDispatcher
    {
       object Dispatch(string[] args);
    }
}
