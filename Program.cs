using Homework2.Helpers;
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
                        //case "balance":
                        //    Console.WriteLine($"{Message.currentBalance}{user.Balance}\n{Message.nextCommand}");
                        //    break;
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
                        //case "topup":
                        //    var amount = decimal.Parse(textArr[1]);
                        //    user.AddMoney(user, amount);
                        //    Console.WriteLine($"{Message.addedMoney + amount}{Message.nextCommand}");
                        //    break;
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
                    //startApp = false;
                    Console.WriteLine(e.Message);
                //    command = Console.ReadLine();
                //    var number = Decimal.Parse(command);
                //    Console.WriteLine($"NUMBER IS {number}");
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine($"Something gone wrong {ex.Message} please try again");
                }
            }

            //var shop = new Shop();
            //shop.ListItems();
            //shop.Buy("ItemName", 50);
            //shop.LoadItems("ItemName", 50);
            //var item = new Item()
            //{
            //    Name = "CUP",
            //    Price = 5,
            //    Quantity = 10
            //};
            //var item = new Candy()
            //{
            //    Name = "BEANS",
            //    Price = 2,
            //    Quantity = 20
            //};
            //var Cup1 = new Cup()
            //{
            //    Name = "RED",
            //    Price = 10,
            //    Quantity = 6
            //};
            //var Book1 = new Book()
            //{
            //    Name = "STORY",
            //    Price = 15,
            //    Quantity = 10
            //};

            //var sum = CalculationLibrary.SumNumbers(4, 5);
        }
    }
}
