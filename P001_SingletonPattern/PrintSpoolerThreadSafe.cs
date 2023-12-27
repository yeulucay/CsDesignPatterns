namespace P001_SingletonPattern;

public class PrintSpoolerThreadSafe
{
    private static volatile PrintSpoolerThreadSafe? instance;
    private static readonly object syncRoot = new();

    private PrintSpoolerThreadSafe()
    {
    }

    public static PrintSpoolerThreadSafe GetInstance()
    {
        if (instance is null)
        {
            lock (syncRoot)
            {
                instance ??= new PrintSpoolerThreadSafe();
            }
        }

        return instance;
    }

    public void Print(string document)
    {
        Console.WriteLine($"Printing: {document}");
    }
}