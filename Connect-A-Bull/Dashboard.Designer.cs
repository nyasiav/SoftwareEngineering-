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
            this.drag_panel = new System.Windows.Forms.Panel();
            this.settings_btn = new System.Windows.Forms.Button();
            this.reminders_btn = new System.Windows.Forms.Button();
            this.eval_btn = new System.Windows.Forms.Button();
            this.chat_btn = new System.Windows.Forms.Button();
            this.assignments_btn = new System.Windows.Forms.Button();
            this.calendar_btn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dash_container = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Label();
            this.drag_panel2 = new System.Windows.Forms.Panel();
            this.home_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(132)))));
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
            this.settings_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.reminders_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.eval_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.chat_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat_btn.ForeColor = System.Drawing.Color.White;
            this.chat_btn.Location = new System.Drawing.Point(4, 378);
            this.chat_btn.Margin = new System.Windows.Forms.Padding(4);
            this.chat_btn.Name = "chat_btn";
            this.chat_btn.Size = new System.Drawing.Size(311, 53);
            this.chat_btn.TabIndex = 3;
            this.chat_btn.Text = "chat";
            this.chat_btn.UseVisualStyleBackColor = true;
            this.chat_btn.Click += new System.EventHandler(this.Chat_btn_Click);
            // 
            // assignments_btn
            // 
            this.assignments_btn.FlatAppearance.BorderSize = 0;
            this.assignments_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignments_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dash_container.Location = new System.Drawing.Point(338, 52);
            this.dash_container.Margin = new System.Windows.Forms.Padding(4);
            this.dash_container.Name = "dash_container";
            this.dash_container.Size = new System.Drawing.Size(1036, 707);
            this.dash_container.TabIndex = 1;
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(1299, 15);
            this.minimize_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(32, 38);
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
            this.exit_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(1337, 22);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(27, 26);
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
            ((System.ComponentModel.ISupportInitialize)(this.home_btn)).EndInit();
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
    }
}