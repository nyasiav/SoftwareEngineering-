﻿namespace Connect_A_Bull
{
    partial class login_page
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
            this.username_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.name_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sign_up_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exit_btn = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.forgot_password = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.username_label.Location = new System.Drawing.Point(575, 332);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(105, 24);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Username";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.BackColor = System.Drawing.Color.Transparent;
            this.pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.pass_label.Location = new System.Drawing.Point(575, 396);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(100, 24);
            this.pass_label.TabIndex = 4;
            this.pass_label.Text = "Password";
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.BackColor = System.Drawing.Color.Transparent;
            this.register_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.register_label.Location = new System.Drawing.Point(605, 538);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(180, 17);
            this.register_label.TabIndex = 8;
            this.register_label.Text = "Don\'t have an account?";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // name_box
            // 
            this.name_box.BackColor = System.Drawing.Color.Gainsboro;
            this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(579, 357);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(223, 23);
            this.name_box.TabIndex = 10;
            this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.Color.Gainsboro;
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(579, 421);
            this.pass_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass_box.Name = "pass_box";
            this.pass_box.PasswordChar = '*';
            this.pass_box.Size = new System.Drawing.Size(223, 23);
            this.pass_box.TabIndex = 11;
            // 
            // login_button
            // 
            this.login_button.Activecolor = System.Drawing.Color.DarkCyan;
            this.login_button.BackColor = System.Drawing.Color.DarkCyan;
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_button.BorderRadius = 5;
            this.login_button.ButtonText = "Login";
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.DisabledColor = System.Drawing.Color.Gray;
            this.login_button.Iconcolor = System.Drawing.Color.Transparent;
            this.login_button.Iconimage = null;
            this.login_button.Iconimage_right = null;
            this.login_button.Iconimage_right_Selected = null;
            this.login_button.Iconimage_Selected = null;
            this.login_button.IconMarginLeft = 0;
            this.login_button.IconMarginRight = 0;
            this.login_button.IconRightVisible = true;
            this.login_button.IconRightZoom = 0D;
            this.login_button.IconVisible = true;
            this.login_button.IconZoom = 90D;
            this.login_button.IsTab = false;
            this.login_button.Location = new System.Drawing.Point(579, 460);
            this.login_button.Margin = new System.Windows.Forms.Padding(5);
            this.login_button.Name = "login_button";
            this.login_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.login_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.login_button.OnHoverTextColor = System.Drawing.Color.White;
            this.login_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_button.selected = false;
            this.login_button.Size = new System.Drawing.Size(223, 32);
            this.login_button.TabIndex = 35;
            this.login_button.Text = "Login";
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Textcolor = System.Drawing.Color.White;
            this.login_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // sign_up_button
            // 
            this.sign_up_button.Activecolor = System.Drawing.Color.LimeGreen;
            this.sign_up_button.BackColor = System.Drawing.Color.LimeGreen;
            this.sign_up_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sign_up_button.BorderRadius = 5;
            this.sign_up_button.ButtonText = "Register";
            this.sign_up_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_up_button.DisabledColor = System.Drawing.Color.Gray;
            this.sign_up_button.Iconcolor = System.Drawing.Color.Transparent;
            this.sign_up_button.Iconimage = null;
            this.sign_up_button.Iconimage_right = null;
            this.sign_up_button.Iconimage_right_Selected = null;
            this.sign_up_button.Iconimage_Selected = null;
            this.sign_up_button.IconMarginLeft = 0;
            this.sign_up_button.IconMarginRight = 0;
            this.sign_up_button.IconRightVisible = true;
            this.sign_up_button.IconRightZoom = 0D;
            this.sign_up_button.IconVisible = true;
            this.sign_up_button.IconZoom = 90D;
            this.sign_up_button.IsTab = false;
            this.sign_up_button.Location = new System.Drawing.Point(638, 573);
            this.sign_up_button.Margin = new System.Windows.Forms.Padding(5);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Normalcolor = System.Drawing.Color.LimeGreen;
            this.sign_up_button.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.sign_up_button.OnHoverTextColor = System.Drawing.Color.White;
            this.sign_up_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sign_up_button.selected = false;
            this.sign_up_button.Size = new System.Drawing.Size(101, 32);
            this.sign_up_button.TabIndex = 36;
            this.sign_up_button.Text = "Register";
            this.sign_up_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sign_up_button.Textcolor = System.Drawing.Color.White;
            this.sign_up_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_button.Click += new System.EventHandler(this.Sign_up_button_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.AutoSize = true;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.exit_btn.Location = new System.Drawing.Point(1343, 11);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(27, 25);
            this.exit_btn.TabIndex = 38;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.minimize_btn.Location = new System.Drawing.Point(1305, 4);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(26, 36);
            this.minimize_btn.TabIndex = 41;
            this.minimize_btn.Text = "-";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.Transparent;
            this.drag_panel.Location = new System.Drawing.Point(14, 10);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(1284, 44);
            this.drag_panel.TabIndex = 43;
            this.drag_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.drag_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.drag_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // forgot_password
            // 
            this.forgot_password.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.forgot_password.AutoSize = true;
            this.forgot_password.BackColor = System.Drawing.Color.Transparent;
            this.forgot_password.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.forgot_password.Location = new System.Drawing.Point(611, 508);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(174, 17);
            this.forgot_password.TabIndex = 44;
            this.forgot_password.TabStop = true;
            this.forgot_password.Text = "Forgot your password?";
            this.forgot_password.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgot_password_LinkClicked);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Connect_A_Bull.Resource1.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.drag_panel);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.username_label);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label register_label;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox name_box;
        private Bunifu.Framework.UI.BunifuFlatButton login_button;
        private Bunifu.Framework.UI.BunifuFlatButton sign_up_button;
        private System.Windows.Forms.Label exit_btn;
        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Panel drag_panel;
        private System.Windows.Forms.LinkLabel forgot_password;
    }
}

