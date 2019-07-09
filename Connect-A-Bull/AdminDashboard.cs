using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_A_Bull
{
    public partial class AdminDashboard : Form
    {
        login_page hold = new login_page();

        public AdminDashboard(login_page lp)
        {
            InitializeComponent();
            hold = lp;
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

        //functions to pull up the user control panels for the buttons on the dashboard
        //all of these variables have to be public because the functions need to have access to them in order to close
        //the panel
        Calendar calander_panel = new Calendar();
        Settings settings_panel = new Settings();
        Evaluations evaluations_panel = new Evaluations();
        Assignments assignments_panel = new Assignments();
        Reminders reminders_panel = new Reminders();
        Chat email_panel = new Chat();
        ViewUsers user_panel = new ViewUsers();

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(email_panel);
            dash_container.Controls.Remove(reminders_panel);
            dash_container.Controls.Remove(user_panel);

            calander_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(calander_panel);

        }

        private void Settings_btn_Click(object sender, EventArgs e)
        {

            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(email_panel);
            dash_container.Controls.Remove(reminders_panel);
            dash_container.Controls.Remove(user_panel);


            settings_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(settings_panel);

        }

        private void Assignments_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(email_panel);
            dash_container.Controls.Remove(reminders_panel);
            dash_container.Controls.Remove(user_panel);


            assignments_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(assignments_panel);

        }


        private void Evaluations_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(email_panel);
            dash_container.Controls.Remove(reminders_panel);
            dash_container.Controls.Remove(user_panel);


            evaluations_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(evaluations_panel);

        }

        private void Reminders_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(email_panel);
            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(user_panel);


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
            dash_container.Controls.Remove(user_panel);


            email_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(email_panel);
        }

        private void Users_btn_Click(object sender, EventArgs e)
        {
            dash_container.Controls.Remove(assignments_panel);
            dash_container.Controls.Remove(settings_panel);
            dash_container.Controls.Remove(calander_panel);
            dash_container.Controls.Remove(reminders_panel);
            dash_container.Controls.Remove(evaluations_panel);
            dash_container.Controls.Remove(email_panel);


            user_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(user_panel);
        }

        //log out button
        private void logout_lbl_Click(object sender, EventArgs e)
        {
            //login_page lp = new login_page();
            this.Hide();
            login_page lp = new login_page();

            lp.ShowDialog();
            this.Close();
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

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }

    }
}
