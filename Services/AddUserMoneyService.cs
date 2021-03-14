using Homework2.Interfaces;
using Homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Services
{
    public class AddUserMoneyService : IAddUserMoney
    {
        public void AddUserMoney(User user, decimal amount)
        {
            user.Balance += amount;
        }
    }
}
