namespace WarehouseManagement.Presentation
{
    partial class frmDSYCDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSYCDatHang));
            this.btnAll = new System.Windows.Forms.Button();
            this.cbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSYC = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DuyetYC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HuyYC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSYC)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(807, 134);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(67, 177);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Xem Tất Cả";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.Items.AddRange(new object[] {
            "Ngày yêu cầu",
            "Mã nhân viên",
            "Mã hàng hóa",
            "Trạng thái"});
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(212, 31);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(571, 30);
            this.cbLoaiTimKiem.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm theo:";
            // 
            // dgvDSYC
            // 
            this.dgvDSYC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSYC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DuyetYC,
            this.HuyYC});
            this.dgvDSYC.Location = new System.Drawing.Point(77, 134);
            this.dgvDSYC.Name = "dgvDSYC";
            this.dgvDSYC.RowHeadersWidth = 51;
            this.dgvDSYC.RowTemplate.Height = 24;
            this.dgvDSYC.Size = new System.Drawing.Size(706, 286);
            this.dgvDSYC.TabIndex = 11;
            this.dgvDSYC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSYC_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(674, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 38);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(212, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(468, 30);
            this.txtSearch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm:";
            // 
            // DuyetYC
            // 
            this.DuyetYC.HeaderText = "Duyệt Yêu Cầu";
            this.DuyetYC.MinimumWidth = 6;
            this.DuyetYC.Name = "DuyetYC";
            this.DuyetYC.Width = 110;
            // 
            // HuyYC
            // 
            this.HuyYC.HeaderText = "Hủy Yêu Cầu";
            this.HuyYC.MinimumWidth = 6;
            this.HuyYC.Name = "HuyYC";
            this.HuyYC.Width = 110;
            // 
            // frmDSYCDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cbLoaiTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDSYC);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmDSYCDatHang";
            this.Text = "frmDSYCDatHang";
            this.Load += new System.EventHandler(this.frmDSYCDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSYC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbLoaiTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSYC;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DuyetYC;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HuyYC;
    }
}