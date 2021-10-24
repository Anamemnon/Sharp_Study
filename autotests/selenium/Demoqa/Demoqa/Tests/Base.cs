using log4net;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;

namespace Demoqa.Tests
{
    [TestFixture]
    public class Base
    {
        private protected static IWebDriver _driver;
        private protected static ILog log = LogManager.GetLogger(typeof(Base));
        private protected static WebDriverWait _wait;

        [OneTimeSetUp]
        public void Init()
        {
            _driver = new FirefoxDriver();
            _wait = new(_driver, TimeSpan.FromSeconds(10));
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
