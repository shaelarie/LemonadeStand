using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LemonadeStand
{
    class Game
    {
        Player player = new Player();
        public void startGame(Inventory inventory)
        {
            Console.WriteLine("saying something ");
            List<Day> days = new List<Day>();
            int dayCount = 1;
            for (int i = 0; i < 7; i++)
            {
                Day day = new Day();
                days.Add(day);
                Console.WriteLine("Welcome to day {0}", dayCount++);
                day.weather.WeatherForecastOfTheDay();
                player.addInventory(inventory);
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

            Console.WriteLine("Its been 7 days! you made ${0}!", (player.startingBank - 20));
            
        }

    }
    }

