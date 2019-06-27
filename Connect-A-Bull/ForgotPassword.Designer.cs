namespace Connect_A_Bull
{
    partial class ForgotPassword
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
            this.components = new System.ComponentModel.Container();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Label();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.forgot_pass_message = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.confirm_email_label = new System.Windows.Forms.Label();
            this.email_box = new System.Windows.Forms.TextBox();
            this.confirm_email_box = new System.Windows.Forms.TextBox();
            this.send_email_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.minimize_btn.Location = new System.Drawing.Point(1296, 16);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(26, 36);
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
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.exit_btn.Location = new System.Drawing.Point(1334, 23);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(27, 25);
            this.exit_btn.TabIndex = 42;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.Transparent;
            this.drag_panel.Location = new System.Drawing.Point(8, 6);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(1267, 48);
            this.drag_panel.TabIndex = 44;
            this.drag_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.drag_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.drag_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // forgot_pass_message
            // 
            this.forgot_pass_message.AutoSize = true;
            this.forgot_pass_message.BackColor = System.Drawing.Color.Transparent;
            this.forgot_pass_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_pass_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.forgot_pass_message.Location = new System.Drawing.Point(482, 287);
            this.forgot_pass_message.Name = "forgot_pass_message";
            this.forgot_pass_message.Size = new System.Drawing.Size(404, 40);
            this.forgot_pass_message.TabIndex = 45;
            this.forgot_pass_message.Text = "Please enter your email and we will send you a\nlink with a temporary password.";
            this.forgot_pass_message.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.email_label.Location = new System.Drawing.Point(660, 383);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(62, 18);
            this.email_label.TabIndex = 46;
            this.email_label.Text = "E-MAIL";
            // 
            // confirm_email_label
            // 
            this.confirm_email_label.AutoSize = true;
            this.confirm_email_label.BackColor = System.Drawing.Color.Transparent;
            this.confirm_email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.confirm_email_label.Location = new System.Drawing.Point(617, 475);
            this.confirm_email_label.Name = "confirm_email_label";
            this.confirm_email_label.Size = new System.Drawing.Size(144, 18);
            this.confirm_email_label.TabIndex = 47;
            this.confirm_email_label.Text = "CONFIRM E-MAIL";
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.Color.Gainsboro;
            this.email_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(580, 411);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(223, 23);
            this.email_box.TabIndex = 48;
            // 
            // confirm_email_box
            // 
            this.confirm_email_box.BackColor = System.Drawing.Color.Gainsboro;
            this.confirm_email_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirm_email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_email_box.Location = new System.Drawing.Point(580, 506);
            this.confirm_email_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirm_email_box.Name = "confirm_email_box";
            this.confirm_email_box.Size = new System.Drawing.Size(223, 23);
            this.confirm_email_box.TabIndex = 49;
            // 
            // send_email_button
            // 
            this.send_email_button.Activecolor = System.Drawing.Color.DarkCyan;
            this.send_email_button.BackColor = System.Drawing.Color.DarkCyan;
            this.send_email_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.send_email_button.BorderRadius = 5;
            this.send_email_button.ButtonText = "Send";
            this.send_email_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_email_button.DisabledColor = System.Drawing.Color.Gray;
            this.send_email_button.Iconcolor = System.Drawing.Color.Transparent;
            this.send_email_button.Iconimage = null;
            this.send_email_button.Iconimage_right = null;
            this.send_email_button.Iconimage_right_Selected = null;
            this.send_email_button.Iconimage_Selected = null;
            this.send_email_button.IconMarginLeft = 0;
            this.send_email_button.IconMarginRight = 0;
            this.send_email_button.IconRightVisible = true;
            this.send_email_button.IconRightZoom = 0D;
            this.send_email_button.IconVisible = true;
            this.send_email_button.IconZoom = 90D;
            this.send_email_button.IsTab = false;
            this.send_email_button.Location = new System.Drawing.Point(580, 609);
            this.send_email_button.Margin = new System.Windows.Forms.Padding(5);
            this.send_email_button.Name = "send_email_button";
            this.send_email_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.send_email_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.send_email_button.OnHoverTextColor = System.Drawing.Color.White;
            this.send_email_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.send_email_button.selected = false;
            this.send_email_button.Size = new System.Drawing.Size(223, 32);
            this.send_email_button.TabIndex = 50;
            this.send_email_button.Text = "Send";
            this.send_email_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.send_email_button.Textcolor = System.Drawing.Color.White;
            this.send_email_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_email_button.Click += new System.EventHandler(this.send_email_button_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Connect_A_Bull.Resource1.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.send_email_button);
            this.Controls.Add(this.confirm_email_box);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.confirm_email_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.forgot_pass_message);
            this.Controls.Add(this.drag_panel);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Label exit_btn;
        private System.Windows.Forms.Panel drag_panel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label forgot_pass_message;
        private System.Windows.Forms.Label confirm_email_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox confirm_email_box;
        private Bunifu.Framework.UI.BunifuFlatButton send_email_button;
    }
}