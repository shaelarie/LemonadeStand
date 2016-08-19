using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LemonadeStand
{
    public class CustomerList
    {
        Day day;
        public int startDay = 1;
        public int days = 7;
        public void listOfCustomers(Weather weather, Player player, Recipe recipe, Customer customer, Inventory inventory)
        {
            for (int i = 0; i < weather.maxNumberOfCustomers; i++)
            {
                Customer MakeCustomers = new Customer();
                List<Customer> customers = new List<Customer>() { MakeCustomers };


                foreach (Customer newCustomer in customers)
                {
                    recipe.pitcherStatus(inventory, customer, day);

                    if (customer.thirstLevel > 5)
                    {
                        customer.customerBuys = true;
                    }
                    else if (customer.thirstLevel <= 5)
                    {
                        customer.customerBuys = false;
                    }

                 customer.GetThirstLevel(weather);

                    if (recipe.pitcher == 0)
                    {
                        Console.WriteLine("Oops! You ran out of lemonade for the day! We'll start again tomorrow!");
                        inventory.iceAvailable -= inventory.iceAvailable;
                    }
                    else if (customer.customerBuys == true)
                    {
                        Console.WriteLine("customer bought");
                        player.startingBank += player.charge;
                        recipe.cupsInPitcher -= 1;
                    }

                    else
                    {
                        Console.WriteLine("customer did not buy");
                    }
                    break;
                }
                if(recipe.pitcher == 0)
                {
                    break;
                }
            }

            startDay++;
            if (startDay % 1 == 0)
            {
                Console.WriteLine("Your remaining ice has melted");
                inventory.iceAvailable -= inventory.iceAvailable;
            }
        }
    }
}
