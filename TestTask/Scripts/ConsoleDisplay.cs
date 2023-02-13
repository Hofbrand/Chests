using System;
using System.Collections.Generic;

namespace TestTask
{
    public class ConsoleDisplay : DisplayItems
    {
        public void Show(Dictionary<Item, int> items)
        {
            foreach (KeyValuePair<Item, int> item in items)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.WriteLine();
        }
    }
}
