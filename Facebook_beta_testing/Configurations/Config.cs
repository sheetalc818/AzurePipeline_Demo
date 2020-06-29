
namespace Facebook_beta_testing
{
    public static class Config
    {
        public static string URL = System.Configuration.ConfigurationManager.AppSettings["url"];
        
        public static string userName = System.Configuration.ConfigurationManager.AppSettings["email"];
        public static string password = System.Configuration.ConfigurationManager.AppSettings["pwd"];

        public static string toExtentReoprter = System.Configuration.ConfigurationManager.AppSettings["extentReport"];

        public static string loginScreenshot = System.Configuration.ConfigurationManager.AppSettings["loginss"];
        public static string statusUploadScreenshot = System.Configuration.ConfigurationManager.AppSettings["statusss"];
        public static string logoutScreenshot = System.Configuration.ConfigurationManager.AppSettings["logoutss"];

        public static string fromAutoITFolder = System.Configuration.ConfigurationManager.AppSettings["autoit"];
    }
}
