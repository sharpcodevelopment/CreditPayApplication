﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditPayApplication
{
    public class BusinessCredits : IPayManager
    {
        public void Pay()
        {
           Console.Writeline("your loan is ready");
        }
    }
}
