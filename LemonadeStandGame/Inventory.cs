using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Inventory
    {
        //member variables
        public int Lemons;
        public int Sugar;
        public int IceCubes;
        public int Cups;



        public Player Player
        {
            get => default;
            set
            {
            }
        }

        public Inventory()
        {
            this.Lemons = 0;
            this.Sugar = 0;
            this.IceCubes = 0;
            this.Cups = 0;
        }
    }
}