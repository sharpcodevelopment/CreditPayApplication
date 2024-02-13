using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditPayApplication
{
    public class Applications 
    {
        IPayManager _payManager;
        ILoggerManager _loggerManager;
        public Applications(IPayManager payManager, ILoggerManager loggerManager)
        {
            _payManager = payManager;
            _loggerManager = loggerManager;
        }


        public void Pay()
        {
            _payManager.Pay();
            _loggerManager.Log();
            
        }


    }
}
