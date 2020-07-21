using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace selenium_csharp
{
    [TestClass]
    public class HomepageFeature
    {
        [TestMethod]
        public void ShouldBeAbleToLogin()
        {
            var outputDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var driver = new ChromeDriver(outputDirectory);
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }
    }
}
