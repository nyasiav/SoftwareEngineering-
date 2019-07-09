using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;

namespace Connect_A_Bull
{
    public partial class Chat : UserControl
    {
        User rp = new User();
        public Chat()
        {
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {

        }

        private void send_email_button_Click(object sender, EventArgs e)
        {
            if (ValidateClick(email_box.Text))
                {
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Timeout = 10000;//the first parameter 

                    //is the account sending the email, the second is the password for that account
                    //create new email for reset password ***GMAIL SECURITY NEEDS TO BE LOWERED

                    client.Credentials = new System.Net.NetworkCredential(email_box.Text, password.Text);
                Attachment data = new Attachment(file_attactment.Text, MediaTypeNames.Application.Octet);
                MailMessage mail = new MailMessage();

                    //parameter is the account send ing the
                    mail.From = new MailAddress(email_box.Text);//FRom
                    mail.To.Add(to_email.Text);
                    mail.Subject = email_subject.Text;
                    mail.Body = email_body.Text;
                    

                   
                // Add time stamp information for the file.
                ContentDisposition disposition = data.ContentDisposition;
                disposition.CreationDate = System.IO.File.GetCreationTime(file_attactment.Text);
                disposition.ModificationDate = System.IO.File.GetLastWriteTime(file_attactment.Text);
                disposition.ReadDate = System.IO.File.GetLastAccessTime(file_attactment.Text);
                // Add the file attachment to this email message.
                mail.Attachments.Add(data);
                mail.BodyEncoding = Encoding.UTF8;
                client.Send(mail);

                MessageBox.Show("Email sent !!");
                    ClearAll();
            }
        }

        private bool ValidateClick(string tester)
        {
            //bool val = false;
            if (string.IsNullOrWhiteSpace(email_body.Text) || string.IsNullOrWhiteSpace(email_subject.Text) || string.IsNullOrWhiteSpace(email_box.Text)
                || string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(to_email.Text))
            {
                MessageBox.Show("Field left blank!");
            }
            else
            {
                if (login_page.userCollection.Any(i=> i.Email == email_box.Text) && login_page.userCollection.Any(i=> i.Email == to_email.Text))
                {
                    return true;
                }else{ 

                MessageBox.Show("The sending email or the recieving email is not associated with any email in the database");
                ClearEmails();
                return false;
            }
           }
            return false;
        }
        private void ClearAll()
        {
            email_subject.Clear();
            email_body.Clear();
            file_attactment.Clear();
            to_email.Clear();
            email_box.Clear();
            password.Clear();
        }

        private void ClearEmails()
        {
            to_email.Clear();
            email_box.Clear();
            password.Clear();
        }
        private void browse_Button_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_attactment.Text = openFileDialog1.FileName;
            }
        }
    }
}
