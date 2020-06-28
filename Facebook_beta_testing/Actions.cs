using Facebook_beta_testing.Paths;
using OpenQA.Selenium;
using System;
using System.Diagnostics;
using System.Threading;

namespace Facebook_beta_testing
{
    public static class Actions
    {
        public static Screenshot loginScreenShot;
        public static void Login(IWebDriver driver)
        {
            LoginPage page = new LoginPage(driver);
            UserData data = new UserData();

            page.Email.SendKeys(data.email);
            page.Password.SendKeys(data.password);
            page.Login.Click();
            Thread.Sleep(1000);

            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(FolderPaths.loginScreenshot,ScreenshotImageFormat.Jpeg);

            
            
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
            Process.Start(FolderPaths.fromAutoITFolder);
            Thread.Sleep(10000);
            upload.PostButton.Click();
            Thread.Sleep(10000);

            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(FolderPaths.statusUploadScreenshot, ScreenshotImageFormat.Jpeg);
        }

        public static void Logout(IWebDriver driver)
        {
            HomePage logout = new HomePage(driver);
            logout.AccountSettings.Click();
            Thread.Sleep(1000);
            logout.LogoutButton.Click();

            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(FolderPaths.logoutScreenshot, ScreenshotImageFormat.Jpeg);

        }
    }
}
