using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Weather
    {
        public int Temperature;
        public int WeatherConditions;

        public Day Day
        {
            get => default;
            set
            {
            }
        }

        public Weather()
        {

        }
        public string GenerateWeatherCondition()
        {
            List<string> weatherCondition = new List<string> { "Rainy", "Sunny", "Cloudy", "Windy", "Cloudy & Windy", "Sunny & Windy", "Rainy & Cloudy" };
            Random r = new Random();
            int index = r.Next(weatherCondition.Count);
            string randomString = weatherCondition[index];
            Console.WriteLine(randomString);
            Console.ReadLine();

            return randomString;
        }
        public int GenerateTemperature()
        {
            Random rnd = new Random();
            int Degrees = rnd.Next(50, 100);
            Console.WriteLine(Degrees);
            Console.ReadLine();

            return Degrees;
        }
    }
}