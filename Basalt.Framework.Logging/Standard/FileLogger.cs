using System;
using System.IO;

namespace Basalt.Framework.Logging.Standard;

/// <summary>
/// Logs messages to a 'Latest.log' file
/// </summary>
public class FileLogger : ILogger
{
    private readonly string _path;

    /// <summary>
    /// Creates a new file logger
    /// </summary>
    public FileLogger(string directory)
    {
        Directory.CreateDirectory(directory);
        _path = Path.Combine(directory, "Latest.log");

        if (File.Exists(_path))
            File.SetAttributes(_path, File.GetAttributes(_path) & ~FileAttributes.ReadOnly);

        File.WriteAllText(_path, string.Empty);
        File.SetAttributes(_path, FileAttributes.ReadOnly);
    }

    /// <inheritdoc/>
    public void Info(object message)
    {
        LogtoFile(message, "Info");
    }

    /// <inheritdoc/>
    public void Warn(object message)
    {
        LogtoFile(message, "Warning");
    }

    /// <inheritdoc/>
    public void Error(object message)
    {
        LogtoFile(message, "Error");
    }

    /// <inheritdoc/>
    public void Debug(object message)
    {
        LogtoFile(message, "Debug");
    }

    private void LogtoFile(object message, string type)
    {
        string output = $"[{DateTime.Now:HH:mm:ss} {type.PadLeft(PADDING, ' ')}] {message}{Environment.NewLine}";

        if (File.Exists(_path))
            File.SetAttributes(_path, File.GetAttributes(_path) & ~FileAttributes.ReadOnly);

        File.AppendAllText(_path, output);
        File.SetAttributes(_path, FileAttributes.ReadOnly);
    }

    private const int PADDING = 7;
}
