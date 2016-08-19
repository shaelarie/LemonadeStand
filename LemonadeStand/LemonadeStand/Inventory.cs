using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int lemonsAvailable;
        public int iceAvailable;
        public int sugarAvailable;
        public int cupsAvailable;

        public Inventory()
        {
            this.lemonsAvailable = 0;
            this.cupsAvailable = 0;
            this.iceAvailable = 0;
            this.sugarAvailable = 0;
        }



        public double getLemonInventory()
        {
            return this.lemonsAvailable;

        }

        public int getIceInventory()
        {
            return this.iceAvailable;
        }

        public int getCupInventory()
        {
            return this.cupsAvailable;
        }

        public double getSugarInventory()
        {
            return this.sugarAvailable;
        }

        public void getTotalInventory()
        {

            Console.WriteLine("You have {0} lemons, {1} cups of sugar, {2} cubes of ice," +
                " and {3} cups left.", lemonsAvailable, iceAvailable, cupsAvailable, sugarAvailable);

        }
    }
}
