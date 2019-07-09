namespace Connect_A_Bull
{
    partial class ViewUsers
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.delete_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refresh_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(74, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(636, 612);
            this.listBox1.TabIndex = 0;
            // 
            // delete_button
            // 
            this.delete_button.Activecolor = System.Drawing.Color.DarkCyan;
            this.delete_button.BackColor = System.Drawing.Color.LimeGreen;
            this.delete_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_button.BorderRadius = 5;
            this.delete_button.ButtonText = "Delete";
            this.delete_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_button.DisabledColor = System.Drawing.Color.Gray;
            this.delete_button.Iconcolor = System.Drawing.Color.Transparent;
            this.delete_button.Iconimage = null;
            this.delete_button.Iconimage_right = null;
            this.delete_button.Iconimage_right_Selected = null;
            this.delete_button.Iconimage_Selected = null;
            this.delete_button.IconMarginLeft = 0;
            this.delete_button.IconMarginRight = 0;
            this.delete_button.IconRightVisible = true;
            this.delete_button.IconRightZoom = 0D;
            this.delete_button.IconVisible = true;
            this.delete_button.IconZoom = 90D;
            this.delete_button.IsTab = false;
            this.delete_button.Location = new System.Drawing.Point(751, 35);
            this.delete_button.Margin = new System.Windows.Forms.Padding(5);
            this.delete_button.Name = "delete_button";
            this.delete_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.delete_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.delete_button.OnHoverTextColor = System.Drawing.Color.White;
            this.delete_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete_button.selected = false;
            this.delete_button.Size = new System.Drawing.Size(223, 32);
            this.delete_button.TabIndex = 62;
            this.delete_button.Text = "Delete";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_button.Textcolor = System.Drawing.Color.White;
            this.delete_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // refresh_button
            // 
            this.refresh_button.Activecolor = System.Drawing.Color.DarkCyan;
            this.refresh_button.BackColor = System.Drawing.Color.LimeGreen;
            this.refresh_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh_button.BorderRadius = 5;
            this.refresh_button.ButtonText = "Refresh";
            this.refresh_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_button.DisabledColor = System.Drawing.Color.Gray;
            this.refresh_button.Iconcolor = System.Drawing.Color.Transparent;
            this.refresh_button.Iconimage = null;
            this.refresh_button.Iconimage_right = null;
            this.refresh_button.Iconimage_right_Selected = null;
            this.refresh_button.Iconimage_Selected = null;
            this.refresh_button.IconMarginLeft = 0;
            this.refresh_button.IconMarginRight = 0;
            this.refresh_button.IconRightVisible = true;
            this.refresh_button.IconRightZoom = 0D;
            this.refresh_button.IconVisible = true;
            this.refresh_button.IconZoom = 90D;
            this.refresh_button.IsTab = false;
            this.refresh_button.Location = new System.Drawing.Point(751, 97);
            this.refresh_button.Margin = new System.Windows.Forms.Padding(5);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Normalcolor = System.Drawing.Color.DarkCyan;
            this.refresh_button.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.refresh_button.OnHoverTextColor = System.Drawing.Color.White;
            this.refresh_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.refresh_button.selected = false;
            this.refresh_button.Size = new System.Drawing.Size(223, 32);
            this.refresh_button.TabIndex = 63;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refresh_button.Textcolor = System.Drawing.Color.White;
            this.refresh_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_button.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.listBox1);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(1073, 788);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuFlatButton delete_button;
        private Bunifu.Framework.UI.BunifuFlatButton refresh_button;
    }
}
