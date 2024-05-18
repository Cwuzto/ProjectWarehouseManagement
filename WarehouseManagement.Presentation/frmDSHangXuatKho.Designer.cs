namespace WarehouseManagement.Presentation
{
    partial class frmDSHangXuatKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSHangXuatKho));
            this.btnAll = new System.Windows.Forms.Button();
            this.cbLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHgXuatKho = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHgXuatKho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.Color.MistyRose;
            this.btnAll.Location = new System.Drawing.Point(715, 520);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(181, 55);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "Xem Tất Cả";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // cbLoaiTimKiem
            // 
            this.cbLoaiTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiTimKiem.FormattingEnabled = true;
            this.cbLoaiTimKiem.Items.AddRange(new object[] {
            "Ngày xuất",
            "Mã nhân viên",
            "Mã hàng hóa"});
            this.cbLoaiTimKiem.Location = new System.Drawing.Point(396, 122);
            this.cbLoaiTimKiem.Name = "cbLoaiTimKiem";
            this.cbLoaiTimKiem.Size = new System.Drawing.Size(472, 30);
            this.cbLoaiTimKiem.TabIndex = 13;
            this.cbLoaiTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbLoaiTimKiem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(236, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm theo:";
            // 
            // dgvHgXuatKho
            // 
            this.dgvHgXuatKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHgXuatKho.Location = new System.Drawing.Point(202, 228);
            this.dgvHgXuatKho.Name = "dgvHgXuatKho";
            this.dgvHgXuatKho.RowHeadersWidth = 51;
            this.dgvHgXuatKho.RowTemplate.Height = 24;
            this.dgvHgXuatKho.Size = new System.Drawing.Size(694, 286);
            this.dgvHgXuatKho.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(396, 169);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 30);
            this.txtSearch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(236, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm:";
            // 
            // dtpSearch
            // 
            this.dtpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSearch.Location = new System.Drawing.Point(396, 169);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(345, 30);
            this.dtpSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(747, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(121, 38);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmDSHangXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1200, 619);
            this.Controls.Add(this.dtpSearch);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.cbLoaiTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHgXuatKho);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "frmDSHangXuatKho";
            this.Text = "Danh sách hàng xuất kho";
            this.Load += new System.EventHandler(this.frmDSHangXuatKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHgXuatKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.ComboBox cbLoaiTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHgXuatKho;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSearch;
    }
}