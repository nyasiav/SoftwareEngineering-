using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Connect_A_Bull
{
    public class SQLiteDataAccess
    {
        public static List<User> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePerson(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (Fname, Lname, Email, Password, Admin, RPassword) values (@Fname, @Lname, @Email, @Password, @Admin, @RPassword)", user);
                cnn.Close();
            }
        }

        public static void DeletePerson(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM User WHERE Fname = @Fname AND Lname = @Lname;",new {Fname = user.Fname, Lname = user.Lname});
                cnn.Close();
            }
        }

        public static void UpdateUserPassword(User user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update User SET Password = @Password, RPassword = @RPassword WHERE Email = @Email;", new { Email = user.Email, Password = user.Password, RPassword = user.RPassword });
                //cnn.Execute("update User SET Password = @Password WHERE Email = @Email;",new {Email = user.Email, Password = user.Password});
                //cnn.Execute("update User SET RPassword = @RPassword WHERE Email = @Email;", new {Email = user.Email, RPassword = user.RPassword });
                //MessageBox.Show(""+affectedRows);
            }
        }


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

       
    }
}
