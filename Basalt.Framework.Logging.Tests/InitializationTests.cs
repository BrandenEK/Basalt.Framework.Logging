
namespace Basalt.Framework.Logging.Tests;

[TestClass]
public class InitializationTests
{
    [TestInitialize]
    public void Initialize()
    {
        Logger.Reset();
    }

    [TestMethod]
    public void NoInitialize()
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
    public void Initialize_Empty()
    {
        Logger.Initialize(Array.Empty<ILogger>());

        Logger.Info("Test");
    }
}