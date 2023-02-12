using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Chest : ItemContainer
    {
        public void Open(Inventory inventory)
        {
           ShowContainerData();
           TransferItemsToInventory(inventory);
        }

        public override void ShowContainerData()
        {
            Console.WriteLine("Chest contains:");
            base.ShowContainerData();
        }

        public void TransferItemsToInventory(Inventory inventory)
        {
            foreach (KeyValuePair<Item, int> item in items)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    inventory.AddItem(item.Key);
                }
            }
            items.Clear();
        }
    }
}