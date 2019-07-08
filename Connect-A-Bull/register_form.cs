using SQLite;
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
    public partial class register_form : Form
    {
        login_page hold = new login_page();

        public register_form(login_page lp)
        {
            InitializeComponent();
            hold = lp;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            hold.Show();
            this.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            fn_txtbox.Select();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            if (Validate_Click())
            {
                User nU = new User(fn_txtbox.Text,ln_txtnox.Text,email_txtbox.Text,pass_txtbox.Text,false,false);

                byte[] salt;
                new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                var secureP = new Rfc2898DeriveBytes(pass_txtbox.Text, salt, 10000);

                byte[] hash = secureP.GetBytes(20);
                byte[] hashBytes = new byte[36];

                Array.Copy(salt, 0, hashBytes, 0, 16);
                Array.Copy(hash, 0, hashBytes, 16, 20);

                string savedPass = Convert.ToBase64String(hashBytes);
                nU.Password = savedPass;

                SQLiteDataAccess.SavePerson(nU);
                login_page.userCollection = SQLiteDataAccess.LoadPeople();

                ClearEverything();
                MessageBox.Show("Account Created!");
            }
        }

        //functions for window to be able to be dragged
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

        private void fn_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

        private bool Validate_Click()
        {
            bool val = false;
            if (string.IsNullOrWhiteSpace(fn_txtbox.Text) || string.IsNullOrWhiteSpace(ln_txtnox.Text) || string.IsNullOrWhiteSpace(pass_txtbox.Text)
                || string.IsNullOrWhiteSpace(email_txtbox.Text) || string.IsNullOrWhiteSpace(pass_validation_txtbox.Text))
            {
                MessageBox.Show("Field left blank!");
            }
            else
            {
                foreach(User s in login_page.userCollection)
                {
                    if(email_txtbox.Text == s.Email)
                    {
                        MessageBox.Show("This email already exist, please reset your password if you do not remeber it.");
                        ClearEmail();
                        ClearPass();
                        return false;                    
                    }
                }
                val = ValidateForLetters(fn_txtbox.Text, ln_txtnox.Text) ? true : NameError();     
                val = ValidatePassword(pass_txtbox.Text, pass_validation_txtbox.Text) ? true : false;
             
            }
            return val;
        }

        private bool NameError()
        {
            MessageBox.Show("Name can only contain letters");
            return false;
        }

        private bool ValidateForLetters(string fn_tester, string ln_tester)
        {
            return fn_tester.Where(x => char.IsLetter(x)).Count() == fn_tester.Length && ln_tester.Where(x => char.IsLetter(x)).Count() == ln_tester.Length;
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
            } else { MessageBox.Show("Passwords do not match!");
                ClearPass();
                return false;
            }

  
            return true;
        }

        private void ClearEverything()
        {
            fn_txtbox.Clear();
            ln_txtnox.Clear();
            email_txtbox.Clear();
            pass_txtbox.Clear();
            pass_validation_txtbox.Clear();
        }

        private void ClearPass()
        {
            pass_txtbox.Clear();
            pass_validation_txtbox.Clear();
        }

        private void ClearEmail()
        {
            email_txtbox.Clear();
        }
    }
}
