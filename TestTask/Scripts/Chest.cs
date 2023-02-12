using System;
using System.Collections.Generic;

namespace TestTask
{
    public class Chest : ItemContainer
    {
        public void Open()
        {
           ShowContainerData();
        }

        public override void ShowContainerData()
        {
            Console.WriteLine("Chest contains:");
            base.ShowContainerData();
        }
    }
}