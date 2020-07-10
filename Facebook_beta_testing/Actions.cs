
using Facebook_beta_testing.Data;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Net.Mail;
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
                    page.Email.SendKeys(ExcelDataAcces.AccessDataFromFile("User_1").Username);
                    page.Password.SendKeys(ExcelDataAcces.AccessDataFromFile("User_1").Password);                   
                    break;
                case 2:
                    page.Email.SendKeys(ExcelDataAcces.AccessDataFromFile("User_2").Username);
                    page.Password.SendKeys(ExcelDataAcces.AccessDataFromFile("User_2").Password);                  
                    break;                                
            }
                        
            page.Login.Click();
            Thread.Sleep(1000);
           
            loginScreenShot = ((ITakesScreenshot)driver).GetScreenshot();
            loginScreenShot.SaveAsFile(Config.loginScreenshot, ScreenshotImageFormat.Jpeg);

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
            mail.From = new MailAddress("rishibodake@hotmail.com");
            mail.To.Add("rishibodake@hotmail.com");
            mail.Subject = "Test Mail....";
            mail.Body = "Mail With Attachment";
            Attachment attachment;
            attachment = new Attachment(@"C:\Users\abhib\source\repos\Facebook_beta_testing\Facebook_beta_testing\Reporter\dashboard.html");

        }

        public static void Upload(IWebDriver driver,string message,int userNo)
        {
          
            HomePage upload = new HomePage(driver);
            upload.WriteSomethingBox.Click();
            Thread.Sleep(500);
            upload.WriteSomethingBox.SendKeys(message);
            Thread.Sleep(500);

            upload.DropPhotos.Click();
            Thread.Sleep(5000);
            switch (userNo)
            {
                case 1:
                    Process.Start(Config.fromAutoITFolder_user_one);
                    break;
                case 2:
                    Process.Start(Config.fromAutoITFolder_user_two);
                    break;
            }           
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
