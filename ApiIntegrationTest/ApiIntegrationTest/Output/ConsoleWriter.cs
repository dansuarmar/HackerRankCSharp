﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntegrationTest.Output
{
    internal class ConsoleWriter : IConsoleWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
