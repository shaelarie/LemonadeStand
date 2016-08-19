using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LemonadeStand
{
    public class Customer
    {
        Random randomGen = new Random();
        public double thirstLevel;
        public int minNumberOfCustomers = 1;
        public bool customerBuys;
        public int pickThirstLevel;

        public Customer()
        {
            thirstLevel = (randomGen.Next(0,10));
        }
        public double GetThirstLevel(Weather weather)
        {

            
            if (weather.GetActualTempature() >= 70)
            {
                List<Tuple<int, int>> ThirstLevel = new List<Tuple<int, int>>();
                ThirstLevel.Add(new Tuple<int, int>(1, 0));
                ThirstLevel.Add(new Tuple<int, int>(4, 1));
                ThirstLevel.Add(new Tuple<int, int>(5, 2));
                ThirstLevel.Add(new Tuple<int, int>(5, 3));
                ThirstLevel.Add(new Tuple<int, int>(5, 4));
                ThirstLevel.Add(new Tuple<int, int>(5, 5));
                ThirstLevel.Add(new Tuple<int, int>(8, 6));
                ThirstLevel.Add(new Tuple<int, int>(8, 7));
                ThirstLevel.Add(new Tuple<int, int>(8, 8));
                ThirstLevel.Add(new Tuple<int, int>(8, 9));
                ThirstLevel.Add(new Tuple<int, int>(8, 10));

                thirstLevel = (randomGen.Next(0, 10));
                foreach (var levelOfThirst in ThirstLevel)
                {
                    if (levelOfThirst.Item1 > thirstLevel)
                        thirstLevel = levelOfThirst.Item2;
                        return thirstLevel;
                    
                }
                return thirstLevel;
                }

            else
            thirstLevel = (randomGen.Next(0, 10));
            return thirstLevel;

        }


        

        



    }
}
        

