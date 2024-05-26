
namespace Basalt.Framework.Logging;

/// <summary>
/// Handles logging messages
/// </summary>
public static class Logger
{
    private static readonly List<ILogger> _loggers = new();

    /// <summary>
    /// Registers a single ILogger
    /// </summary>
    public static void AddLogger(ILogger logger)
    {
        _loggers.Add(logger);
    }

    /// <summary>
    /// Registers multiple ILoggers
    /// </summary>
    public static void AddLoggers(IEnumerable<ILogger> loggers)
    {
        _loggers.AddRange(loggers);
    }

    internal static void RemoveAllLoggers()
    {
        _loggers.Clear();
    }

    /// <summary> Displays a message as information </summary>
    public static void Info(object message)
    {
        foreach (ILogger logger in _loggers)
            logger.Info(message);
    }

    /// <summary> Displays a message as a warning </summary>
    public static void Warn(object message)
    {
        foreach (ILogger logger in _loggers)
            logger.Warn(message);
    }

    /// <summary> Displays a message as an error </summary>
    public static void Error(object message)
    {
        foreach (ILogger logger in _loggers)
            logger.Error(message);
    }

    /// <summary> Displays a message as a debug statement </summary>
    public static void Debug(object message)
    {
        if (!LoggingProperties.DisplayDebug)
            return;

        foreach (ILogger logger in _loggers)
            logger.Debug(message);
    }
}
