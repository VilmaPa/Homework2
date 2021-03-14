using Homework2.Models;
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var shop = new Shop() { Name = "Maxima" };
            //first products in the shop
            shop.Items.Add(new Item(){ Name = "Cup", Price = 9.20M, Quantity = 30});
            shop.Items.Add(new Item(){ Name = "Candy", Price = 1.00M, Quantity = 50});
            shop.Items.Add(new Item(){ Name = "Book", Price = 19.10M, Quantity = 15});
            bool commandExit = true;
            while (commandExit)
            {
                Console.WriteLine($"This is shop {shop.Name}.\nList - Displays available items\nBuy - Buy wanted amount of the item\nAdd - Increases amount of items\nExit - Exits the program.\n");

                try
                {
                    string command = Console.ReadLine().Trim().ToLower();
                    
                    switch (command)
                    {
                        case "add":
                            Console.WriteLine("Please, enter what type of item you want to add : cup, candy or book and amount.e g 'cup 10' ");
                            string itemTypeAndAmount = Console.ReadLine().Trim().ToLower();
                            string[] addItemType = itemTypeAndAmount.Split(' ');
                            var addItem = addItemType[0];
                            var addAmount = int.Parse(addItemType[1]);
                            Console.WriteLine($"{shop.AddItems(addItem, addAmount)}");
                            break;
                        case "buy":
                            Console.WriteLine("Please, enter what type of item you want to buy : cup, candy or book and amount.e g 'cup 10' ");
                            string itemTypeAndAmount2 = Console.ReadLine().Trim().ToLower();
                            string[] addItemType2 = itemTypeAndAmount2.Split(' ');
                            var buyItem = addItemType2[0];
                            var buyAmount = int.Parse(addItemType2[1]);
                            Console.WriteLine($"{shop.Buy(buyItem, buyAmount)}");
                            break;
                        case "list":
                            shop.ListItems();
                            break;
                        case "exit":
                            commandExit = false;
                            break;
                        default:
                            throw new InvalidOperationException();
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("error");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
