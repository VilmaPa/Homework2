using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Write(string input)
        {
            System.Console.WriteLine(input);
        }
        public string Read()
        {
            return Console.ReadLine().Trim().ToLower();
        }
    }
}
