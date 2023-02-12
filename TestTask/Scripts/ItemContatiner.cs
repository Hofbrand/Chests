using System;
using System.Collections.Generic;

namespace TestTask
{
    public class ItemContainer
    {
        protected Dictionary<Item, int> items;

        public ItemContainer()
        {
            items = new Dictionary<Item, int>();
            items[Item.Sword] = 0;
            items[Item.Coins] = 0;
            items[Item.ManaPotion] = 0;
            items[Item.HealPotion] = 0;
            items[Item.Ring] = 0;
        }

        public void AddItem(Item itemType, int count)
        {
            if (items.ContainsKey(itemType))
            {
                items[itemType] += count;
            }
        }

        public void RemoveItem(Item itemType, int count)
        {
            if (items.ContainsKey(itemType) && items[itemType] >= count)
            {
                items[itemType] -= count;
            }
        }

        public int GetItemCount(Item itemType)
        {
            if (items.ContainsKey(itemType))
            {
                return items[itemType];
            }

            return 0;
        }

        public virtual void ShowContainerData()
        {
            foreach (KeyValuePair<Item, int> item in items)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.WriteLine();
        }
    }
}
