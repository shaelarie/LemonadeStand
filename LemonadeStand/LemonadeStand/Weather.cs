using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public Random dailyWeather = new Random();
        List<string> forecastOptions = new List<string>() {"Sunny", "Cloudy" };
        public int actualTemerature;
        string forecast;
        int highTemperature;
        public int days;
        public int startDay = 1;
        public int maxNumberOfCustomers;
        public Weather()
        {
            
                this.highTemperature = (dailyWeather.Next(37, 95));
                this.forecast = forecastOptions[(dailyWeather.Next(0, forecastOptions.Count))];
               
        }

        
        
        public void WeatherForecastOfTheDay()
        {               
                
                this.highTemperature = (dailyWeather.Next(37, 95));
                this.forecast = forecastOptions[(dailyWeather.Next(0, forecastOptions.Count))];
                Console.WriteLine("The weather will be {1} with a high of {0} degrees", highTemperature, forecast);
                                
         }

        public void actualWeatherOfTheDay()
        {
            
            if (highTemperature <= 58)
            {
                this.actualTemerature = (dailyWeather.Next(37, 58));
                this.maxNumberOfCustomers = 40;

            }
            else if (highTemperature <= 70 && highTemperature > 58)
            {
                this.actualTemerature = (dailyWeather.Next(59, 70));
                this.maxNumberOfCustomers = 90;

            }
            else if (highTemperature > 71)
            {
                this.actualTemerature = (dailyWeather.Next(71, 95));
                this.maxNumberOfCustomers = 150;
                

            }
            Console.WriteLine("Today is {0} degrees and {1} ", actualTemerature, forecast);
            
        }

        public double GetActualTempature()
        {
            return actualTemerature;
        }
        public int getMaxNumberOfCustomers()
        {
            return maxNumberOfCustomers;
        }
     

        }
    }

