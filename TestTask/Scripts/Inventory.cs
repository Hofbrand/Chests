using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Inventory : ItemContainer
    {
        private static Inventory instance;

        private Inventory()
        {
        }

        public static Inventory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inventory();
                }

                return instance;
            }
        }

        public override void ShowContainerData()
        {
            Console.WriteLine("Inventory contains:");
            base.ShowContainerData();
        }
    }

    public enum Item
    {
        Sword, Coins, ManaPotion, HealPotion, Ring
    }
}
