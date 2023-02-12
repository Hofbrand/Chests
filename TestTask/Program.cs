using System;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You've got 3 chests");
            Console.WriteLine("1" + " 2" + " 3");
            Console.WriteLine("Print number of chest which you would like to open");
            var chestToOpen =Console.ReadLine();
            Console.WriteLine($"You choose the chest number {chestToOpen}");
        }
    }
}
