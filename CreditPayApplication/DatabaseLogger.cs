﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditPayApplication
{
    public class DatabaseLogger : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("send to Database");
        }
    }
}
