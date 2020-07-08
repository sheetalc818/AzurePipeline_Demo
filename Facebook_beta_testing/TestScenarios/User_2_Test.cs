using Facebook_beta_testing.FactoryPattern;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Facebook_beta_testing.TestScenarios
{
    
    [TestFixture]
    [Parallelizable]
    public class User_2_Test : BaseTest
    {       
        [Test, Order(4)]
        public void LoginTest()
        {            
            Actions.Login(driver,2);
        }
        [Test, Order(5)]
        public void UploadStatusTest()
        {

            Actions.Upload(driver, "Good Moring",2);

        }
        [Test, Order(6)]
        public void Logout()
        {
           
            Actions.Logout(driver);
     
        }
    
    }
}
