namespace TestTask
{
    public class Game
    {

        static void Main(string[] args)
        {
            Inventory inventory = Inventory.Instance;
            var input = new ConsoleInput();
            var Display =  new ConsoleDisplay();
            var ChestChancesData = new ChestChancesData();
            ChestGenerator chestGenerator = null;
            ChestChancesData data = null;

            int chestsAmount = input.GetChestLength();

            do
            {
                chestGenerator = ChestGenerator.GetChestGenerator(input.GetChestCreationMethod());
            }
            while (chestGenerator == null);

            data = ChestChancesData.GetChestChancesData(chestGenerator, chestsAmount);
            
            while (true)
            {
                var chestNumber = input.GetChestNumber(chestsAmount);
                Command command = new OpenChestCommand(chestNumber, data, inventory);
                command.Execute();
                inventory.ShowContainerData(Display);
            }
        }
    }
}