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

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Calendar_btn_Click(object sender, EventArgs e)
        {
            Calendar calander_panel = new Calendar();
            calander_panel.Dock = DockStyle.Fill;
            dash_container.Controls.Add(calander_panel);
            
        }

        private void Exit_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
