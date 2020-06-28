
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace Facebook_beta_testing
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement Email;


        [FindsBy(How = How.Id, Using = "pass")]
        [CacheLookup]
        public IWebElement Password;


        [FindsBy(How = How.Id, Using = "u_0_b")]
        [CacheLookup]
        public IWebElement Login;
    }
}
