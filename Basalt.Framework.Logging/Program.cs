namespace Basalt.Framework.Logging;

internal class Program
{
    static void Main(string[] args)
    {
        Logger.Initialize();

        Logger.Info("Starting program");

        Logger.Error("Failure");

        Logger.Warn("Warning");

        Logger.Debug("Debug");

        Console.ReadKey();
    }
}
