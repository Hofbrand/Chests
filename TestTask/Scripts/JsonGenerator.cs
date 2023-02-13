using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace TestTask
{
    public class JsonGenerator : ChestGenerator
    {
        private readonly string path = "chestChancesData.json";

        public void SaveChestChancesData(ChestChancesData chestChancesData)
        {
            string json = JsonConvert.SerializeObject(chestChancesData);

            File.WriteAllText(path, json);
        }

        public ChestChancesData GetChestChancesData(int chestsAmount)
        {
            if (!File.Exists(path))
            {
                SaveChestChancesData(new ChestChancesData().CreateChestChancesData(chestsAmount));
            }

            string json = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<ChestChancesData>(json);
        }

        public override ChestChancesData Generate(int chestsLength)
        {
            return  GetChestChancesData(chestsLength);
        }
    }
}
