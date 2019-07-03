using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_A_Bull
{
    public class SQLiteDataAccess
    {
        public static List<User> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("select * from User", new DynamicParameters());
                //cnn.Close();
                return output.ToList();
            }
        }

        public static void SavePerson(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (Fname, Lname, Email, Password, Admin) values (@Fname, @Lname, @Email, @Password, @Admin)", user);
                cnn.Close();
            }
        }

        //create funtcion for parsing database

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

       
    }
}
