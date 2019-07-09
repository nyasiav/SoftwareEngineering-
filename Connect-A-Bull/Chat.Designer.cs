namespace Connect_A_Bull
{
    partial class Chat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dash_container = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.body_label = new System.Windows.Forms.Label();
            this.email_to_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.subject_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.send_email_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.email_body = new System.Windows.Forms.TextBox();
            this.email_subject = new System.Windows.Forms.TextBox();
            this.to_email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.file_attactment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dash_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // dash_container
            // 
            this.dash_container.Controls.Add(this.label1);
            this.dash_container.Controls.Add(this.file_attactment);
            this.dash_container.Controls.Add(this.bunifuFlatButton1);
            this.dash_container.Controls.Add(this.body_label);
            this.dash_container.Controls.Add(this.email_to_label);
            this.dash_container.Controls.Add(this.password_label);
            this.dash_container.Controls.Add(this.subject_label);
            this.dash_container.Controls.Add(this.email_label);
            this.dash_container.Controls.Add(this.send_email_button);
            this.dash_container.Controls.Add(this.email_body);
            this.dash_container.Controls.Add(this.email_subject);
            this.dash_container.Controls.Add(this.to_email);
            this.dash_container.Controls.Add(this.password);
            this.dash_container.Controls.Add(this.email_box);
            this.dash_container.Location = new System.Drawing.Point(18, 41);
            this.dash_container.Margin = new System.Windows.Forms.Padding(4);
            this.dash_container.Name = "dash_container";
            this.dash_container.Size = new System.Drawing.Size(1036, 707);
            this.dash_container.TabIndex = 2;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "Browse";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(695, 446);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(223, 32);
            this.bunifuFlatButton1.TabIndex = 61;
            this.bunifuFlatButton1.Text = "Browse";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.browse_Button_Click);
            // 
            // body_label
            // 
            this.body_label.AutoSize = true;
            this.body_label.BackColor = System.Drawing.Color.Transparent;
            this.body_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body_label.ForeColor = System.Drawing.Color.White;
            this.body_label.Location = new System.Drawing.Point(92, 179);
            this.body_label.Name = "body_label";
            this.body_label.Size = new System.Drawing.Size(54, 18);
            this.body_label.TabIndex = 60;
            this.body_label.Text = "BODY";
            // 
            // email_to_label
            // 
            this.email_to_label.AutoSize = true;
            this.email_to_label.BackColor = System.Drawing.Color.Transparent;
            this.email_to_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_to_label.ForeColor = System.Drawing.Color.White;
            this.email_to_label.Location = new System.Drawing.Point(92, 90);
            this.email_to_label.Name = "email_to_label";
            this.email_to_label.Size = new System.Drawing.Size(31, 18);
            this.email_to_label.TabIndex = 59;
            this.email_to_label.Text = "TO";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(92, 53);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(104, 18);
            this.password_label.TabIndex = 58;
            this.password_label.Text = "PASSWORD";
            // 
            // subject_label
            // 
            this.subject_label.AutoSize = true;
            this.subject_label.BackColor = System.Drawing.Color.Transparent;
            this.subject_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_label.ForeColor = System.Drawing.Color.White;
            this.subject_label.Location = new System.Drawing.Point(92, 138);
            this.subject_label.Name = "subject_label";
            this.subject_label.Size = new System.Drawing.Size(84, 18);
            this.subject_label.TabIndex = 56;
            this.subject_label.Text = "SUBJECT";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(92, 22);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(62, 18);
            this.email_label.TabIndex = 55;
            this.email_label.Text = "E-MAIL";
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
            this.send_email_button.Location = new System.Drawing.Point(350, 547);
            this.send_email_button.Margin = new System.Windows.Forms.Padding(5);
            this.send_email_button.Name = "send_email_button";
            this.send_email_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.send_email_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.send_email_button.OnHoverTextColor = System.Drawing.Color.White;
            this.send_email_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.send_email_button.selected = false;
            this.send_email_button.Size = new System.Drawing.Size(223, 32);
            this.send_email_button.TabIndex = 54;
            this.send_email_button.Text = "Send";
            this.send_email_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.send_email_button.Textcolor = System.Drawing.Color.White;
            this.send_email_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_email_button.Click += new System.EventHandler(this.send_email_button_Click);
            // 
            // email_body
            // 
            this.email_body.Location = new System.Drawing.Point(201, 178);
            this.email_body.Multiline = true;
            this.email_body.Name = "email_body";
            this.email_body.Size = new System.Drawing.Size(453, 249);
            this.email_body.TabIndex = 53;
            // 
            // email_subject
            // 
            this.email_subject.BackColor = System.Drawing.Color.Gainsboro;
            this.email_subject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_subject.Location = new System.Drawing.Point(202, 133);
            this.email_subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_subject.Name = "email_subject";
            this.email_subject.Size = new System.Drawing.Size(452, 23);
            this.email_subject.TabIndex = 52;
            // 
            // to_email
            // 
            this.to_email.BackColor = System.Drawing.Color.Gainsboro;
            this.to_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.to_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_email.Location = new System.Drawing.Point(202, 90);
            this.to_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.to_email.Name = "to_email";
            this.to_email.Size = new System.Drawing.Size(223, 23);
            this.to_email.TabIndex = 51;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gainsboro;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(202, 53);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(223, 23);
            this.password.TabIndex = 50;
            // 
            // email_box
            // 
            this.email_box.BackColor = System.Drawing.Color.Gainsboro;
            this.email_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_box.Location = new System.Drawing.Point(202, 17);
            this.email_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(223, 23);
            this.email_box.TabIndex = 49;
            // 
            // file_attactment
            // 
            this.file_attactment.BackColor = System.Drawing.Color.Gainsboro;
            this.file_attactment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.file_attactment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_attactment.Location = new System.Drawing.Point(202, 446);
            this.file_attactment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.file_attactment.Name = "file_attactment";
            this.file_attactment.Size = new System.Drawing.Size(452, 23);
            this.file_attactment.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 63;
            this.label1.Text = "ATTACHMENT";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dash_container);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(1073, 788);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.dash_container.ResumeLayout(false);
            this.dash_container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dash_container;
        private System.Windows.Forms.Label body_label;
        private System.Windows.Forms.Label email_to_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.Label email_label;
        private Bunifu.Framework.UI.BunifuFlatButton send_email_button;
        private System.Windows.Forms.TextBox email_body;
        private System.Windows.Forms.TextBox email_subject;
        private System.Windows.Forms.TextBox to_email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email_box;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.TextBox file_attactment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
