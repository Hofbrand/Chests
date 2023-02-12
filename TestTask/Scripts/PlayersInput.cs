using System;
using System.Data;
using System.Diagnostics;

namespace TestTask.Scripts
{
    public class PlayersInput
    {

        public Command HandleInput()
        {
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out int number))
            {
                Console.WriteLine(number);
                if (number > 0 && number < 4)
                    return new OpenChestCommand(number);
                else return null;
            }
            else
            {
                return null;
            }
        }
    }
}
