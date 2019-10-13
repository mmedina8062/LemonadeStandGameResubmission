using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Customer
    {
        //member variables
        public int buyingCustomers;
        public Random determinePurchasingCustomers;
        public double todaysProfit;

        //ctor
        public Customer()
        {
            this.buyingCustomers = 0;
        }

        public Day Day
        {
            get => default;
            set
            {
            }
        }

        //member methods
        public void DetermineToBuyLemonade(Game game, Day day, Player player, int customers)
        {
            //var weatherCondition = day.weather.GenerateWeatherCondition();
            //var temperature = day.weather.GenerateTemperature();
            //var price = game.player.SetPrice();

            if (day.weather.GenerateWeatherCondition() == "Sunny" && day.weather.GenerateTemperature() == 70 || day.weather.GenerateTemperature() < 98 && game.player.SetPrice() == 0.10 || game.player.SetPrice() < 0.25)
            {
                if (Convert.ToInt32(game.day.recipe) == CustomerClassOne())
                {
                    buyingCustomers = determinePurchasingCustomers.Next(0, 150);
                    todaysProfit = buyingCustomers * game.player.SetPrice(); 
                }
                else if (Convert.ToInt32(game.day.recipe) > CustomerClassOne())
                {
                    Random buyingCustomers = new Random();
                    int BuyingCustomers = buyingCustomers.Next(0, 75);
                }
                
            }
            else if (day.weather.GenerateWeatherCondition() == "Sunny & Windy" && day.weather.GenerateTemperature() == 68 || day.weather.GenerateTemperature() < 85 && game.player.SetPrice() == 0.10 || game.player.SetPrice() < 0.20)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 100);
            }
            else
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 50);
            }
        }
        public int CustomerClassOne()
        {
            Random lemons = new Random();
            int Lemons = lemons.Next(4, 8);
            return Lemons;
        }

            
            //else if (if different from above return random (0, 20)
          
       

    }
}