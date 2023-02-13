using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    public abstract class ItemContainer
    {
        public Dictionary<Item, int> items;

        public virtual void AddItem(Item itemType)
        {
            if (items.ContainsKey(itemType))
            {
                items[itemType]++;
            }
              else
            {
                items.Add(itemType, 1);
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

        public Dictionary<Item, int> GetItemsDictionary()
        {
            return items;
        }

        public void ShowContainerData(DisplayItems concreteDisplay)
        {
            concreteDisplay.Show(GetItemsDictionary());
        }
    }
}
