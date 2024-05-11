
namespace Basalt.Framework.Logging;

public static class Logger
{
    private static bool _initialized = false;

    private static Properties? _properties;

    public static void Initialize(Properties properties)
    {
        if (_initialized)
            throw new InvalidOperationException("Logging framework has already been initialized");

        if (properties is null)
            throw new ArgumentNullException(nameof(properties));

        _properties = properties;
        _initialized = true;
    }

    public static void Initialize() => Initialize(new Properties());

    public static void Info(object message)
    {
        LogToConsole(message, ConsoleColor.White);
    }

    public static void Warn(object message)
    {
        LogToConsole(message, ConsoleColor.Yellow);
    }

    public static void Error(object message)
    {
        LogToConsole(message, ConsoleColor.Red);
    }

    public static void Debug(object message)
    {
        LogToConsole(message, ConsoleColor.Cyan);
    }

    private static void LogToConsole(object message, ConsoleColor color)
    {
        if (!_initialized)
            throw new InvalidOperationException("Logging framework has not been initialized");

        Console.ForegroundColor = color;
        Console.WriteLine(message);
    }
}
