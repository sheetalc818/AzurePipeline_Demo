﻿
using Facebook_beta_testing.Data;

namespace Facebook_beta_testing
{
    public static class Config
    {
        
        
        public static string n = ExcelDataAcces.AccessDataFromFile("User_1").Username;

        public static string URL = System.Configuration.ConfigurationManager.AppSettings["url"];

        public static string toExtentReoprter = System.Configuration.ConfigurationManager.AppSettings["extentReport"];

        public static string loginScreenshot = System.Configuration.ConfigurationManager.AppSettings["loginss"];
        public static string statusUploadScreenshot = System.Configuration.ConfigurationManager.AppSettings["statusss"];
        public static string logoutScreenshot = System.Configuration.ConfigurationManager.AppSettings["logoutss"];


        public static string fromAutoITFolder_user_one = System.Configuration.ConfigurationManager.AppSettings["autoit_user1"];
        public static string fromAutoITFolder_user_two = System.Configuration.ConfigurationManager.AppSettings["autoit_user2"];

    }
}
