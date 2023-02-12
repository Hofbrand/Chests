using System;
using TestTask.Scripts;

namespace TestTask
{
    public class Game
    {
        static void Main(string[] args)
        {
            Inventory inventory = Inventory.Instance;

            PlayersInput input = new PlayersInput();

            Chest[] chests = new Chest[3];
            for (int i = 0; i < 3; i++)
            {
                chests[i] = new Chest();
                chests[i].AddItem(Item.Coins, i * 10);
                chests[i].AddItem(Item.ManaPotion, i * 5);
            }

            while (true)
            {
                Console.WriteLine("You've got 3 chests");
                Console.WriteLine("1" + " 2" + " 3");
                Console.WriteLine("Print number of chest which you would like to open");

                Command inputCommand;
                do
                {
                    inputCommand = input.HandleInput();
                }
                while (inputCommand == null);

                inputCommand.Execute(chests);
            }
        }
    }
}
