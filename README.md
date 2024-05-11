# Logging Framework

Provides easy message logging and multiple standard logging implementations

```cs
internal class Program
{
    static void Main(string[] args)
    {
        var loggers = new ILogger[]
        {
            new ConsoleLogger(false)
        };
        var properties = new Basalt.Framework.Logging.Properties()
        {
            DisplayDebug = false
        };

        Logger.Initialize(loggers, properties);

        Logger.Info("Test info");
        Logger.Warn("Test warning");
        Logger.Error("Test error");
        Logger.Debug("Test debug");
    }
}
```

### Standard implementations
- ```ConsoleLogger```: Logs messages to a console window
- ```FileLogger```: Logs messages to a 'Latest.log' file
