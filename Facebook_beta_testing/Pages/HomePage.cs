using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Facebook_beta_testing
{
    public class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//textarea[@name = 'xhpc_message']")]
        [CacheLookup]
        public IWebElement WriteSomethingBox;


        [FindsBy(How = How.XPath, Using = "//div[@class = '_45wg _69yt']")]
        [CacheLookup]
        public IWebElement PostButton;

        [FindsBy(How = How.XPath, Using = "//div[@class = '_3jk']")]
        [CacheLookup]
        public IWebElement DropPhotos;

        [FindsBy(How = How.XPath, Using = "//div[@id = 'userNavigationLabel']")]
        [CacheLookup]
        public IWebElement AccountSettings;

        [FindsBy(How = How.XPath, Using = "//li[@class = '_54ni navSubmenu _6398 _64kz __MenuItem']")]
        [CacheLookup]
        public IWebElement LogoutButton;
    }
}
