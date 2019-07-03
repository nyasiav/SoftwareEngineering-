using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect_A_Bull
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string SFname { get; set; }
        public string SLname { get; set; }
        public string SEmail { get; set; }
        public string SPassword { get; set; }
        //public bool Reset { get; set; }

        public Student(string sFname, string sLname, string sEmail, string sPassword)
        {
            SFname = sFname;
            SLname = sLname;
            SEmail = sEmail;
            SPassword = sPassword;
        }

        public Student()
        {

        }
    }
}