using System;

namespace TestTask.Scripts
{
    public class PlayersInput
    {
        public int GetChestNumber()
        {
            Console.WriteLine("Enter the number of the chest you want to open (1, 2, or 3): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int chestNumber) && chestNumber >= 1 && chestNumber <= 3)
            {
                return chestNumber;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetChestNumber();
            }
        }

        public static ChestCreationMethod GetChestCreationMethod()
        {
            Console.WriteLine("How do you want to create the chances for the chests?");
            Console.WriteLine("1. Console Input");
            Console.WriteLine("2. Write to JSON");
            Console.WriteLine("3. Using existing JSON");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return ChestCreationMethod.ConsoleInput;
                case 2:
                    return ChestCreationMethod.WriteToJson;
                case 3:
                    return ChestCreationMethod.UseExistingJson;
                default:
                    Console.WriteLine("Invalid choice, please try again");
                    return GetChestCreationMethod();
            }
        }

        public ChestChancesData GetChestChancesDataFromConsole()
        {
            ChestChances chest1 = GetChestChancesFromConsole("Chest 1");
            ChestChances chest2 = GetChestChancesFromConsole("Chest 2");
            ChestChances chest3 = GetChestChancesFromConsole("Chest 3");
            ChestChancesData chestChancesData = new ChestChancesData(chest1, chest2, chest3);
            return chestChancesData;
        }

        private ChestChances GetChestChancesFromConsole(string chestName)
        {
            Console.WriteLine("Enter chance of Sword in {0} :", chestName);
            int sword = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chance of Coins in {0} :", chestName);
            int coins = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chance of ManaPotion in {0} :", chestName);
            int manaPotion = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chance of HealPotion in {0} :", chestName);
            int healPotion = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter chance of Ring in {0} :", chestName);
            int ring = int.Parse(Console.ReadLine());
            ChestChances chestChances = new ChestChances(sword, coins, manaPotion, healPotion, ring);
            return chestChances;
        }
    }

    public enum ChestCreationMethod
    {
        ConsoleInput,
        WriteToJson,
        UseExistingJson
    }
}
