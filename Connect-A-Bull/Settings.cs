using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect_A_Bull
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void add_token_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(token_box.Text))
            {
                MessageBox.Show("Field is blank");
            }
            else
            {
                login_page.rpUser.CanvasToken = token_box.Text;
                SQLiteDataAccess.UpdateUserCanvasToken(login_page.rpUser);
                MessageBox.Show("Token added");
                token_box.Clear();
            }
        }
    }
}
