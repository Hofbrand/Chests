using System.Runtime.InteropServices.WindowsRuntime;

namespace TestTask
{
    public abstract class ChestGenerator
    {
        public abstract ChestChancesData Generate(int chestsLength);

        public static ChestGenerator GetChestGenerator(ChestCreationMethod creationMethod)
        {
            switch (creationMethod)
            {
                case ChestCreationMethod.ConsoleInput:
                    return new ConsoleGenerator();
                case ChestCreationMethod.JsonInput:
                    return new JsonGenerator();
                default:
                    return null;
            }
        }
    }
}
