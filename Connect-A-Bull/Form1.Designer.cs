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
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.register_label = new System.Windows.Forms.Label();
            this.sign_up_button = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.name_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(689, 482);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(94, 32);
            this.login_button.TabIndex = 2;
            this.login_button.Text = "Login!";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label1.Location = new System.Drawing.Point(512, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
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
            this.label2.Location = new System.Drawing.Point(512, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(655, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.label4.Location = new System.Drawing.Point(654, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.BackColor = System.Drawing.Color.Transparent;
            this.register_label.Font = new System.Drawing.Font("Century Gothic", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(91)))), ((int)(((byte)(124)))));
            this.register_label.Location = new System.Drawing.Point(512, 661);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(384, 19);
            this.register_label.TabIndex = 8;
            this.register_label.Text = "Don\'t have an account? Click here to sign up!";
            this.register_label.Click += new System.EventHandler(this.Register_label_Click);
            // 
            // sign_up_button
            // 
            this.sign_up_button.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up_button.Location = new System.Drawing.Point(660, 693);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(99, 42);
            this.sign_up_button.TabIndex = 9;
            this.sign_up_button.Text = "Sign Up!";
            this.sign_up_button.UseVisualStyleBackColor = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(637, 393);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(172, 22);
            this.name_box.TabIndex = 10;
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(637, 437);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(172, 22);
            this.pass_box.TabIndex = 11;
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = global::Connect_A_Bull.Resource1.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_page";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Button sign_up_button;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox name_box;
    }
}

