﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService:ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
