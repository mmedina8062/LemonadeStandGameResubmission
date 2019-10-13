using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStandGame
{
    public class Game
    {
        //member variables
        public Store store;
        public Player player;
        public Day day;
        public UserInterface userInterface;


        //ctor
        public Game()
        {
            day = new Day();
            player = new Player();
            store = new Store();
            userInterface = new UserInterface();
        }


        //member methods
    }
}