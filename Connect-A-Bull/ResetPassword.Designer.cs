namespace Connect_A_Bull
{
    partial class drag_panel
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
            this.minimize_btn = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.new_pass_label = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.TextBox();
            this.confirm_new_password = new System.Windows.Forms.TextBox();
            this.confirm_new_pass_label = new System.Windows.Forms.Label();
            this.submit_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.minimize_btn.Location = new System.Drawing.Point(1291, 9);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 38);
            this.minimize_btn.TabIndex = 43;
            this.minimize_btn.Text = "-";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.AutoSize = true;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.exit_btn.Location = new System.Drawing.Point(1329, 16);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(27, 26);
            this.exit_btn.TabIndex = 42;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 57);
            this.panel1.TabIndex = 44;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // new_pass_label
            // 
            this.new_pass_label.AutoSize = true;
            this.new_pass_label.BackColor = System.Drawing.Color.Transparent;
            this.new_pass_label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.new_pass_label.Location = new System.Drawing.Point(570, 308);
            this.new_pass_label.Name = "new_pass_label";
            this.new_pass_label.Size = new System.Drawing.Size(142, 23);
            this.new_pass_label.TabIndex = 45;
            this.new_pass_label.Text = "New Password";
            // 
            // new_password
            // 
            this.new_password.BackColor = System.Drawing.Color.Gainsboro;
            this.new_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_password.Location = new System.Drawing.Point(574, 345);
            this.new_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(223, 23);
            this.new_password.TabIndex = 46;
            // 
            // confirm_new_password
            // 
            this.confirm_new_password.BackColor = System.Drawing.Color.Gainsboro;
            this.confirm_new_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_new_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_new_password.Location = new System.Drawing.Point(574, 452);
            this.confirm_new_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_new_password.Name = "confirm_new_password";
            this.confirm_new_password.PasswordChar = '*';
            this.confirm_new_password.Size = new System.Drawing.Size(223, 23);
            this.confirm_new_password.TabIndex = 48;
            // 
            // confirm_new_pass_label
            // 
            this.confirm_new_pass_label.AutoSize = true;
            this.confirm_new_pass_label.BackColor = System.Drawing.Color.Transparent;
            this.confirm_new_pass_label.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_new_pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.confirm_new_pass_label.Location = new System.Drawing.Point(570, 415);
            this.confirm_new_pass_label.Name = "confirm_new_pass_label";
            this.confirm_new_pass_label.Size = new System.Drawing.Size(219, 23);
            this.confirm_new_pass_label.TabIndex = 47;
            this.confirm_new_pass_label.Text = "Confirm New Password";
            // 
            // submit_button
            // 
            this.submit_button.Activecolor = System.Drawing.Color.DarkCyan;
            this.submit_button.BackColor = System.Drawing.Color.DarkCyan;
            this.submit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.submit_button.BorderRadius = 5;
            this.submit_button.ButtonText = "Submit";
            this.submit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_button.DisabledColor = System.Drawing.Color.Gray;
            this.submit_button.Iconcolor = System.Drawing.Color.Transparent;
            this.submit_button.Iconimage = null;
            this.submit_button.Iconimage_right = null;
            this.submit_button.Iconimage_right_Selected = null;
            this.submit_button.Iconimage_Selected = null;
            this.submit_button.IconMarginLeft = 0;
            this.submit_button.IconMarginRight = 0;
            this.submit_button.IconRightVisible = true;
            this.submit_button.IconRightZoom = 0D;
            this.submit_button.IconVisible = true;
            this.submit_button.IconZoom = 90D;
            this.submit_button.IsTab = false;
            this.submit_button.Location = new System.Drawing.Point(574, 532);
            this.submit_button.Margin = new System.Windows.Forms.Padding(5);
            this.submit_button.Name = "submit_button";
            this.submit_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.submit_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.submit_button.OnHoverTextColor = System.Drawing.Color.White;
            this.submit_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.submit_button.selected = false;
            this.submit_button.Size = new System.Drawing.Size(223, 32);
            this.submit_button.TabIndex = 49;
            this.submit_button.Text = "Submit";
            this.submit_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.submit_button.Textcolor = System.Drawing.Color.White;
            this.submit_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // drag_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Connect_A_Bull.Resource1.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 741);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.confirm_new_password);
            this.Controls.Add(this.confirm_new_pass_label);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.new_pass_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "drag_panel";
            this.Text = "ResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Label exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label new_pass_label;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.TextBox confirm_new_password;
        private System.Windows.Forms.Label confirm_new_pass_label;
        private Bunifu.Framework.UI.BunifuFlatButton submit_button;
    }
}