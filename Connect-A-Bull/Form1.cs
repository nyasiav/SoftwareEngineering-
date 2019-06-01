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

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Register_label_Click(object sender, EventArgs e)
        {

        }

        private void Pass_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void BunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void Sign_up_button_Click(object sender, EventArgs e)
        {
            
        }

        private void Sign_up_button_Click_1(object sender, EventArgs e)
        {
            register_form reg_form = new register_form();
            reg_form.Show();

        }

        private void Label5_Click(object sender, EventArgs e)
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

        private void Login_page_Load(object sender, EventArgs e)
        {
            name_box.Focus();
        }
    }
}
