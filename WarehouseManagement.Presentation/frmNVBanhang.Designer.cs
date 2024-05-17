namespace WarehouseManagement.Presentation
{
    partial class frmNVBanhang
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
            this.nhânViênBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yêuCầuNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nhânViênBánHàngToolStripMenuItem
            // 
            this.nhânViênBánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemHàngHóaToolStripMenuItem,
            this.yêuCầuNhậpHàngToolStripMenuItem});
            this.nhânViênBánHàngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.nhânViênBánHàngToolStripMenuItem.Name = "nhânViênBánHàngToolStripMenuItem";
            this.nhânViênBánHàngToolStripMenuItem.Size = new System.Drawing.Size(339, 39);
            this.nhânViênBánHàngToolStripMenuItem.Text = "Nhân Viên Bán Hàng";
            // 
            // xemHàngHóaToolStripMenuItem
            // 
            this.xemHàngHóaToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.xemHàngHóaToolStripMenuItem.ForeColor = System.Drawing.Color.MediumPurple;
            this.xemHàngHóaToolStripMenuItem.Name = "xemHàngHóaToolStripMenuItem";
            this.xemHàngHóaToolStripMenuItem.Size = new System.Drawing.Size(400, 40);
            this.xemHàngHóaToolStripMenuItem.Text = "Xem Hàng Hóa";
            this.xemHàngHóaToolStripMenuItem.Click += new System.EventHandler(this.xemHàngHóaToolStripMenuItem_Click_1);
            // 
            // yêuCầuNhậpHàngToolStripMenuItem
            // 
            this.yêuCầuNhậpHàngToolStripMenuItem.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.yêuCầuNhậpHàngToolStripMenuItem.ForeColor = System.Drawing.Color.MediumPurple;
            this.yêuCầuNhậpHàngToolStripMenuItem.Name = "yêuCầuNhậpHàngToolStripMenuItem";
            this.yêuCầuNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(400, 40);
            this.yêuCầuNhậpHàngToolStripMenuItem.Text = "Yêu Cầu Nhập Hàng";
            this.yêuCầuNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.yêuCầuNhậpHàngToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênBánHàngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(1709, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNVBanhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1924, 935);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNVBanhang";
            this.Text = "Nhân viên bán hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem nhânViênBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yêuCầuNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}