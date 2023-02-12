using System;
using TestTask.Scripts;

namespace TestTask
{
    public class Game
    {
        static void Main(string[] args)
        {
            PlayersInput input = new PlayersInput();
            Chest[] chests = new Chest[3];
            for (int i= 0; i < chests.Length; i++)
            {
                chests[i] = new Chest();
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
