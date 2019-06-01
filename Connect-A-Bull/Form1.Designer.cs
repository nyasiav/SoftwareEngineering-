namespace Connect_A_Bull
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.name_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.login_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sign_up_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exit_btn = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(431, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label2.Location = new System.Drawing.Point(431, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(538, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(537, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.BackColor = System.Drawing.Color.Transparent;
            this.register_label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.register_label.Location = new System.Drawing.Point(450, 432);
            this.register_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(135, 15);
            this.register_label.TabIndex = 8;
            this.register_label.Text = "Don\'t have an account?";
            this.register_label.Click += new System.EventHandler(this.Register_label_Click);
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
            this.name_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_box.Location = new System.Drawing.Point(434, 290);
            this.name_box.Margin = new System.Windows.Forms.Padding(2);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(167, 19);
            this.name_box.TabIndex = 10;
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.Color.Gainsboro;
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_box.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(434, 342);
            this.pass_box.Margin = new System.Windows.Forms.Padding(2);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(167, 19);
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
            this.login_button.Location = new System.Drawing.Point(434, 374);
            this.login_button.Name = "login_button";
            this.login_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.login_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.login_button.OnHoverTextColor = System.Drawing.Color.White;
            this.login_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login_button.selected = false;
            this.login_button.Size = new System.Drawing.Size(167, 26);
            this.login_button.TabIndex = 35;
            this.login_button.Text = "Login";
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Textcolor = System.Drawing.Color.White;
            this.login_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.sign_up_button.Location = new System.Drawing.Point(477, 456);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Normalcolor = System.Drawing.Color.LimeGreen;
            this.sign_up_button.OnHovercolor = System.Drawing.Color.LawnGreen;
            this.sign_up_button.OnHoverTextColor = System.Drawing.Color.White;
            this.sign_up_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sign_up_button.selected = false;
            this.sign_up_button.Size = new System.Drawing.Size(76, 26);
            this.sign_up_button.TabIndex = 36;
            this.sign_up_button.Text = "Register";
            this.sign_up_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sign_up_button.Textcolor = System.Drawing.Color.White;
            this.sign_up_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_button.Click += new System.EventHandler(this.Sign_up_button_Click_1);
            // 
            // exit_btn
            // 
            this.exit_btn.AutoSize = true;
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.exit_btn.Location = new System.Drawing.Point(1007, 9);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(21, 20);
            this.exit_btn.TabIndex = 38;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.minimize_btn.Location = new System.Drawing.Point(979, 3);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(25, 29);
            this.minimize_btn.TabIndex = 41;
            this.minimize_btn.Text = "-";
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Connect_A_Bull.Resource1.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 640);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label register_label;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox name_box;
        private Bunifu.Framework.UI.BunifuFlatButton login_button;
        private Bunifu.Framework.UI.BunifuFlatButton sign_up_button;
        private System.Windows.Forms.Label exit_btn;
        private System.Windows.Forms.Label minimize_btn;
    }
}

