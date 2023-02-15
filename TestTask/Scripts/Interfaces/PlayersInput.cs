namespace TestTask
{
    public interface PlayersInput
    {
        ChestCreationMethod GetChestCreationMethod();
        int GetChestNumber(int chestsLength);
        int GetChestLength();
    }

    public enum ChestCreationMethod
    {
        ConsoleInput,
        JsonInput
    }
}
