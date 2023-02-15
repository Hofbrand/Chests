using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    public class ChestChancesData
    {
        [JsonProperty("Chests")]
        private List<ChestChances> Chests;
        public ChestChancesData() { }

        public ChestChancesData GetChestChancesData(ChestGenerator chestGenerator, int chestsAmount)
        {
            return chestGenerator.Generate(chestsAmount);
        }

        public ChestChancesData(int chestsAmount)
        {
            CreateChestChancesData(chestsAmount);
        }
     
        public ChestChancesData(List<ChestChances> data)
        {
            Chests?.Clear();
            Chests = new List<ChestChances>();

            for (int i = 0; i < data.Count; i++)
            {
                Chests.Add(data[i]);
            }
        }

        public ChestChancesData CreateChestChancesData(int chestsAmount)
        {
            ChestChancesData chestChancesData = new ChestChancesData
            {
                Chests = new List<ChestChances>(chestsAmount)
            };

            for (int i = 0; i < chestsAmount; i++)
            {
                chestChancesData.Chests.Add(new ChestChances());   
            }

            return chestChancesData;
        }

        public ChestChances GetChestChances(int chestNumber)
        {
            return Chests[chestNumber - 1];
        }
    }

    public class ChestChances
    {
        public Dictionary<Item, int> items;

        public ChestChances()
        {
            items = new Dictionary<Item, int>();

            foreach (var item in Enum.GetValues(typeof(Item)).Cast<Item>())
            {
                this.items[item] = 100;
            }
        }

        public ChestChances(Dictionary<Item, int> items)
        {
            foreach(var item in Enum.GetValues(typeof(Item)).Cast<Item>())
            {
                this.items[item] = items[item];
            }
        }
    }
}
