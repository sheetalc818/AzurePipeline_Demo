using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Facebook_beta_testing
{
    public class BaseTest
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions opt = new ChromeOptions();
            opt.AddArgument("--disable-notifications");
            driver = new ChromeDriver(opt);
            driver.Manage().Window.Maximize();
            driver.Url = Config.URL;

        }
    }
}
