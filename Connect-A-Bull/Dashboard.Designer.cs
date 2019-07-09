namespace Connect_A_Bull
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_lbl = new System.Windows.Forms.Label();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.settings_btn = new System.Windows.Forms.Button();
            this.reminders_btn = new System.Windows.Forms.Button();
            this.eval_btn = new System.Windows.Forms.Button();
            this.chat_btn = new System.Windows.Forms.Button();
            this.assignments_btn = new System.Windows.Forms.Button();
            this.calendar_btn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dash_container = new System.Windows.Forms.Panel();
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
            this.minimize_btn = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Label();
            this.drag_panel2 = new System.Windows.Forms.Panel();
            this.home_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).BeginInit();
            this.dash_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.logout_lbl);
            this.panel1.Controls.Add(this.drag_panel);
            this.panel1.Controls.Add(this.settings_btn);
            this.panel1.Controls.Add(this.reminders_btn);
            this.panel1.Controls.Add(this.eval_btn);
            this.panel1.Controls.Add(this.chat_btn);
            this.panel1.Controls.Add(this.assignments_btn);
            this.panel1.Controls.Add(this.calendar_btn);
            this.panel1.Controls.Add(this.home_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 788);
            this.panel1.TabIndex = 0;
            // 
            // logout_lbl
            // 
            this.logout_lbl.AutoSize = true;
            this.logout_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.logout_lbl.ForeColor = System.Drawing.Color.White;
            this.logout_lbl.Location = new System.Drawing.Point(115, 736);
            this.logout_lbl.Name = "logout_lbl";
            this.logout_lbl.Size = new System.Drawing.Size(78, 23);
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
            this.settings_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.settings_btn.ForeColor = System.Drawing.Color.White;
            this.settings_btn.Location = new System.Drawing.Point(4, 599);
            this.settings_btn.Margin = new System.Windows.Forms.Padding(4);
            this.settings_btn.Name = "settings_btn";
            this.settings_btn.Size = new System.Drawing.Size(311, 53);
            this.settings_btn.TabIndex = 6;
            this.settings_btn.Text = "settings";
            this.settings_btn.UseVisualStyleBackColor = true;
            this.settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // reminders_btn
            // 
            this.reminders_btn.FlatAppearance.BorderSize = 0;
            this.reminders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminders_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.reminders_btn.ForeColor = System.Drawing.Color.White;
            this.reminders_btn.Location = new System.Drawing.Point(4, 526);
            this.reminders_btn.Margin = new System.Windows.Forms.Padding(4);
            this.reminders_btn.Name = "reminders_btn";
            this.reminders_btn.Size = new System.Drawing.Size(311, 53);
            this.reminders_btn.TabIndex = 5;
            this.reminders_btn.Text = "reminders";
            this.reminders_btn.UseVisualStyleBackColor = true;
            this.reminders_btn.Click += new System.EventHandler(this.Reminders_btn_Click);
            // 
            // eval_btn
            // 
            this.eval_btn.FlatAppearance.BorderSize = 0;
            this.eval_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eval_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.eval_btn.ForeColor = System.Drawing.Color.White;
            this.eval_btn.Location = new System.Drawing.Point(4, 452);
            this.eval_btn.Margin = new System.Windows.Forms.Padding(4);
            this.eval_btn.Name = "eval_btn";
            this.eval_btn.Size = new System.Drawing.Size(311, 53);
            this.eval_btn.TabIndex = 4;
            this.eval_btn.Text = "evaluations";
            this.eval_btn.UseVisualStyleBackColor = true;
            this.eval_btn.Click += new System.EventHandler(this.Evaluations_btn_Click);
            // 
            // chat_btn
            // 
            this.chat_btn.FlatAppearance.BorderSize = 0;
            this.chat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chat_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.chat_btn.ForeColor = System.Drawing.Color.White;
            this.chat_btn.Location = new System.Drawing.Point(4, 378);
            this.chat_btn.Margin = new System.Windows.Forms.Padding(4);
            this.chat_btn.Name = "chat_btn";
            this.chat_btn.Size = new System.Drawing.Size(311, 53);
            this.chat_btn.TabIndex = 3;
            this.chat_btn.Text = "email";
            this.chat_btn.UseVisualStyleBackColor = true;
            this.chat_btn.Click += new System.EventHandler(this.Chat_btn_Click);
            // 
            // assignments_btn
            // 
            this.assignments_btn.FlatAppearance.BorderSize = 0;
            this.assignments_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignments_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.assignments_btn.ForeColor = System.Drawing.Color.White;
            this.assignments_btn.Location = new System.Drawing.Point(4, 304);
            this.assignments_btn.Margin = new System.Windows.Forms.Padding(4);
            this.assignments_btn.Name = "assignments_btn";
            this.assignments_btn.Size = new System.Drawing.Size(311, 53);
            this.assignments_btn.TabIndex = 2;
            this.assignments_btn.Text = "assignments";
            this.assignments_btn.UseVisualStyleBackColor = true;
            this.assignments_btn.Click += new System.EventHandler(this.Assignments_btn_Click);
            // 
            // calendar_btn
            // 
            this.calendar_btn.FlatAppearance.BorderSize = 0;
            this.calendar_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calendar_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendar_btn.ForeColor = System.Drawing.Color.White;
            this.calendar_btn.Location = new System.Drawing.Point(4, 230);
            this.calendar_btn.Margin = new System.Windows.Forms.Padding(4);
            this.calendar_btn.Name = "calendar_btn";
            this.calendar_btn.Size = new System.Drawing.Size(311, 53);
            this.calendar_btn.TabIndex = 1;
            this.calendar_btn.Text = "calendar";
            this.calendar_btn.UseVisualStyleBackColor = true;
            this.calendar_btn.Click += new System.EventHandler(this.Calendar_btn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // dash_container
            // 
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
            this.dash_container.Location = new System.Drawing.Point(338, 52);
            this.dash_container.Margin = new System.Windows.Forms.Padding(4);
            this.dash_container.Name = "dash_container";
            this.dash_container.Size = new System.Drawing.Size(1036, 707);
            this.dash_container.TabIndex = 1;
            this.dash_container.Paint += new System.Windows.Forms.PaintEventHandler(this.dash_container_Paint);
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
            this.body_label.Visible = false;
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
            this.email_to_label.Click += new System.EventHandler(this.label4_Click);
            this.email_to_label.Visible = false;
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
            this.password_label.Visible = false;
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
            this.subject_label.Visible = false;
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
            this.email_label.Visible = false;
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
            this.send_email_button.Visible = false;
            // 
            // email_body
            // 
            this.email_body.Location = new System.Drawing.Point(201, 178);
            this.email_body.Multiline = true;
            this.email_body.Name = "email_body";
            this.email_body.Size = new System.Drawing.Size(453, 249);
            this.email_body.TabIndex = 53;
            this.email_body.Visible = false;
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
            this.email_subject.Visible = false;
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
            this.to_email.Visible = false;
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
            this.password.Visible = false;
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
            this.email_box.Visible = false;
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(1299, 15);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(26, 36);
            this.minimize_btn.TabIndex = 45;
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
            this.exit_btn.Location = new System.Drawing.Point(1337, 22);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(27, 25);
            this.exit_btn.TabIndex = 44;
            this.exit_btn.Text = "X";
            this.exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // drag_panel2
            // 
            this.drag_panel2.Location = new System.Drawing.Point(321, 7);
            this.drag_panel2.Name = "drag_panel2";
            this.drag_panel2.Size = new System.Drawing.Size(969, 22);
            this.drag_panel2.TabIndex = 46;
            this.drag_panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.drag_panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.drag_panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1387, 788);
            this.Controls.Add(this.drag_panel2);
            this.Controls.Add(this.dash_container);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).EndInit();
            this.dash_container.ResumeLayout(false);
            this.dash_container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton home_btn;
        private System.Windows.Forms.Button settings_btn;
        private System.Windows.Forms.Button reminders_btn;
        private System.Windows.Forms.Button eval_btn;
        private System.Windows.Forms.Button chat_btn;
        private System.Windows.Forms.Button assignments_btn;
        private System.Windows.Forms.Button calendar_btn;
        private System.Windows.Forms.Panel dash_container;
        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Label exit_btn;
        private System.Windows.Forms.Panel drag_panel;
        private System.Windows.Forms.Panel drag_panel2;
        private System.Windows.Forms.Label logout_lbl;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.TextBox email_subject;
        private System.Windows.Forms.TextBox to_email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email_body;
        private Bunifu.Framework.UI.BunifuFlatButton send_email_button;
        private System.Windows.Forms.Label email_to_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label subject_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label body_label;
    }
}