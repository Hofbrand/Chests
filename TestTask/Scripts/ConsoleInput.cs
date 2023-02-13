using System;
using System.Collections.Generic;
using System.Linq;

namespace TestTask
{
    public class ConsoleInput : PlayersInput
    {

        public ChestCreationMethod GetChestCreationMethod()
        {
            {
                Console.WriteLine("How do you want to create the chances for the chests?");
                Console.WriteLine("1. Console Input");
                Console.WriteLine("2. JSON Input");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            return ChestCreationMethod.ConsoleInput;
                        case 2:
                            return ChestCreationMethod.JsonInput;
                        default:
                            Console.WriteLine("Invalid choice, please try again");
                            return GetChestCreationMethod();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                    return GetChestCreationMethod();
                }

            }
        }

        public int GetChestNumber(int chestsLength)
        {

            Console.Write("Enter the number of the chest you want to open ( ");
            for (int i = 1; i < chestsLength + 1; i++)
            {
                Console.Write(i + " ");
            }

            Console.Write(")");
            Console.WriteLine();

            var input = Console.ReadLine();
            if (int.TryParse(input, out int chestNumber) && chestNumber >= 1 && chestNumber <= chestsLength)
            {
                return chestNumber;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetChestNumber(chestsLength);
            }

        }

        public int GetChestLength()
        {
            Console.WriteLine("Enter the number of chests you want to create ");

            var input = Console.ReadLine();
            if (int.TryParse(input, out int chestLength) && chestLength >= 1)
            {
                return chestLength;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                return GetChestLength();
            }
        }
    }
}
