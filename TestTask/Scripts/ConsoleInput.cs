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
                Console.WriteLine(Messages.CreateMethod);
                Console.WriteLine(Messages.ConsoleInput);
                Console.WriteLine(Messages.JsonInput);

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            return ChestCreationMethod.ConsoleInput;
                        case 2:
                            return ChestCreationMethod.JsonInput;
                        default:
                            Console.WriteLine(Messages.InvalidInput);
                            return GetChestCreationMethod();
                    }
                }
                else
                {
                    Console.WriteLine(Messages.InvalidInput);
                    return GetChestCreationMethod();
                }

            }
        }

        public int GetChestNumber(int chestsLength)
        {

            Console.Write(Messages.OpenChest);
            Console.Write(" ( ");

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
                Console.WriteLine(Messages.InvalidInput);
                return GetChestNumber(chestsLength);
            }

        }

        public int GetChestLength()
        {
            Console.WriteLine(Messages.CreateChest);

            var input = Console.ReadLine();
            if (int.TryParse(input, out int chestLength) && chestLength >= 1)
            {
                return chestLength;
            }
            else
            {
                Console.WriteLine(Messages.InvalidInput);
                return GetChestLength();
            }
        }
    }
}
