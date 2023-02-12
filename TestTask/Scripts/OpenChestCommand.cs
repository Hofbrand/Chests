using System;

namespace TestTask
{
    public class OpenChestCommand : Command
    {
        private int chestNumber;
        public OpenChestCommand(int number) 
        { 
            chestNumber = number;
        }
        public void Execute(Chest[] chests)
        {
            Console.WriteLine("Hello");
            Console.WriteLine(chestNumber + "Chest number");
            chests[chestNumber-1].Open();
        }
    }
}
