using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Player
    {
        public int Wallet;
        public int Inventory;

        public Game Game
        {
            get => default;
            set
            {
            }
        }

        public Player()
        {
            
        }

        public void SetIngredients(Day day)
        {
            Console.WriteLine("Time to make your recipe, please select item to enter an amount you would like per pitcher: [1] Lemons, [2] Sugar, [3] Ice Cubes, [4] Cups, [5] exit");
            string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "Lemons":
                    AmountOfLemons(day);
                    break;

                case "Sugar":
                    AmountOfSugar(day);
                    break;

                case "Ice Cubes":
                    AmountOfIceCubes(day);
                    break;

                case "Cups":
                    AmountOfCups(day);
                    break;

                default:
                    SetIngredients(day);
                    break;
            }           
        }

        public void AmountOfLemons(Day day)
        {
            Console.WriteLine("Amount of Lemons/pitcher: ");
            string UserInput = Console.ReadLine();
            day.recipe.rLemons = int.Parse(UserInput);
            SetIngredients(day);
            
        }
        public void AmountOfSugar(Day day)
        {
            Console.WriteLine("Amount of Sugar/pitcher: ");
            string UserInput = Console.ReadLine();
            day.recipe.rSugar = int.Parse(UserInput);
            SetIngredients(day);
        }
        public void AmountOfIceCubes(Day day)
        {
            Console.WriteLine("Amount of Ice Cubes/pitcher: ");
            string UserInput = Console.ReadLine();
            day.recipe.rIceCubes = int.Parse(UserInput);
            SetIngredients(day);
        }
        public void AmountOfCups(Day day)
        {
            Console.WriteLine("Amount of Cups/pitcher: ");
            string UserInput = Console.ReadLine();
            day.recipe.rCups = int.Parse(UserInput);
            SetIngredients(day);
        }
        public double SetPrice()
        {
            Console.WriteLine("Price per Cup: ");
            string UserInput = Console.ReadLine();
            return double.Parse(UserInput);
        }

        public void WalletTransactions()
        {
            throw new System.NotImplementedException();
        }

        public void AdjustInventory()
        {
            throw new System.NotImplementedException();
        }
    }
}