namespace WarehouseManagement.Presentation
{
    partial class frmQuanLy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemQLLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDonDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchYêuCầuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemYCNHG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemYCNhapHg = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuitemHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemQLNV,
            this.menuitemQLLNV});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(292, 39);
            this.toolStripMenuItem1.Text = "Phân Quyền Hệ Thống";
            // 
            // menuitemQLNV
            // 
            this.menuitemQLNV.Name = "menuitemQLNV";
            this.menuitemQLNV.Size = new System.Drawing.Size(364, 40);
            this.menuitemQLNV.Text = "Quản lý nhân viên";
            this.menuitemQLNV.Click += new System.EventHandler(this.menuitemQLNV_Click);
            // 
            // menuitemQLLNV
            // 
            this.menuitemQLLNV.Name = "menuitemQLLNV";
            this.menuitemQLLNV.Size = new System.Drawing.Size(364, 40);
            this.menuitemQLLNV.Text = "Quản lý loại nhân viên";
            this.menuitemQLLNV.Click += new System.EventHandler(this.menuitemQLLNV_Click);
            // 
            // menuitemHang
            // 
            this.menuitemHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDonDatHang,
            this.danhSáchYêuCầuToolStripMenuItem,
            this.xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem});
            this.menuitemHang.Name = "menuitemHang";
            this.menuitemHang.Size = new System.Drawing.Size(183, 39);
            this.menuitemHang.Text = "Quản lý hàng";
            // 
            // menuitemDonDatHang
            // 
            this.menuitemDonDatHang.Name = "menuitemDonDatHang";
            this.menuitemDonDatHang.Size = new System.Drawing.Size(560, 40);
            this.menuitemDonDatHang.Text = "Đơn đặt hàng";
            this.menuitemDonDatHang.Click += new System.EventHandler(this.menuitemDonDatHang_Click);
            // 
            // danhSáchYêuCầuToolStripMenuItem
            // 
            this.danhSáchYêuCầuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemYCNHG,
            this.menuitemYCNhapHg});
            this.danhSáchYêuCầuToolStripMenuItem.Name = "danhSáchYêuCầuToolStripMenuItem";
            this.danhSáchYêuCầuToolStripMenuItem.Size = new System.Drawing.Size(560, 40);
            this.danhSáchYêuCầuToolStripMenuItem.Text = "Danh sách yêu cầu";
            // 
            // menuitemYCNHG
            // 
            this.menuitemYCNHG.Name = "menuitemYCNHG";
            this.menuitemYCNHG.Size = new System.Drawing.Size(324, 40);
            this.menuitemYCNHG.Text = "Yêu cầu nhập hàng";
            this.menuitemYCNHG.Click += new System.EventHandler(this.menuitemYCNHG_Click);
            // 
            // menuitemYCNhapHg
            // 
            this.menuitemYCNhapHg.Name = "menuitemYCNhapHg";
            this.menuitemYCNhapHg.Size = new System.Drawing.Size(324, 40);
            this.menuitemYCNhapHg.Text = "Yêu cầu đặt hàng";
            this.menuitemYCNhapHg.Click += new System.EventHandler(this.menuitemYCNhapHg_Click);
            // 
            // xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem
            // 
            this.xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem.Name = "xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem";
            this.xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem.Size = new System.Drawing.Size(560, 40);
            this.xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem.Text = "Xem thống kê nhập/xuất các mặt hàng";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangXuat.Location = new System.Drawing.Point(857, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(215, 41);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQuanLy";
            this.Text = "frmQuanLy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuitemQLNV;
        private System.Windows.Forms.ToolStripMenuItem menuitemQLLNV;
        private System.Windows.Forms.ToolStripMenuItem menuitemHang;
        private System.Windows.Forms.ToolStripMenuItem menuitemDonDatHang;
        private System.Windows.Forms.ToolStripMenuItem danhSáchYêuCầuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemYCNHG;
        private System.Windows.Forms.ToolStripMenuItem menuitemYCNhapHg;
        private System.Windows.Forms.ToolStripMenuItem xemThốngKêNhậpxuấtCácMặtHàngToolStripMenuItem;
        private System.Windows.Forms.Button btnDangXuat;
    }
}