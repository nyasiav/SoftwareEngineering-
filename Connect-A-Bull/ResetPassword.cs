using System;
using System.Collections.Generic;
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
    public partial class ResetPassword : Form
    {
        login_page hold = new login_page();
        User rpUser = new User();

        public ResetPassword(login_page lp,User resetUser)
        {
            InitializeComponent();
            hold = lp;
            rpUser = resetUser;
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            hold.Show();
            this.Close();
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

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (Validate_Click())
            {
                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var secureP = new Rfc2898DeriveBytes(new_password.Text, salt, 10000);

                byte[] hash = secureP.GetBytes(20);
                byte[] hashBytes = new byte[36];

                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string savedPass = Convert.ToBase64String(hashBytes);
                rpUser.Password = savedPass;
                rpUser.RPassword = false;

                SQLiteDataAccess.UpdateUserPassword(rpUser);
                login_page.userCollection = SQLiteDataAccess.LoadPeople();

                ClearPass();
                MessageBox.Show("Password Changed! Navigate back to Home Screen to login");

                
            }
        }

        private bool Validate_Click()
        {
            bool val = false;
            if (string.IsNullOrWhiteSpace(new_password.Text) || string.IsNullOrWhiteSpace(confirm_new_password.Text))
            {
                MessageBox.Show("Field left blank!");
            }
            else
            {
                val = ValidatePassword(new_password.Text, confirm_new_password.Text) ? true : false;
            }
            return val;
        }

        private bool ValidatePassword(string p_tester, string vp_tester)
        {
            if (p_tester == vp_tester)
            {
                if (p_tester.Length < 8 || p_tester.Length > 15)
                {
                    MessageBox.Show("Password needs to be 8 - 15 characters and can include letters, numbers and symbols.");
                    ClearPass();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
                ClearPass();
                return false;
            }
            return true;
        }

        private void ClearPass()
        {
            new_password.Clear();
            confirm_new_password.Clear();
        }
    }
}
