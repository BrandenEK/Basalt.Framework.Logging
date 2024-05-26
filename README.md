# Logging Framework

Provides easy message logging and multiple standard logging implementations

```cs
internal class Program
{
    static void Main(string[] args)
    {
        LoggingProperties.DisplayDebug = false;
        Logger.AddLoggers(new ILogger[]
        {
            new ConsoleLogger("Console title"),
            new FileLogger(logPath)
        });

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
