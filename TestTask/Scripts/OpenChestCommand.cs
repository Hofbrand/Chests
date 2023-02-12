using System;

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
            ChestChances chestChances = null;
            switch (chestNumber)
            {
                case 1:
                    chestChances = chestChancesData.Chest1;
                    break;
                case 2:
                    chestChances = chestChancesData.Chest2;
                    break;
                case 3:
                    chestChances = chestChancesData.Chest3;
                    break;
            }

            if (chestChances == null)
            {
                Console.WriteLine("Chest with number {0} doesn't exist", chestNumber);
                return;
            }
            var Random = new Random();
            int randomNumber = Random.Next(1,100);
            if (randomNumber <= chestChances.Sword)
            {
                inventory.AddItem(Item.Sword);
            }
            randomNumber = new Random().Next(1, 100);

            if (randomNumber <= chestChances.Coins)
            {
                inventory.AddItem(Item.Coins);
            }
            randomNumber = new Random().Next(1, 100);
            if (randomNumber <= chestChances.ManaPotion)
            {
                inventory.AddItem(Item.ManaPotion);
            }
            randomNumber = new Random().Next(1, 100);

            if (randomNumber <= chestChances.HealPotion)
            {
                inventory.AddItem(Item.HealPotion);
            }
            randomNumber = new Random().Next(1, 100);
            if (randomNumber <= chestChances.Ring)
            {
                inventory.AddItem(Item.Ring);
            }
            Console.WriteLine("Chest number {0} is opened!", chestNumber);
         
        }
    }
    
}
