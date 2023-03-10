using System;
using System.Linq;

namespace TestTask
{
    public class OpenChestCommand : Command
    {
        private Inventory inventory;
        private ChestChancesData chestChancesData;
        private int chestNumber;

        public OpenChestCommand(int chestNumber, ChestChancesData chestChances, Inventory inventory)
        {
            this.chestNumber = chestNumber;
            this.chestChancesData = chestChances;
            this.inventory = inventory;
        }

        public void Execute()
        {
            ChestChances chestChances = chestChancesData.GetChestChances(chestNumber);

            if (chestChances == null)
            {
                Console.WriteLine($"{Messages.ChestWithNumber} {chestNumber} {Messages.DoesntExist}");
                return;
            }

            var random = new Random();
            foreach (Item item in Enum.GetValues(typeof(Item)).Cast<Item>())
                AddItemIfChanceMet(random, chestChances.items[item], item);

            Console.WriteLine($"{Messages.Chest} {chestNumber} {Messages.IsOpened}");
        }

        private void AddItemIfChanceMet(Random random, int chance, Item item)
        {
            if (random.Next(1, 100) <= chance)
            {
                inventory.AddItem(item);
            }
        }
    }
}
