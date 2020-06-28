

using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

using NUnit.Framework;

namespace Facebook_beta_testing
{
    [TestFixture]
    public class Tests : BaseTest
    {

        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtendStart()
        {
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\abhib\source\repos\Facebook_beta_testing\Facebook_beta_testing\Reporter\");
            extent.AttachReporter(htmlReporter);

        }

        [Test, Order(1)]
        public void LoginTest()
        {

            ExtentTest test = extent.CreateTest("LoginTest").Info("Test To Login Into Aplication");
            Actions.Login(driver);
            test.Log(Status.Info, "Login Succesful");
            
        }

        [Test, Order(2)]
        public void UploadStatusTest()
        {
            ExtentTest test = extent.CreateTest("UploadStatusTest").Info("Test To Upload The Status");
            Actions.Upload(driver);
            test.Log(Status.Info, "UploadStatus Succesful");
        }


        [Test, Order(3)]
        public void Logout()
        {
            ExtentTest test = extent.CreateTest("Logout").Info("Test To Logout From Application");
            Actions.Logout(driver);
            test.Log(Status.Info, "Logout Succesful");
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }
    }
}
