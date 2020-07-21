using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
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

            var loginButtonLocator = By.ClassName("login-button");
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(loginButtonLocator));

            var userNameField = _driver.FindElement(By.Id("user-name"));
            var passwordField = _driver.FindElement(By.Id("password"));
            var loginButton = _driver.FindElement(loginButtonLocator);

        }

        [TestCleanup]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
