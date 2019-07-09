using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_A_Bull
{
    public class User
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public bool RPassword { get; set; }
        public string CanvasToken { get; set; }

        public User(string fname, string lname, string email, string password, bool admin,bool rpassword)
        {
            Fname = fname;
            Lname = lname;
            Email = email;
            Password = password;
            Admin = admin;
            RPassword = rpassword;
        }

        public string FullName
        {
            get{ 
                return $"{Fname} {Lname}";
            }
        }
        public User()
        {

        }
    }
}
