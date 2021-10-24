using log4net;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Demoqa.Tests
{
    [TestFixture]
    public class Base
    {
        private protected static IWebDriver _driver;
        private protected static ILog log = LogManager.GetLogger(typeof(Base));

        [OneTimeSetUp]
        public void Init()
        {
            _driver = new FirefoxDriver();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
