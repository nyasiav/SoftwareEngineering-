using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_A_Bull
{
    public partial class ViewUsers : UserControl
    {
        public static List<User> userCollection = new List<User>();
        User temp = new User();

        public ViewUsers()
        {
            InitializeComponent();
            ReadDataBase();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            temp = listBox1.SelectedItem as User;
            SQLiteDataAccess.DeletePerson(temp);
        }

        void ReadDataBase()
        {
            userCollection = SQLiteDataAccess.LoadPeople();
            listBox1.DataSource = null;
            listBox1.DataSource = userCollection;
            listBox1.DisplayMember = "FullName";
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ReadDataBase();
        }
    }
}
