using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Loggers
{
    public class MockLogger : ILogger
    {
        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string input)
        {
            //Do nothing
            //File.WriteAllText("/file", input);
        }
    }
}
