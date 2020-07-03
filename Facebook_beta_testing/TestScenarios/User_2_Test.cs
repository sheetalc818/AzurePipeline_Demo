using Facebook_beta_testing.FactoryPattern;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Facebook_beta_testing.TestScenarios
{
    
    [TestFixture]
    [Parallelizable]
    public class User_2_Test : BaseTest
    {       
        [Test, Order(1)]
        public void LoginTest()
        {            
            Actions.Login(driver,2);
        }
        [Test, Order(2)]
        public void UploadStatusTest()
        {

            Actions.Upload(driver, "Good Moring");

        }
        [Test, Order(3)]
        public void Logout()
        {
           
            Actions.Logout(driver);
     
        }
    
    }
}
