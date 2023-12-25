using P001_SingletonPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Task.Run(() => CallPrintSpoolerThreadSafe("Document 1"));
        Task.Run(() => CallPrintSpoolerThreadSafe("Document 2"));

        Thread.Sleep(200);

        static void CallPrintSpoolerThreadSafe(string document)
        {
            PrintSpoolerThreadSafe spooler = PrintSpoolerThreadSafe.GetInstance();
            spooler.Print(document);
        }
    }
}