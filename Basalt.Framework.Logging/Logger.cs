
namespace Basalt.Framework.Logging;

/// <summary>
/// Handles logging messages
/// </summary>
public static class Logger
{
    private static bool _initialized = false;

    private static IEnumerable<ILogger>? _loggers;
    private static Properties? _properties;

    /// <summary>
    /// Initializes the logger with functionality and custom properties
    /// </summary>
    public static void Initialize(IEnumerable<ILogger> loggers, Properties properties)
    {
        if (_initialized)
            throw new InvalidOperationException("Logging framework has already been initialized");

        if (loggers is null)
            throw new ArgumentNullException(nameof(loggers));

        if (properties is null)
            throw new ArgumentNullException(nameof(properties));

        _loggers = loggers;
        _properties = properties;
        _initialized = true;
    }

    /// <summary>
    /// Initializes the logger with functionality and default properties
    /// </summary>
    public static void Initialize(IEnumerable<ILogger> loggers) => Initialize(loggers, new Properties());

    /// <summary> Displays a message as information </summary>
    public static void Info(object message)
    {
        if (!_initialized)
            throw new InvalidOperationException("Logging framework has not been initialized");

        foreach (ILogger logger in _loggers!)
            logger.Info(message);
    }

    /// <summary> Displays a message as a warning </summary>
    public static void Warn(object message)
    {
        if (!_initialized)
            throw new InvalidOperationException("Logging framework has not been initialized");

        foreach (ILogger logger in _loggers!)
            logger.Warn(message);
    }

    /// <summary> Displays a message as an error </summary>
    public static void Error(object message)
    {
        if (!_initialized)
            throw new InvalidOperationException("Logging framework has not been initialized");

        foreach (ILogger logger in _loggers!)
            logger.Error(message);
    }

    /// <summary> Displays a message as a debug statement </summary>
    public static void Debug(object message)
    {
        if (!_initialized)
            throw new InvalidOperationException("Logging framework has not been initialized");

        if (!_properties!.DisplayDebug)
            return;

        foreach (ILogger logger in _loggers!)
            logger.Debug(message);
    }
}
