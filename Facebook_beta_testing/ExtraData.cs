

using Newtonsoft.Json;
using System.IO;

namespace Facebook_beta_testing
{
    public class ExtraData
    {
        public string AutoIt_Path = "";
        public string data = "";

        public ExtraData()
        {
            using (StreamReader read = new StreamReader(@"C:\Users\abhib\source\repos\Facebook_beta_testing\Facebook_beta_testing\Data\ExtraData.json"))
            {
                data = read.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(data);
            AutoIt_Path = array["AutoIt_Path"];

        }
    }
}
