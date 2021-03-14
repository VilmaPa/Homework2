using Homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Interfaces
{
    public interface IAddUserMoney
    {
        void AddUserMoney(User user, decimal amount);
    }
}
