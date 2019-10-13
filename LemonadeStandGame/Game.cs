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
            Day day = new Day();
            Player player = new Player();
            Store store = new Store();
            UserInterface userInterface = new UserInterface();
        }


        //member methods
    }
}