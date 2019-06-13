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
    public partial class register_form : Form
    {
        public register_form()
        {
            InitializeComponent();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
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
            this.Hide();
            Dashboard dash_form = new Dashboard();
            dash_form.FormClosed += (s, args) => this.Close();
            dash_form.Show();
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

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mouse_x = Cursor.Position.X - this.Left;
            mouse_y = Cursor.Position.Y - this.Top;
        }
    }
}
