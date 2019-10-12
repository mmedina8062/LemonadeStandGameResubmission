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

            Player player = new Player();
            Store store = new Store();
            Day day = new Day();
            UserInterface userInterface = new UserInterface();
        }


        //member methods
    }
}