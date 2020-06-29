using AventStack.ExtentReports.Configuration;
using Dapper;
using System.Data.OleDb;
using System.Linq;

namespace Facebook_beta_testing.Data
{
    public class ExcelDataAcces
    {
        public static string TestDataFileConection()
        {
            var fileName = System.Configuration.ConfigurationManager.AppSettings["TestDataSheetPath"];
            var can = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties=Excel 12.0;", fileName);
            return can;
        }

        public static UsersData GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConection()))
            {
                connection.Open();
                var query = string.Format("select * from [Credentials$] where key='{0}'", keyName);
                var value = connection.Query<UsersData>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
