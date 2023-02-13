using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    public class Inventory : ItemContainer
    {
        private static Inventory instance;

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

        public Inventory()
        {
            items = new Dictionary<Item, int>();
            foreach (Item itemType in Enum.GetValues(typeof(Item)).Cast<Item>())
            {
                items[itemType] = 0;
            }
        }
    }

    public enum Item
    {
        Sword
    }
}
