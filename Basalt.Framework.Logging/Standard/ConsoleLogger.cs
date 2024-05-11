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
    public ConsoleLogger(bool requiresAlloc)
    {
        if (requiresAlloc)
            AttachConsole(-1);
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

    private void LogToConsole(object message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
    }

    [DllImport("kernel32", SetLastError = true)]
    static extern bool AttachConsole(int dwProcessId);
}
