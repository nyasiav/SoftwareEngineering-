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
    public partial class login_page : Form
    {
        public login_page()
        {
            InitializeComponent();
        }

        private void Username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            register_form reg_form = new register_form();
            reg_form.FormClosed += (s, args) => this.Close();
            reg_form.Show();

        }

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
            this.Hide();
            Dashboard dash_form = new Dashboard();
            dash_form.FormClosed += (s, args) => this.Close();
            dash_form.Show();

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

    }
}
