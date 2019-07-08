using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_A_Bull
{
    public partial class ForgotPassword : Form
    {
        login_page hold = new login_page();
        User rp = new User();

        public ForgotPassword(login_page lp)
        {
            InitializeComponent();
            hold = lp;
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

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

        private void send_email_button_Click(object sender, EventArgs e)
        {
            if (email_box.Text == confirm_email_box.Text)
            {
                if (ValidateEmail(email_box.Text))
                {

                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Timeout = 10000;//the first parameter 

                    //is the account sending the email, the second is the password for that account
                    //create new email for reset password ***GMAIL SECURITY NEEDS TO BE LOWERED
                    client.Credentials = new System.Net.NetworkCredential("testconnectabull@gmail.com", "teststu123");//"psalmsjc1@gmail.com", "//angelito2020JC");
                    MailMessage mail = new MailMessage();
                    //parameter is the account send ing the
                    mail.From = new MailAddress("testconnectabull@gmail.com");//FRom
                    mail.To.Add(email_box.Text);
                    mail.Subject = "Verify Your Account";

                    mail.Body = $"{rp.Fname}, here is your temporary password, Bull4Life you" +
                    $" must verify your email by clicking the link";
                    mail.BodyEncoding = Encoding.UTF8;
                    client.Send(mail);
                    MessageBox.Show("Email sent, navigate back to Home Screen to login");
                    ClearAll();

                    byte[] salt;
                    new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
                    var secureP = new Rfc2898DeriveBytes("Bull4Life", salt, 10000);

                    byte[] hash = secureP.GetBytes(20);
                    byte[] hashBytes = new byte[36];

                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 20);

                    string savedPass = Convert.ToBase64String(hashBytes);
                    rp.Password = savedPass;

                    SQLiteDataAccess.UpdateUserPassword(rp);

                }
            }
            else { MessageBox.Show("Emails do not match!"); }
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

        private bool ValidateEmail(string tester)
        {
            //query for email
            foreach (User s in login_page.userCollection)
            {
                if (tester == s.Email)
                {
                    rp = s;
                    rp.RPassword = true;
                    return true;
                }
            }
           
            MessageBox.Show("This email is not associated with an account or space left blank");
            ClearAll();
            return false;
        }

        private void ClearAll()
        {
            email_box.Clear();
            confirm_email_box.Clear();
        }

    }
}
