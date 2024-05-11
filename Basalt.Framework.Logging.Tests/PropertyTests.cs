
namespace Basalt.Framework.Logging.Tests;

[TestClass]
public class PropertyTests
{
    private TestLogger _logger = new();

    [TestInitialize]
    public void TestReset()
    {
        Logger.Reset();
        _logger = new TestLogger();
    }

    [TestMethod]
    public void Properties_Empty()
    {
        Logger.Initialize(new ILogger[] { _logger });

        Logger.Debug("Test");
        Assert.AreEqual(1, _logger.DebugMessages);
    }

    [TestMethod]
    public void Properties_DisplayDebug()
    {
        Logger.Initialize(new ILogger[] { _logger }, new Properties()
        {
            DisplayDebug = false
        });

        Logger.Debug("Test");
        Assert.AreEqual(0, _logger.DebugMessages);
    }
}
