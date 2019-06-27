using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_A_Bull
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
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
                    client.Credentials = new System.Net.NetworkCredential("psalmsjc1@gmail.com", "//angelito2020JC");
                    MailMessage mail = new MailMessage();
                    //parameter is the account send ing the
                    mail.From = new MailAddress("psalmsjc1@gmail.com");//FRom
                    mail.To.Add(email_box.Text);
                    mail.Subject = "Verify Your Account";

                    mail.Body = $"Welcome {email_box.Text}, here is your temporary password, Bull4Life you" +
                    $" must verify your email by clicking the link";
                    mail.BodyEncoding = Encoding.UTF8;
                    client.Send(mail);
                    MessageBox.Show("Email sent");

                    //The end and the email has been sent
                    //The is assigning an e=object that carries the email of the user and
                    //The list tempToFindS will carry soley the object of that email user
                    //List<Student> tempToFindS = ResetVerifier.Where(x => x.Email == EmailNameEntry.Text.ToString()).ToList();
                    ////This loop will assign object StudentToEdit to the emailuserin the list tempToFundS, a copy of that person
                    ////Object of mail user info
                    //foreach (Student StudentToEdit in tempToFindS)
                    //{
                    //    //if this objecrt email mathes the email entered as a double check
                    //    if (EmailNameEntry.Text == StudentToEdit.Email)
                    //    {
                    //        //We remove that person form the Master List ResetVerifier
                    //        ResetVerifier.Remove(StudentToEdit);
                    //        //In this loop a new object newPerson will look into list tempToFindS
                    //        foreach (Student newPerson in tempToFindS)
                    //        {
                    //            //Then we will assign that object the info that is in the tempToFindS and also 
                    //            //Modify the password to BUll4Life
                    //            newPerson.Password = "Bull4Life";
                    //            //Adding to the list
                    //            ResetVerifier.Add(newPerson);
                    //            //Writing this person to the list which just modified the users password
                    //            WriteStudentFile();
                    //        }

                    //        //logging into login window for the user to log in for 2nd time, passing the list
                    //        StudentLogin LoginSecondTime = new StudentLogin(ResetVerifier);
                    //        LoginSecondTime.ShowDialog();
                    //        this.Close();

                    //    }
                    //}
                }
            }
            else { MessageBox.Show("Email do not match!"); }
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

        private bool ValidateEmail(string tester)
        {
            //query database for email
            foreach (Student s in login_page.studentCollection)
            {
                if (tester == s.SEmail)
                {
                    s.Reset = true;
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
