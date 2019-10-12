using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Weather
    {
        private int Temperature;
        private int WeatherConditions

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
            List<string> weather = new List<string> { "Rainy", "Sunny", "Cloudy", "Windy"};
            Random r = new Random();
            int index = r.Next(weather.Count);
            string randomString = weather[index];
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