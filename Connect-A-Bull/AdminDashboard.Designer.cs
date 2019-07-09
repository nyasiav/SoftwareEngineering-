namespace Connect_A_Bull
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.users_btn = new System.Windows.Forms.Button();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.settings_btn = new System.Windows.Forms.Button();
            this.email_btn = new System.Windows.Forms.Button();
            this.home_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.drag_panel2 = new System.Windows.Forms.Panel();
            this.dash_container = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.users_btn);
            this.panel1.Controls.Add(this.logout_lbl);
            this.panel1.Controls.Add(this.drag_panel);
            this.panel1.Controls.Add(this.settings_btn);
            this.panel1.Controls.Add(this.email_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 788);
            this.panel1.TabIndex = 1;
            // 
            // users_btn
            // 
            this.users_btn.FlatAppearance.BorderSize = 0;
            this.users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.users_btn.ForeColor = System.Drawing.Color.White;
            this.users_btn.Location = new System.Drawing.Point(4, 376);
            this.users_btn.Margin = new System.Windows.Forms.Padding(4);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(311, 53);
            this.users_btn.TabIndex = 9;
            this.users_btn.Text = "Users";
            this.users_btn.UseVisualStyleBackColor = true;
            this.users_btn.Click += new System.EventHandler(this.Users_btn_Click);
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.logout_lbl.ForeColor = System.Drawing.Color.White;
            this.logout_lbl.Location = new System.Drawing.Point(124, 734);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(77, 25);
            this.logout_lbl.TabIndex = 8;
            this.logout_lbl.Text = "log out";
            this.logout_lbl.Click += new System.EventHandler(this.logout_lbl_Click);
            // 
            // drag_panel
            // 
            this.drag_panel.Location = new System.Drawing.Point(12, 7);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(303, 22);
            this.drag_panel.TabIndex = 7;
            this.drag_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.drag_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.drag_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // settings_btn
            // 
            this.settings_btn.FlatAppearance.BorderSize = 0;
            this.settings_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.settings_btn.ForeColor = System.Drawing.Color.White;
            this.settings_btn.Location = new System.Drawing.Point(4, 426);
            this.settings_btn.Margin = new System.Windows.Forms.Padding(4);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(311, 53);
            this.settings_btn.TabIndex = 6;
            this.settings_btn.Text = "Settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // email_btn
            // 
            this.email_btn.FlatAppearance.BorderSize = 0;
            this.email_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.email_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.email_btn.ForeColor = System.Drawing.Color.White;
            this.email_btn.Location = new System.Drawing.Point(4, 328);
            this.email_btn.Margin = new System.Windows.Forms.Padding(4);
            this.email_btn.Name = "email_btn";
            this.email_btn.Size = new System.Drawing.Size(311, 53);
            this.email_btn.TabIndex = 3;
            this.email_btn.Text = "Email";
            this.email_btn.UseVisualStyleBackColor = true;
            this.email_btn.Click += new System.EventHandler(this.Email_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.Transparent;
            this.home_btn.Image = global::Connect_A_Bull.Resource1.logo2_blue;
            this.home_btn.ImageActive = null;
            this.home_btn.Location = new System.Drawing.Point(41, 36);
            this.home_btn.Margin = new System.Windows.Forms.Padding(4);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(235, 92);
            this.home_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_btn.TabIndex = 0;
            this.home_btn.TabStop = false;
            this.home_btn.Zoom = 10;
            // 
            // drag_panel2
            // 
            this.drag_panel2.Location = new System.Drawing.Point(326, 7);
            this.drag_panel2.Name = "drag_panel2";
            this.drag_panel2.Size = new System.Drawing.Size(969, 22);
            this.drag_panel2.TabIndex = 48;
            this.drag_panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.drag_panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.drag_panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // dash_container
            // 
            this.dash_container.Location = new System.Drawing.Point(338, 52);
            this.dash_container.Margin = new System.Windows.Forms.Padding(4);
            this.dash_container.Name = "dash_container";
            this.dash_container.Size = new System.Drawing.Size(1036, 707);
            this.dash_container.TabIndex = 47;
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(1313, 0);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(26, 36);
            this.minimize_btn.TabIndex = 50;
            this.minimize_btn.Text = "-";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.AutoSize = true;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(1347, 7);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(27, 25);
            this.exit_btn.TabIndex = 49;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.drag_panel2);
            this.Controls.Add(this.dash_container);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.Panel drag_panel;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button email_btn;
        private Bunifu.Framework.UI.BunifuImageButton home_btn;
        private System.Windows.Forms.Panel drag_panel2;
        private System.Windows.Forms.Panel dash_container;
        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Label exit_btn;
        private System.Windows.Forms.Button users_btn;
    }
}