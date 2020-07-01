
using Facebook_beta_testing.Data;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Threading;

namespace Facebook_beta_testing
{
    public static class Actions
    {
        public static Screenshot loginScreenShot;
        public static void Login(IWebDriver driver,int userNo)
        {
            LoginPage page = new LoginPage(driver);
            switch (userNo)
            {
                case 1:
                    page.Email.SendKeys(ExcelDataAcces.GetTestData("User_1").Username);
                    page.Password.SendKeys(ExcelDataAcces.GetTestData("User_1").Password);
                    break;
                case 2:
                    page.Email.SendKeys(ExcelDataAcces.GetTestData("User_2").Username);
                    page.Password.SendKeys(ExcelDataAcces.GetTestData("User_2").Password);
                    break;

            }
            
            
            page.Login.Click();
            Thread.Sleep(1000);
           
            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(Config.loginScreenshot,ScreenshotImageFormat.Jpeg);

        }

        public static void Upload(IWebDriver driver,string message)
        {
            HomePage upload = new HomePage(driver);
            upload.WriteSomethingBox.Click();
            Thread.Sleep(500);
            upload.WriteSomethingBox.SendKeys(message);
            Thread.Sleep(500);

            upload.DropPhotos.Click();
            Thread.Sleep(5000);
            Process.Start(Config.fromAutoITFolder);
            Thread.Sleep(10000);
            upload.PostButton.Click();
            Thread.Sleep(10000);

            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(Config.statusUploadScreenshot, ScreenshotImageFormat.Jpeg);
        }

        public static void Logout(IWebDriver driver)
        {
            HomePage logout = new HomePage(driver);
            logout.AccountSettings.Click();
            Thread.Sleep(1000);
            logout.LogoutButton.Click();

            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(Config.logoutScreenshot, ScreenshotImageFormat.Jpeg);

        }
    }
}
