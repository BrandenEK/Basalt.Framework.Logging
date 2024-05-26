
namespace Basalt.Framework.Logging.Tests;

[TestClass]
public class InitializationTests
{
    private TestLogger _logger = new();

    [TestInitialize]
    public void TestReset()
    {
        Logger.RemoveAllLoggers();
        _logger = new TestLogger();
    }

    [TestMethod]
    public void Initialize_Zero()
    {
        Logger.Info("Test");
        Assert.AreEqual(0, _logger.InfoMessages);
    }

    [TestMethod]
    public void Initialize_One()
    {
        Logger.AddLogger(_logger);

        Logger.Info("Test");
        Assert.AreEqual(1, _logger.InfoMessages);
    }

    [TestMethod]
    public void Initialize_Two()
    {
        Logger.AddLoggers(new ILogger[]
        {
            _logger,
            _logger
        });

        Logger.Info("Test");
        Assert.AreEqual(2, _logger.InfoMessages);
    }
}