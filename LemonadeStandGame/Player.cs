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

        public void SetIngredients()
        {
            throw new System.NotImplementedException();
        }

        public void SetPrice()
        {
            throw new System.NotImplementedException();
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