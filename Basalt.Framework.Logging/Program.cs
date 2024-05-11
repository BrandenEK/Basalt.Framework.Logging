using Basalt.Framework.Logging.Standard;

namespace Basalt.Framework.Logging;

internal class Program
{
    static void Main(string[] args)
    {
        Logger.Initialize(new ILogger[]
        {
            new ConsoleLogger(false),
            new FileLogger(Environment.CurrentDirectory + "/test")
        },
        new Properties()
        {
            DisplayDebug = false
        });

        Logger.Info("Starting program");

        Logger.Error("Failure");

        Logger.Warn("Warning");

        Logger.Debug("Debug");

        Console.ReadKey();
    }
}
