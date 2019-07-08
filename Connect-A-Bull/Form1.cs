using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_A_Bull
{
    public partial class login_page : Form
    {
        //List of Users in database
        public static List<User> userCollection = new List<User>();
        public static User rpUser = new User();

        public login_page()
        {
            InitializeComponent();
            //Reading database at startup and storing
            ReadDatabase();
        }

        private void Username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            /*Since the login_page contains the main it must stay open in order
             * to avoid a Null reference error. Passing this page into next and hiding
             * it.
             */
            ClearAll();
            register_form reg_form = new register_form(this);
            reg_form.Show();
            this.Hide();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            //Closer entire application
            Application.Exit();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            name_box.Focus();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            /*Validates user input and navigates to the appropriate page
             *based on admin privelage*/
            if (Validate_Click(name_box.Text))
            {
                ClearAll();
                if (rpUser.RPassword)
                {
                    ResetPassword rp = new ResetPassword(this,rpUser);
                    rp.Show();
                    this.Hide();
                }
                else
                {
                    Dashboard db = new Dashboard(this);
                    db.Show();
                    this.Hide();
                }
            }

        }

        void ReadDatabase()
        {
            //Reading database and storing users in list
            userCollection = SQLiteDataAccess.LoadPeople();
        }

        private void Forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Since the login_page contains the main it must stay open in order
           * to avoid a Null reference error. Passing this page into next and hiding
           * it.
           */
            ForgotPassword forgot_form = new ForgotPassword(this);
            forgot_form.Show();
            this.Hide(); 
        }

        //functions to be able to drag the plane around

        bool drag;
        int mouse_x, mouse_y;

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                this.Left = Cursor.Position.X - mouse_x;
                this.Top = Cursor.Position.Y - mouse_y;

            }
        }

        private void name_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

        private bool Validate_Click(string tester)
        {
            foreach (User s in userCollection)
            {
                if (name_box.Text == s.Email)
                {
                    string savedPasswordHash = s.Password.ToString();
                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);

                    var pbkdf2 = new Rfc2898DeriveBytes(pass_box.Text, salt, 10000);
                    byte[] hash = pbkdf2.GetBytes(20);

                    int ok = 1;
                    for (int i = 0; i < 20; i++)
                    {
                        if (hashBytes[i + 16] != hash[i])
                            ok = 0;
                    }

                    if (ok == 1)
                    {
                        rpUser = s;
                        return true;
                    }
                }
            }

            MessageBox.Show("Email or password is incorrect");
            ClearAll();
            return false;
        }

        void ClearAll()
        {
            //Clear user input on page
            name_box.Clear();
            pass_box.Clear();
        }
    }
}
