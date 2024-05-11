
namespace Basalt.Framework.Logging.Tests;

[TestClass]
public class InitializationTests
{
    private TestLogger _logger = new();

    [TestInitialize]
    public void TestReset()
    {
        Logger.Reset();
        _logger = new TestLogger();
    }

    [TestMethod]
    public void Initialize_Never()
    {
        Assert.ThrowsException<InvalidOperationException>(() => Logger.Info("Test"));
    }

    [TestMethod]
    public void Initialize_Twice()
    {
        Logger.Initialize(Array.Empty<ILogger>());

        Assert.ThrowsException<InvalidOperationException>(() => Logger.Initialize(Array.Empty<ILogger>()));
    }

    [TestMethod]
    public void Initialize_Zero()
    {
        Logger.Initialize(Array.Empty<ILogger>());

        Logger.Info("Test");
    }

    [TestMethod]
    public void Initialize_One()
    {
        Logger.Initialize(new ILogger[]
        {
            _logger
        });

        Logger.Info("Test");
        Assert.AreEqual(1, _logger.InfoMessages);
    }

    [TestMethod]
    public void Initialize_Two()
    {
        Logger.Initialize(new ILogger[]
        {
            _logger, _logger
        });

        Logger.Info("Test");
        Assert.AreEqual(2, _logger.InfoMessages);
    }
}