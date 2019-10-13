using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Recipe
    {
        public int rLemons;
        public int rSugar;
        public int rIceCubes;
        public int rCups;
        public Day Day
        {
            get => default;
            set
            {
            }
        }

        public Recipe()
        {
            this.rLemons = 0;
            this.rSugar = 0;
            this.rIceCubes = 0;
            this.rCups = 0;
        }
        public void DisplayRecipe()
        {

        }
    }

}