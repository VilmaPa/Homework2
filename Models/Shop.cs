using System;
using System.Collections.Generic;

namespace Homework2.Models
{
    public class Shop
    {
        private readonly object name;

        public string Name { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();


        public void ListItems()
        {

            foreach (var item in Items)
            {
                if (item.Quantity > 0)
                {
                    Console.WriteLine($"Product name: { item.Name}, price: { item.Price}, quantity in the shop {name}: { item.Quantity}");
                }
            }
        }

        public string  AddItems(string itemName, int amount)
        {
            foreach (var item in Items)
            {
                if ((item.Name).ToLower() == itemName)
                {
                    item.Quantity += amount;

                    return "Succesfully added.";
                }
            }
            return "No such product was found."; 
        }


        public string Buy(string itemName, int amount)
        {
            foreach (var item in Items)
            {
                if (((item.Name).ToLower() == itemName)&&(item.Quantity >= amount))
                {
                    item.Quantity -= amount;

                    return "Succesfully bought.";
                }
            }
            return "There are less items than you want to buy.";
        }
    }
}