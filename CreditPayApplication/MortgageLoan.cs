using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditPayApplication
{
    public class MortgageLoan : IPayManager
    {
        public void Pay()
        {
            Console.WriteLine("paid");
        }
    }
}
