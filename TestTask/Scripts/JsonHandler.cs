using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TestTask
{
    public class JsonHandler
    {
        private readonly string path = "chestChancesData.json";

        public void SaveChestChancesData(ChestChancesData chestChancesData)
        {
            string json = JsonConvert.SerializeObject(chestChancesData);

            File.WriteAllText(path, json);
        }

        public ChestChancesData CreateChestChancesData()
        {
            ChestChancesData chestChancesData = new ChestChancesData
            {
                Chest1 = new ChestChances
                {
                    Sword = 100,
                    Coins = 100,
                    ManaPotion = 100,
                    HealPotion = 100,
                    Ring = 100
                },
                Chest2 = new ChestChances
                {
                    Sword = 10,
                    Coins = 40,
                    ManaPotion = 20,
                    HealPotion = 20,
                    Ring = 10
                },
                Chest3 = new ChestChances
                {
                    Sword = 25,
                    Coins = 20,
                    ManaPotion = 15,
                    HealPotion = 25,
                    Ring = 15
                }
            };

            return chestChancesData;
        }


            public ChestChancesData GetChestChancesData()
        {
            if (!File.Exists(path))
            {
                SaveChestChancesData(new ChestChancesData());
            }

            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ChestChancesData>(json);
        }
    }
}
