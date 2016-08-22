using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace LemonadeStand
{
    public class Customer
    {
        Random randomGen = new Random();
        public double thirstLevel;
        public int minNumberOfCustomers = 1;
        public bool customerBuys;
        public int pickThirstLevel;
        public double priceWillingToPay;
        public int WillingToPayDecision;

        public Customer()
        {
            thirstLevel = (randomGen.Next(0, 10));
        }
        public double GetThirstLevel(Weather weather)
        {


            if (weather.GetActualTempature() > 67)
            {
                List<Tuple<int, double>> ThirstLevel = new List<Tuple<int, double>>();
                ThirstLevel.Add(new Tuple<int, double>(1, 0));
                ThirstLevel.Add(new Tuple<int, double>(3, 1));
                ThirstLevel.Add(new Tuple<int, double>(3, 2));
                ThirstLevel.Add(new Tuple<int, double>(4, 3));
                ThirstLevel.Add(new Tuple<int, double>(4, 4));
                ThirstLevel.Add(new Tuple<int, double>(6, 5));
                ThirstLevel.Add(new Tuple<int, double>(9, 6));
                ThirstLevel.Add(new Tuple<int, double>(9, 7));
                ThirstLevel.Add(new Tuple<int, double>(9, 8));
                ThirstLevel.Add(new Tuple<int, double>(9, 9));
                ThirstLevel.Add(new Tuple<int, double>(9, 10));

                thirstLevel = (randomGen.Next(0, 10));
                foreach (var levelOfThirst in ThirstLevel)
                {
                    if (levelOfThirst.Item1 >= thirstLevel)
                        thirstLevel = levelOfThirst.Item2;
                    return thirstLevel;

                }
                
            }

            else if (weather.GetActualTempature() <= 67)
            {
                List<Tuple<int, double>> ThirstLevel = new List<Tuple<int, double>>();
                ThirstLevel.Add(new Tuple<int, double>(8, 0));
                ThirstLevel.Add(new Tuple<int, double>(8, 1));
                ThirstLevel.Add(new Tuple<int, double>(8, 2));
                ThirstLevel.Add(new Tuple<int, double>(7, 3));
                ThirstLevel.Add(new Tuple<int, double>(5, 4));
                ThirstLevel.Add(new Tuple<int, double>(4, 5));
                ThirstLevel.Add(new Tuple<int, double>(4, 6));
                ThirstLevel.Add(new Tuple<int, double>(4, 7));
                ThirstLevel.Add(new Tuple<int, double>(4, 8));
                ThirstLevel.Add(new Tuple<int, double>(4, 9));
                ThirstLevel.Add(new Tuple<int, double>(4, 10));

                thirstLevel = (randomGen.Next(0, 10));
                foreach (var levelOfThirst in ThirstLevel)
                {
                    if (levelOfThirst.Item1 >= thirstLevel)
                        thirstLevel = levelOfThirst.Item2;
                    return thirstLevel;

                }

            }
            return thirstLevel;
        }

        public double GetWillingToPay()
        {
            
            if(thirstLevel >= 5)
            {
                priceWillingToPay = 2;
            }

            else if (thirstLevel >= 4 && thirstLevel < 5)
            {
                priceWillingToPay = 1.75;
            }
            else if (thirstLevel < 4 && thirstLevel > 3)
            {
                priceWillingToPay = .75;
            }

            else if (thirstLevel <= 3)
            {
                priceWillingToPay = 0;
            }
            return this.priceWillingToPay;
                    
        }


    }
}