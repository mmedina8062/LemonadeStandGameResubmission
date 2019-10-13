using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Customer
    {
        //member variables
        public int purchasingCustomer;
        
        //ctor
        public Customer()
        {
            this.purchasingCustomer = 0;
        }

        public Day Day
        {
            get => default;
            set
            {
            }
        }

        //member methods
        public void DetermineToBuyLemonade(Game game, Day day, Player player)
        {
            var weatherCondition = day.weather.GenerateWeatherCondition();
            var temperature = day.weather.GenerateTemperature();
            var price = game.player.SetPrice();

            if (weatherCondition == "Sunny" && temperature == 70 || temperature < 98 && price == 0.10 || price < 0.25)
            {
                if (game.player.SetIngredients)
                Random random = new Random();
                int randomNumber = random.Next(0, 150);
            }
            else if (weatherCondition == "Sunny & Windy" && temperature == 68 || temperature < 85 && price == 0.10 || price < 0.20)
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
        

            
            //else if (if different from above return random (0, 20)
          
       

    }
}