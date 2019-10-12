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
            Store store = new Store();
            Player player = new Player();
            Day day = new Day();
            UserInterface userInterface = new UserInterface();
        }


        //member methods
    }
}