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
    public partial class Dashboard : Form
    {

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
            Application.Exit();
        }

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            Calendar calander_panel = new Calendar();
            calander_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(calander_panel);
            
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
