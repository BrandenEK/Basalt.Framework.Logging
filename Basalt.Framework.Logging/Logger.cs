
namespace Basalt.Framework.Logging;

public static class Logger
{
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
        Console.ForegroundColor = color;
        Console.WriteLine(message);
    }
}
