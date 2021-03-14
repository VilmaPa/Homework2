using Homework2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Models
{
    public class User
    {
        private IAddUserMoney _addUserMoney;

        public User(IAddUserMoney addUserMoney)
        {
            _addUserMoney = addUserMoney;
        }
        public decimal Balance { get; set; }

        public void AddMoney(User user, decimal moneyAmount)
        {
            _addUserMoney.AddUserMoney(user, moneyAmount);
        }

    }
}
