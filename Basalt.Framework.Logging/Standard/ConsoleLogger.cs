using System.Runtime.InteropServices;

namespace Basalt.Framework.Logging.Standard;

/// <summary>
/// Logs messages to a console window
/// </summary>
public class ConsoleLogger : ILogger
{
    /// <summary>
    /// Creates a new console logger
    /// </summary>
    public ConsoleLogger(string title)
    {
        if (AttachConsole(-1))
            return;

        AllocConsole();
        Console.Title = title;
    }

    /// <inheritdoc/>
    public void Info(object message)
    {
        LogToConsole(message, ConsoleColor.White);
    }

    /// <inheritdoc/>
    public void Warn(object message)
    {
        LogToConsole(message, ConsoleColor.Yellow);
    }

    /// <inheritdoc/>
    public void Error(object message)
    {
        LogToConsole(message, ConsoleColor.Red);
    }

    /// <inheritdoc/>
    public void Debug(object message)
    {
        LogToConsole(message, ConsoleColor.Cyan);
    }

    private static void LogToConsole(object message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
    }

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool AllocConsole();

    [DllImport("kernel32", SetLastError = true)]
    static extern bool AttachConsole(int dwProcessId);
}
