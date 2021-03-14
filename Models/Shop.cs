using Homework2.Interfaces;
using System;
using System.Collections.Generic;

namespace Homework2.Models
{
    public class Shop
    {
        private ILogger _logger;

        public Shop(ILogger logger)
        {
            _logger = logger;
        }

        private readonly object name;

        public string Name { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();


        public void ListItems()
        {

            foreach (var item in Items)
            {
                if (item.Quantity > 0)
                {
                    _logger.Write($"Product name: { item.Name}, price: { item.Price}, quantity in the shop {name}: { item.Quantity}");
                }
            }
        }

        public void  AddItems(string itemName, int amount)
        {
            foreach (var item in Items)
            {
                if ((item.Name).ToLower() == itemName)
                {
                    item.Quantity += amount;

                    _logger.Write("Succesfully added.");
                }
            }
            _logger.Write("No such product was found."); 
        }


        public void Buy(User user, string itemName, int amount)
        {
            foreach (var item in Items)
            {
                if (((item.Name).ToLower() == itemName)&&(item.Quantity >= amount))
                {
                    if (user.Balance >= amount * item.Price)
                    {
                        item.Quantity -= amount;
                        user.Balance -= amount * item.Price;

                        _logger.Write( "Succesfully bought.");
                    }
                }
            }
            _logger.Write("There are less items than you want to buy or balance is not enough. Please check.");
        }
    }
}