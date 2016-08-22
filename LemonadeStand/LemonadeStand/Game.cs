using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        Recipe recipe = new Recipe();
        LostGame lost = new LostGame();
        public void startGame(Inventory inventory)
        {
            Console.WriteLine("Hello! This is Lemonade Stand. You will sell cups of lemonade to customers,");
            Console.WriteLine("there will be 15 cups to sell out of each pitcher.");
            Console.WriteLine("You need 10 Lemons, 1 bag of sugar, 1 sleeve of cups, and 1 bag of ice");
            Console.WriteLine("to make a pitcher.");
            Console.WriteLine("Make sure to consider the weather when buying your supplies");
            Console.WriteLine("and deciding on a price!");
            Console.WriteLine("   ");
            Console.WriteLine("Hint: Customers won't pay more than $2");
            Console.WriteLine("--------------------------------------------------------------------------------");
            List<Day> days = new List<Day>();
            int dayCount = 1;
            for (int i = 0; i < 7; i++)
            {
                
                    Day day = new Day();
                    days.Add(day);
                    Console.WriteLine("Welcome to day {0}!", dayCount++);
                    Console.WriteLine("    ");
                    inventory.getTotalInventory();
                    Console.WriteLine("You have ${0:0.00}", player.startingBank);
                    Console.WriteLine("    ");
                    day.weather.WeatherForecastOfTheDay();
                    Console.WriteLine("  ");
                    if (player.startingBank <= 0)
                    {
                        lost.Bankrupt();
                        i += 8;
                        break;
                    }
                    player.SetLemonInventory(inventory, recipe);
                    if (player.startingBank <= 0)
                    {
                        lost.Bankrupt();
                        i += 8;
                        break;
                    }
                    player.SetSugarInventory(inventory, recipe);
                    if (player.startingBank <= 0)
                    {
                        lost.Bankrupt();
                        i += 8;
                        break;
                    }
                    player.SetIceInventory(inventory, recipe);
                    if (player.startingBank <= 0)
                    {
                        lost.Bankrupt();
                        i += 8;
                        break;
                    }
                    player.SetCupInventory(inventory, recipe);
                    day.recipe.MakePitchers(inventory);
                    inventory.getTotalInventory();
                    player.chargePerCup();
                    day.weather.actualWeatherOfTheDay();
                    day.ListOfCustomers.listOfCustomers(day.weather, player, day.recipe, day.customer, inventory);
                    Console.WriteLine("you have ${0}", player.startingBank);
                    day.recipe.pitcherStatus(inventory, day.customer, day);
                    inventory.getTotalInventory();
                    Console.ReadLine();
                    Console.Clear();
                
            }
            Console.WriteLine("");
            Console.WriteLine("Game over! You made ${0}!", (player.startingBank - 20));
            Console.ReadLine();
            
        }

    }
    }

