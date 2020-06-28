
using Newtonsoft.Json;
using System;
using System.IO;

namespace Facebook_beta_testing
{
    public class UserData
    {
        public string email = "";
        public string password = "";
        public string data = "";
        public UserData()
        {
            using (StreamReader read = new StreamReader(@"C:\Users\abhib\source\repos\Facebook_beta_testing\Facebook_beta_testing\Data\UserData.json"))
            {
                data = read.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(data);
            Console.WriteLine("Array::::" + array["email"]);
            email = array["email"];
            password = array["password"];


        }
    }
}
