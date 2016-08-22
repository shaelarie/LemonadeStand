using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public double lemonsAvailable;
        public double iceAvailable;
        public double sugarAvailable;
        public double cupsAvailable;

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

        public double getIceInventory()
        {
            return this.iceAvailable;
        }

        public double getCupInventory()
        {
            return this.cupsAvailable;
        }

        public double getSugarInventory()
        {
            return this.sugarAvailable;
        }

        public void getTotalInventory()
        {

            Console.WriteLine("You have {0} lemons, {1} bags of sugar, {2} bags of ice," +
                " and {3} cups.", lemonsAvailable, sugarAvailable, iceAvailable, cupsAvailable);

        }
    }
}
