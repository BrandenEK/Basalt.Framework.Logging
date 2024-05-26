
namespace Basalt.Framework.Logging.Tests;

[TestClass]
public class PropertyTests
{
    private TestLogger _logger = new();

    [TestInitialize]
    public void TestReset()
    {
        Logger.RemoveAllLoggers();
        LoggingProperties.DisplayDebug = true;

        _logger = new TestLogger();
    }

    [TestMethod]
    public void Properties_Empty()
    {
        Logger.AddLogger(_logger);

        Logger.Debug("Test");
        Assert.AreEqual(1, _logger.DebugMessages);
    }

    [TestMethod]
    public void Properties_DisplayDebug()
    {
        Logger.AddLogger(_logger);
        LoggingProperties.DisplayDebug = false;

        Logger.Debug("Test");
        Assert.AreEqual(0, _logger.DebugMessages);
    }
}
