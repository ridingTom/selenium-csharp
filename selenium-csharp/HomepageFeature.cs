using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace selenium_csharp
{
    [TestClass]
    public class HomepageFeature
    {
        IWebDriver _driver;

        [TestMethod]
        public void ShouldBeAbleToLogin()
        {
            var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new ChromeDriver(outputDirectory);
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TestCleanup]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
