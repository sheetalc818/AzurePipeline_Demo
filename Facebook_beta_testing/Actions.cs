using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace Facebook_beta_testing
{
    public static class Actions
    {
        public static void Login(IWebDriver driver)
        {
            LoginPage page = new LoginPage(driver);
           // UsersData data = new UsersData();

            page.Email.SendKeys("8124217978");
            page.Password.SendKeys("jocky1234#");
            page.Login.Click();
            Thread.Sleep(1000);
        }
    }
}
