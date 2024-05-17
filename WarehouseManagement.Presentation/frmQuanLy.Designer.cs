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
            this.menuitemYCNhapHG = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemYCDatHg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemXemThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemXemThongKeNhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemXemThongKeXuatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHgXuatKho = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDSHangTrongKho = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(1073, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemQLNV,
            this.menuitemQLLNV});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(326, 35);
            this.toolStripMenuItem1.Text = "Phân Quyền Hệ Thống";
            // 
            // menuitemQLNV
            // 
            this.menuitemQLNV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemQLNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemQLNV.Name = "menuitemQLNV";
            this.menuitemQLNV.Size = new System.Drawing.Size(413, 36);
            this.menuitemQLNV.Text = "Quản lý nhân viên";
            this.menuitemQLNV.Click += new System.EventHandler(this.menuitemQLNV_Click);
            // 
            // menuitemQLLNV
            // 
            this.menuitemQLLNV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemQLLNV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemQLLNV.Name = "menuitemQLLNV";
            this.menuitemQLLNV.Size = new System.Drawing.Size(413, 36);
            this.menuitemQLLNV.Text = "Quản lý loại nhân viên";
            this.menuitemQLLNV.Click += new System.EventHandler(this.menuitemQLLNV_Click);
            // 
            // menuitemHang
            // 
            this.menuitemHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDonDatHang,
            this.danhSáchYêuCầuToolStripMenuItem,
            this.menuitemXemThongKe,
            this.menuitemHgXuatKho,
            this.menuitemDSHangTrongKho});
            this.menuitemHang.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuitemHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemHang.Name = "menuitemHang";
            this.menuitemHang.Size = new System.Drawing.Size(213, 35);
            this.menuitemHang.Text = "Quản lý hàng";
            // 
            // menuitemDonDatHang
            // 
            this.menuitemDonDatHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemDonDatHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemDonDatHang.Name = "menuitemDonDatHang";
            this.menuitemDonDatHang.Size = new System.Drawing.Size(637, 36);
            this.menuitemDonDatHang.Text = "Đơn đặt hàng";
            this.menuitemDonDatHang.Click += new System.EventHandler(this.menuitemDonDatHang_Click);
            // 
            // danhSáchYêuCầuToolStripMenuItem
            // 
            this.danhSáchYêuCầuToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.danhSáchYêuCầuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemYCNhapHG,
            this.menuitemYCDatHg});
            this.danhSáchYêuCầuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.danhSáchYêuCầuToolStripMenuItem.Name = "danhSáchYêuCầuToolStripMenuItem";
            this.danhSáchYêuCầuToolStripMenuItem.Size = new System.Drawing.Size(637, 36);
            this.danhSáchYêuCầuToolStripMenuItem.Text = "Danh sách yêu cầu";
            // 
            // menuitemYCNhapHG
            // 
            this.menuitemYCNhapHG.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuitemYCNhapHG.Name = "menuitemYCNhapHG";
            this.menuitemYCNhapHG.Size = new System.Drawing.Size(363, 36);
            this.menuitemYCNhapHG.Text = "Yêu cầu nhập hàng";
            this.menuitemYCNhapHG.Click += new System.EventHandler(this.menuitemYCNhapHG_Click);
            // 
            // menuitemYCDatHg
            // 
            this.menuitemYCDatHg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuitemYCDatHg.Name = "menuitemYCDatHg";
            this.menuitemYCDatHg.Size = new System.Drawing.Size(363, 36);
            this.menuitemYCDatHg.Text = "Yêu cầu đặt hàng";
            this.menuitemYCDatHg.Click += new System.EventHandler(this.menuitemYCDatHg_Click);
            // 
            // menuitemXemThongKe
            // 
            this.menuitemXemThongKe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemXemThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemXemThongKeNhapHang,
            this.menuitemXemThongKeXuatHang});
            this.menuitemXemThongKe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemXemThongKe.Name = "menuitemXemThongKe";
            this.menuitemXemThongKe.Size = new System.Drawing.Size(637, 36);
            this.menuitemXemThongKe.Text = "Xem thống kê nhập/xuất các mặt hàng";
            // 
            // menuitemXemThongKeNhapHang
            // 
            this.menuitemXemThongKeNhapHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuitemXemThongKeNhapHang.Name = "menuitemXemThongKeNhapHang";
            this.menuitemXemThongKeNhapHang.Size = new System.Drawing.Size(248, 36);
            this.menuitemXemThongKeNhapHang.Text = "Nhập hàng";
            this.menuitemXemThongKeNhapHang.Click += new System.EventHandler(this.menuitemXemThongKeNhapHang_Click);
            // 
            // menuitemXemThongKeXuatHang
            // 
            this.menuitemXemThongKeXuatHang.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuitemXemThongKeXuatHang.Name = "menuitemXemThongKeXuatHang";
            this.menuitemXemThongKeXuatHang.Size = new System.Drawing.Size(248, 36);
            this.menuitemXemThongKeXuatHang.Text = "Xuất hàng";
            this.menuitemXemThongKeXuatHang.Click += new System.EventHandler(this.menuitemXemThongKeXuatHang_Click);
            // 
            // menuitemHgXuatKho
            // 
            this.menuitemHgXuatKho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemHgXuatKho.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemHgXuatKho.Name = "menuitemHgXuatKho";
            this.menuitemHgXuatKho.Size = new System.Drawing.Size(637, 36);
            this.menuitemHgXuatKho.Text = "Danh sách hàng xuất kho";
            this.menuitemHgXuatKho.Click += new System.EventHandler(this.menuitemHgXuatKho_Click);
            // 
            // menuitemDSHangTrongKho
            // 
            this.menuitemDSHangTrongKho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuitemDSHangTrongKho.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menuitemDSHangTrongKho.Name = "menuitemDSHangTrongKho";
            this.menuitemDSHangTrongKho.Size = new System.Drawing.Size(637, 36);
            this.menuitemDSHangTrongKho.Text = "Danh sách hàng trong kho";
            this.menuitemDSHangTrongKho.Click += new System.EventHandler(this.menuitemDSHangTrongKho_Click);
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
            this.Text = "Quản lý";
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
        private System.Windows.Forms.ToolStripMenuItem menuitemYCNhapHG;
        private System.Windows.Forms.ToolStripMenuItem menuitemYCDatHg;
        private System.Windows.Forms.ToolStripMenuItem menuitemXemThongKe;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.ToolStripMenuItem menuitemHgXuatKho;
        private System.Windows.Forms.ToolStripMenuItem menuitemDSHangTrongKho;
        private System.Windows.Forms.ToolStripMenuItem menuitemXemThongKeNhapHang;
        private System.Windows.Forms.ToolStripMenuItem menuitemXemThongKeXuatHang;
    }
}