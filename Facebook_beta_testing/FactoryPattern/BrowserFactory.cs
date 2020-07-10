namespace Facebook_beta_testing.FactoryPattern
{
    using Facebook_beta_testing.ExceptionHandeling;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    public class BrowserFactory
    {   
        IWebDriver driver;
        public IWebDriver InitBrowser(string browser)
        {
            try
            {
                if (browser == null)
                {
                    throw new CustomExceptions("Null Value is Not Allowed",CustomExceptions.ExceptionType.NULL_VALUE);
                }
                if(browser.Length == 0)
                {
                    throw new CustomExceptions("Empty String is not Allowed", CustomExceptions.ExceptionType.EMPTY_STRING_EXCEPTION);
                }
                switch (browser)
                {
                    case "chrome":
                        ChromeOptions chromeOptions = new ChromeOptions();
                        chromeOptions.AddArgument("--disable-notifications");
                        driver = new ChromeDriver(chromeOptions);
                        break;
                    case "firefox":
                        FirefoxOptions firefoxOptions = new FirefoxOptions();
                        firefoxOptions.SetPreference("dom.webnotifications.enabled", false);
                        driver = new FirefoxDriver(firefoxOptions);
                        break;
                }
                return driver;
            }
            catch(CustomExceptions e)
            {
                throw new CustomExceptions(e.Message, CustomExceptions.ExceptionType.NULL_VALUE);
            }
            
        }
    }
}
