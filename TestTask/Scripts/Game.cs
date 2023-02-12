using TestTask.Scripts;

namespace TestTask
{
    public class Game
    {

        static void Main(string[] args)
        {
            Inventory inventory = Inventory.Instance;
            PlayersInput input = new PlayersInput();
            var JsonHandler = new JsonHandler();
            ChestCreationMethod method = PlayersInput.GetChestCreationMethod();
            ChestChancesData data = ChestChancesData.GetChestChancesData(method, input, JsonHandler);

            while (true)
            {
                var chestNumber = input.GetChestNumber();
                Command command = new OpenChestCommand(chestNumber, data, inventory);
                command.Execute();
                inventory.ShowContainerData();
            }
        }
    }
}
