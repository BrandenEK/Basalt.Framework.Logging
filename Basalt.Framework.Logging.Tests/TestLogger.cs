
namespace Basalt.Framework.Logging.Tests;

public class TestLogger : ILogger
{
    public int InfoMessages { get; private set; } = 0;
    public int WarningMessages { get; private set; } = 0;
    public int ErrorMessages { get; private set; } = 0;
    public int DebugMessages { get; private set; } = 0;

    public void Info(object message) => InfoMessages++;

    public void Warn(object message) => WarningMessages++;

    public void Error(object message) => ErrorMessages++;

    public void Debug(object message) => DebugMessages++;
}
