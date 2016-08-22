using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
public class Player
{
    public double startingBank;
    public double charge;
    public int playerBuys;
        LostGame lost = new LostGame();
    public Player()
    {
        this.startingBank = 20;
        
    }
        public void SetLemonInventory(Inventory inventory, Recipe recipe)
        {
            recipe.CanMakePitcher(inventory);
            Console.WriteLine("How many lemons would you like to buy? $.05 each");
            playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * .05 && startingBank >= .05)
            {
                Console.WriteLine("You dont have enough in the bank.");
                Console.WriteLine("You have {0:0.00}", startingBank);
                SetLemonInventory(inventory, recipe);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 10 lemons to make a pitcher");
                    inventory.getTotalInventory();
                    SetLemonInventory(inventory, recipe);
                    break;
                }
                
            }
            
            else if (playerBuys == 0)
            {
                inventory.getTotalInventory();

            }
            else
            {
                startingBank -= playerBuys * .05;
                inventory.lemonsAvailable += playerBuys;
                Console.WriteLine("you have ${0:0.00}", startingBank);
            }

        }

        public void SetSugarInventory(Inventory inventory, Recipe recipe)
        {
            recipe.CanMakePitcher(inventory);

            Console.WriteLine("How many bags of sugar would you like to buy? $1 each");
            playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * 1.00 && startingBank >= 1)
            {
                Console.WriteLine("You dont have enough in the bank.");
                Console.WriteLine("You have {0:0.00}", startingBank);
                SetSugarInventory(inventory, recipe);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 1 bag of sugar to make a pitcher");
                    inventory.getTotalInventory();
                    SetSugarInventory(inventory, recipe);
                    break;
                }
            }
            
            else if (playerBuys == 0)
            {
                inventory.getTotalInventory();
            }
            else
            {
                inventory.sugarAvailable += playerBuys;
                startingBank -= playerBuys * 1.00;
                Console.WriteLine("you have ${0:0.00} left", startingBank);
            }
        }

        public void SetIceInventory(Inventory inventory, Recipe recipe)
        {
            recipe.CanMakePitcher(inventory);

            Console.WriteLine("How many bags of ice would you like to buy? $1 each");
            playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * 1.00 && startingBank >= 1)
            {
                Console.WriteLine("You dont have enough in the bank.");
                Console.WriteLine("You have {0:0.00}", startingBank);
                SetIceInventory(inventory, recipe);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 1 bag of ice to make a pitcher");
                    inventory.getTotalInventory();
                    SetIceInventory(inventory, recipe);
                    break;
                }
            }
            
            else if (playerBuys == 0)
            {
                inventory.getTotalInventory();
            }
            else
            {
                inventory.iceAvailable += playerBuys;
                startingBank -= playerBuys * 1.00;
                Console.WriteLine("you have ${0:0.00}", startingBank);
            }
        }

        public void SetCupInventory(Inventory inventory, Recipe recipe)
        {
            recipe.CanMakePitcher(inventory);

            Console.WriteLine("How many sleeves of cups would you like to buy? 1.50 each");
            Convert.ToDouble(Console.ReadLine()); 
            if (startingBank < playerBuys * 1.50 && startingBank >= 1.5)
            {
                Console.WriteLine("You dont have enough in the bank.");
                Console.WriteLine("You have {0:0.00}", startingBank);
                SetCupInventory(inventory, recipe);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 1 sleeve of cups to make a pitcher");
                    inventory.getTotalInventory();
                    SetCupInventory(inventory, recipe);
                    break;
                }
            }
            
            else if (playerBuys == 0)
            {
                inventory.getTotalInventory();
            }
            else
            {
                inventory.cupsAvailable += playerBuys;
                startingBank -= playerBuys * 1.50;
                Console.WriteLine("you have ${0:0.00}", startingBank);
            }
        }
        public double userProfit()
    {
        Customer customer = new Customer();
        double customerChargeAmount = chargePerCup();
        this.startingBank += customerChargeAmount;
        return startingBank;
    }

    public double chargePerCup()
    {
        Console.WriteLine("How much would you like to charge per cup?");
        this.charge = Convert.ToDouble(Console.ReadLine());
        return charge;
    }

        
}
}
