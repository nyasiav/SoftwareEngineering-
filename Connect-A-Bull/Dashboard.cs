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
    public partial class Dashboard : Form
    {
        login_page hold = new login_page();
        public Dashboard(login_page lp)
        {
            InitializeComponent();
            hold = lp;
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            hold.Show();
            this.Close();
            //Application.Exit();
        }


        //functions to pull up the user control panels for the buttons on the dashboard
        //all of these variables have to be publci because the functions need to have access to them in order to close
        //the panel
        Calendar calander_panel = new Calendar();
        Settings settings_panel = new Settings();
        Evaluations evaluations_panel = new Evaluations();
        Assignments assignments_panel = new Assignments();
        Reminders reminders_panel = new Reminders();
        Chat chat_panel = new Chat();

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(chat_panel);
            dash_container.Controls.Remove(reminders_panel);

            calander_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(calander_panel);

        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {

            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(chat_panel);
            dash_container.Controls.Remove(reminders_panel);

            settings_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(settings_panel);

        }

        private void Assignments_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(chat_panel);
            dash_container.Controls.Remove(reminders_panel);

            assignments_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(assignments_panel);

        }


        private void Evaluations_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(chat_panel);
            dash_container.Controls.Remove(reminders_panel);

            evaluations_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(evaluations_panel);

        }

        private void Reminders_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(chat_panel);
            dash_container.Controls.Remove(evaluations_panel);

            reminders_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(reminders_panel);
        }
        private void Chat_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(reminders_panel);
            dash_container.Controls.Remove(evaluations_panel);

            chat_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(chat_panel);

            email_label.Visible = true;
            email_box.Visible = true;

            password_label.Visible = true;
            password.Visible = true;

            body_label.Visible = true;
            email_body.Visible = true;

            email_to_label.Visible = true;
            to_email.Visible = true;

            subject_label.Visible = true;
            email_subject.Visible = true;

            send_email_button.Visible = true;
        }

        //variables and functions to allow the window to be moved
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

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            //login_page lp = new login_page();
            this.Hide();
            login_page lp = new login_page();

            lp.ShowDialog();
            this.Close();
        }

        private void dash_container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void send_email_button_Click(object sender, EventArgs e)
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
            MailMessage mail = new MailMessage();

            //parameter is the account send ing the
            mail.From = new MailAddress(email_box.Text);//FRom
            mail.To.Add(to_email.Text);
            mail.Subject = email_subject.Text;
            mail.Body = email_body.Text;
            mail.BodyEncoding = Encoding.UTF8;
            client.Send(mail);
            MessageBox.Show("Email sent !!");
            ClearAll();
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

        private void ClearAll()
        {
            email_body.Clear();
            email_box.Clear();
            email_subject.Clear();
            to_email.Clear();
            password.Clear();
        }

    }
}
