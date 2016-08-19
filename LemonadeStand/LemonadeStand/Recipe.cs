using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
public class Recipe
{
    public int pitcher;
    public int cupsInPitcher;
    public bool canMakePitcher;
    
    public Recipe()
        {
            this.pitcher = 0;
            this.cupsInPitcher = 15;
        }


    public void MakePitchers(Inventory inventory)
    {

        if (CanMakePitcher(inventory) == true)
        {
                
                this.pitcher += 1;
                inventory.cupsAvailable -= 1;
                inventory.iceAvailable -= 1;
                inventory.sugarAvailable -= 1;
                inventory.lemonsAvailable -= 10;

         }
            getPitcher();
    }
        public void pitcherStatus(Inventory inventory, Customer customer, Day day)
        {
            getCupsInPitcher();
            getPitcher();
            if (cupsInPitcher == 0)
            {
                pitcher -= 1;

                if (CanMakePitcher(inventory) == true && cupsInPitcher == 0)
                {
                    this.pitcher += 1;
                    inventory.cupsAvailable -= 1;
                    inventory.iceAvailable -= 1;
                    inventory.sugarAvailable -= 1;
                    inventory.lemonsAvailable -= 10;
                }
            }
        }
        public int getPitcher()
        {
           return this.pitcher;
        }

        public int getCupsInPitcher()
        {
            return this.cupsInPitcher;
        }

        public bool CanMakePitcher(Inventory inventory)
        {
            if (inventory.cupsAvailable >= 1 && inventory.lemonsAvailable >= 10 &&
            inventory.sugarAvailable >= 1 && inventory.iceAvailable >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}

}

