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
        public static ObservableCollection<Student> studentCollection = new ObservableCollection<Student>();
        public login_page()
        {
            InitializeComponent();
            Student newS = new Student("Test", "Stu", "teststu", "pass");

            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var secureP = new Rfc2898DeriveBytes(newS.SPassword, salt, 10000);

            byte[] hash = secureP.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string savedPass = Convert.ToBase64String(hashBytes);
            newS.SPassword = savedPass;
            studentCollection.Add(newS);
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label2_Click(object sender, EventArgs e)
        //{

        //}

        //private void Username_box_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void PictureBox1_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label3_Click(object sender, EventArgs e)
        //{

        //}

        //private void Label4_Click(object sender, EventArgs e)
        //{

        //}

        //private void Register_label_Click(object sender, EventArgs e)
        //{

        //}

        //private void Pass_box_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void BunifuTextbox1_OnTextChange(object sender, EventArgs e)
        //{

        //}

        //private void Sign_up_button_Click(object sender, EventArgs e)
        //{
            
        //}

        private void Sign_up_button_Click_1(object sender, EventArgs e)
        {
            register_form reg_form = new register_form();
            reg_form.Show();
            this.Hide();
        }

        //private void Label5_Click(object sender, EventArgs e)
        //{

        //}

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_page_Load(object sender, EventArgs e)
        {
            name_box.Focus();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            if (Validate_Click(name_box.Text))
            {
                Dashboard db = new Dashboard();
                this.Hide();
                
                db.ShowDialog();
                this.Close();
            }
        }

        private void Test_btn_Click(object sender, EventArgs e)
        {
            Dashboard dash_form = new Dashboard();
            dash_form.Show();
        }

        private bool Validate_Click(string tester)
        {
            foreach (Student s in studentCollection)
            {
                if (name_box.Text == s.SEmail)
                {
                    string savedPasswordHash = s.SPassword.ToString();
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
                        //MessageBox.Show("Granted");
                        return true;
                        //this.Hide();
                    }
                }
            }

            MessageBox.Show("Email or password is incorrect");
            ClearAll();
            return false;
        }

        void ClearAll()
        {
            name_box.Clear();
            pass_box.Clear();
        }
    }
}
