using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditPayApplication
{
    public class PersonalFinanceCredit : IPayManager
    {
        public void Pay()
        {
            Console.WriteLine("your loan is ready");
        }
    }
}
