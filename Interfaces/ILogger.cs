using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Interfaces
{
    public interface ILogger
    {
        void Write(string input);

        string Read();
    }
}
