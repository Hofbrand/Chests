using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    public class ConsoleGenerator : ChestGenerator
    {
        public override ChestChancesData Generate(int chestsLength)
        {
            List<ChestChances> chestChancesList = new List<ChestChances>();

            for (int i = 0; i < chestsLength; i++)
            {
                chestChancesList.Add(InputChestChances($"{Messages.Chest} {i+1}"));
            }

            return new ChestChancesData(chestChancesList);
        }

        public ChestChances InputChestChances(string chestName)
        {
            ChestChances chestChances = new ChestChances();

            foreach (var item in Enum.GetValues(typeof(Item)).Cast<Item>())
            {
                chestChances.items[item] = InputItemChestChances(chestName, item);
            }

            return chestChances;
        }

        private int InputItemChestChances(string chestName, Item item)
        {

            Console.WriteLine($"{Messages.EnterChance} {item} {Messages.In} {chestName} :");

            if (!int.TryParse(Console.ReadLine(), out int data))
            {
                InputChestChances(chestName);
            }

            return data;
        }

    }
}
