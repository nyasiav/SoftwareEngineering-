namespace Connect_A_Bull
{
    partial class Settings
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
            this.setting_title_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.token_box = new System.Windows.Forms.TextBox();
            this.add_token_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // setting_title_lbl
            // 
            this.setting_title_lbl.AutoSize = true;
            this.setting_title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setting_title_lbl.Location = new System.Drawing.Point(45, 40);
            this.setting_title_lbl.Name = "setting_title_lbl";
            this.setting_title_lbl.Size = new System.Drawing.Size(166, 44);
            this.setting_title_lbl.TabIndex = 1;
            this.setting_title_lbl.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(392, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Canvas API Token";
            // 
            // token_box
            // 
            this.token_box.BackColor = System.Drawing.Color.Gainsboro;
            this.token_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.token_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token_box.Location = new System.Drawing.Point(146, 383);
            this.token_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.token_box.Name = "token_box";
            this.token_box.Size = new System.Drawing.Size(799, 23);
            this.token_box.TabIndex = 11;
            // 
            // add_token_button
            // 
            this.add_token_button.Activecolor = System.Drawing.Color.DarkCyan;
            this.add_token_button.BackColor = System.Drawing.Color.LimeGreen;
            this.add_token_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.add_token_button.BorderRadius = 5;
            this.add_token_button.ButtonText = "Add Token";
            this.add_token_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_token_button.DisabledColor = System.Drawing.Color.Gray;
            this.add_token_button.Iconcolor = System.Drawing.Color.Transparent;
            this.add_token_button.Iconimage = null;
            this.add_token_button.Iconimage_right = null;
            this.add_token_button.Iconimage_right_Selected = null;
            this.add_token_button.Iconimage_Selected = null;
            this.add_token_button.IconMarginLeft = 0;
            this.add_token_button.IconMarginRight = 0;
            this.add_token_button.IconRightVisible = true;
            this.add_token_button.IconRightZoom = 0D;
            this.add_token_button.IconVisible = true;
            this.add_token_button.IconZoom = 90D;
            this.add_token_button.IsTab = false;
            this.add_token_button.Location = new System.Drawing.Point(422, 441);
            this.add_token_button.Margin = new System.Windows.Forms.Padding(5);
            this.add_token_button.Name = "add_token_button";
            this.add_token_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.add_token_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.add_token_button.OnHoverTextColor = System.Drawing.Color.White;
            this.add_token_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add_token_button.selected = false;
            this.add_token_button.Size = new System.Drawing.Size(223, 32);
            this.add_token_button.TabIndex = 63;
            this.add_token_button.Text = "Add Token";
            this.add_token_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add_token_button.Textcolor = System.Drawing.Color.White;
            this.add_token_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_token_button.Click += new System.EventHandler(this.add_token_button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add_token_button);
            this.Controls.Add(this.token_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setting_title_lbl);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1073, 788);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label setting_title_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox token_box;
        private Bunifu.Framework.UI.BunifuFlatButton add_token_button;
    }
}
