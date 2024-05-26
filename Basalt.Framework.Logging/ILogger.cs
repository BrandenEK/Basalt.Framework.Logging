
namespace Basalt.Framework.Logging;

/// <summary>
/// Interface for logging messages
/// </summary>
public interface ILogger
{
    /// <summary> Displays a message as information </summary>
    void Info(object message);

    /// <summary> Displays a message as a warning </summary>
    void Warn(object message);

    /// <summary> Displays a message as an error </summary>
    void Error(object message);

    /// <summary> Displays a message as a fatal error </summary>
    void Fatal(object message);

    /// <summary> Displays a message as a debug statement </summary>
    void Debug(object message);
}
