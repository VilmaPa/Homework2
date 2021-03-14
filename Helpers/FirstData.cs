using Homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.Helpers
{
    public class FirstData
    {
        //first products and user balance in the shop
        public static void FirstDataCreation(Shop shop, User user)
        {
            shop.Items.Add(new Item() { Name = "Cup", Price = 9.20M, Quantity = 30 });
            shop.Items.Add(new Item() { Name = "Candy", Price = 1.00M, Quantity = 50 });
            shop.Items.Add(new Item() { Name = "Book", Price = 19.10M, Quantity = 15 });
            user.AddMoney(user, 20);
        }
    }
}
