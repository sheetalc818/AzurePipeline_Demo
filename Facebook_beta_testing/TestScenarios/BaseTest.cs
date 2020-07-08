namespace Facebook_beta_testing
{
    using Facebook_beta_testing.FactoryPattern;
    using NUnit.Framework;
    using OpenQA.Selenium;

    public class BaseTest
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {

            BrowserFactory fact = new BrowserFactory();
            driver = fact.InitBrowser("chrome");

            driver.Manage().Window.Maximize();
            driver.Url = Config.URL;

            


        }
    }
}
