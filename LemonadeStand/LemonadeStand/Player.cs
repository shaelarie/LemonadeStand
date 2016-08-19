using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
public class Player
{
                 
    public int playerBuys;
    public double startingBank;
    public double charge;
    

    public Player()
    {
            
        
        this.startingBank = 20;
            
    }        



    public void addInventory(Inventory inventory)
    {
        Recipe recipe = new Recipe();
        recipe.CanMakePitcher(inventory);
        Console.WriteLine("How many lemons would you like to buy? $.05 each");
        playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * .05)
            {
                Console.WriteLine("You dont have enough in the bank. Start over.");
                startingBank = 20;
                addInventory(inventory);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 10 lemons to make a pitcher");
                    inventory.getTotalInventory();
                    addInventory(inventory);
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
                Console.WriteLine("you have ${0} left", startingBank);
            }
            recipe.CanMakePitcher(inventory);

            Console.WriteLine("How many bags of ice would you like to buy? $1 each");
        playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * 1.00)
            {
                Console.WriteLine("You dont have enough in the bank. Start over.");
                startingBank = 20;
                addInventory(inventory);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 1 bag of ice to make a pitcher");
                    inventory.getTotalInventory();
                    addInventory(inventory);
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
                Console.WriteLine("you have ${0} left", startingBank);
            }
            recipe.CanMakePitcher(inventory);

            Console.WriteLine("How many sleeves of cups would you like to buy? 1.50 each");
        playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * 1.50)
            {
                Console.WriteLine("You dont have enough in the bank. Start over.");
                startingBank = 20;
                addInventory(inventory); 
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 1 sleeve of cups to make a pitcher");
                    inventory.getTotalInventory();
                    addInventory(inventory);
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
                Console.WriteLine("you have ${0} left", startingBank);
            }
            recipe.CanMakePitcher(inventory);

            Console.WriteLine("How many bags of sugar would you like to buy? $1 each");
        playerBuys = Convert.ToInt16(Console.ReadLine());
            if (startingBank < playerBuys * 1.00)
            {
                Console.WriteLine("You dont have enough in the bank. Start over.");
                startingBank = 20;
                addInventory(inventory);
            }
            else if (playerBuys == 0 && recipe.CanMakePitcher(inventory) == false)
            {
                while (recipe.CanMakePitcher(inventory) == false)
                {
                    Console.WriteLine("You need at least 1 bag of sugar to make a pitcher");
                    inventory.getTotalInventory();
                    addInventory(inventory);
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
                Console.WriteLine("you have ${0} left", startingBank);
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
