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
            this.username_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username_box
            // 
            this.username_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.username_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_box.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.Location = new System.Drawing.Point(428, 278);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(253, 15);
            this.username_box.TabIndex = 0;
            this.username_box.TextChanged += new System.EventHandler(this.Username_box_TextChanged);
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(455, 358);
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
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "_______________________________";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // pass_box
            // 
            this.pass_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.pass_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_box.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_box.Location = new System.Drawing.Point(428, 315);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(253, 15);
            this.pass_box.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "_______________________________";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(78)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(1055, 597);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login_page";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.Label label4;
    }
}

