using Homework2.Helpers;
using Homework2.Interfaces;
using Homework2.Loggers;
using Homework2.Models;
using Homework2.Services;
using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            IAddUserMoney addUserMoney = new AddUserMoneyService();
            var shop = new Shop(logger) { Name = "Maxima" };
            var user = new User(addUserMoney);
            FirstData.FirstDataCreation(shop, user);
            bool commandExit = true;

            while (commandExit)
            {
                logger.Write($"This is shop {shop.Name}.\nBalance - Displays user balance\nTopup - Increase balance by .. EUR\nList - Displays available items\nBuy - Buy wanted amount of the item\nAdd - Increases amount of items\nExit - Exits the program.\n");

                try
                {
                    string command = logger.Read();
                    
                    switch (command)
                    {
                        case "add":
                            logger.Write("Please, enter what type of item you want to add : cup, candy or book and amount.e g 'cup 10' ");
                            string[] addItemType = logger.Read().Split(' ');
                            var addItem = addItemType[0];
                            var addAmount = int.Parse(addItemType[1]);
                            shop.AddItems(addItem, addAmount);
                            break;
                        case "buy":
                            logger.Write("Please, enter what type of item you want to buy : cup, candy or book and amount.e g 'cup 10' ");
                            string[] addItemTypeAndAmount = logger.Read().Split(' ');
                            var buyItem = addItemTypeAndAmount[0];
                            var buyAmount = int.Parse(addItemTypeAndAmount[1]);
                            shop.Buy(user, buyItem, buyAmount);
                            break;
                        case "list":
                            shop.ListItems();
                            break;
                        case "balance":
                            logger.Write($"User balance: { user.Balance}");
                            break;
                        case "topup":
                            logger.Write("Please, enter amount");
                            var amount = decimal.Parse(logger.Read());
                            user.AddMoney(user, amount);
                            logger.Write($"New balance {user.Balance}");
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
                    logger.Write("error");
                }
                catch (Exception e)
                {
                    logger.Write(e.Message);
                }
            }

        }
    }
}
