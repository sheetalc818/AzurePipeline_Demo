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

        public static void Upload(IWebDriver driver)
        {
            HomePage upload = new HomePage(driver);
            upload.WriteSomethingBox.Click();
            Thread.Sleep(500);
            upload.WriteSomethingBox.SendKeys("New Change Script");
            Thread.Sleep(500);

            upload.DropPhotos.Click();
            Thread.Sleep(5000);
            Process.Start("E:\\Fileupload.exe");
            Thread.Sleep(10000);
            upload.PostButton.Click();
            Thread.Sleep(10000);
        }
    }
}
