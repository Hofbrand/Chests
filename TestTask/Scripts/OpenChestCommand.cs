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
            chests[chestNumber-1].Open();
        }
    }
}
