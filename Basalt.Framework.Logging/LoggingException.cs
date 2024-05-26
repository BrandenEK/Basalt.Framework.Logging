using System;

namespace Basalt.Framework.Logging;

/// <summary>
/// An error thrown by the logging framework
/// </summary>
public class LoggingException : Exception
{
    internal LoggingException(string message) : base(message) { }
}
