

using System;
using System.Collections.Generic;
using TestTask.Scripts;

namespace TestTask
{
    public class ChestChancesData
    {
        public ChestChances Chest1 { get; set; }
        public ChestChances Chest2 { get; set; }
        public ChestChances Chest3 { get; set; }

        public static ChestChancesData GetChestChancesData(ChestCreationMethod method, PlayersInput input, JsonHandler jsonHandler)
        {
            ChestChancesData chestChancesData = null;
            switch (method)
            {
                case ChestCreationMethod.ConsoleInput:
                    chestChancesData = input.GetChestChancesDataFromConsole();
                    break;
                case ChestCreationMethod.UseExistingJson:
                    chestChancesData = jsonHandler.GetChestChancesData();
                    break;
                case ChestCreationMethod.WriteToJson:
                    chestChancesData = new ChestChancesData(
                        new ChestChances(10, 20, 30, 40, 50),
                        new ChestChances(30, 20, 10, 40, 50),
                        new ChestChances(50, 20, 30, 10, 40)
                    );
                    jsonHandler.SaveChestChancesData(chestChancesData);
                    break;
            }
            return chestChancesData;
        }

        public ChestChancesData() { }

        public ChestChancesData(ChestChances chest1, ChestChances chest2, ChestChances chest3)
        {
            Chest1 = chest1;
            Chest2 = chest2;
            Chest3 = chest3;
        }

    }

    public class ChestChances
    {
        public int Sword { get; set; }
        public int Coins { get; set; }
        public int ManaPotion { get; set; }
        public int HealPotion { get; set; }
        public int Ring { get; set; }

        public ChestChances()
        {
        }

        public ChestChances(int sword, int coins, int manaPotion, int healPotion, int ring)
        {
            Sword = sword;
            Coins = coins;
            ManaPotion = manaPotion;
            HealPotion = healPotion;
            Ring = ring;
        }
    }
}
