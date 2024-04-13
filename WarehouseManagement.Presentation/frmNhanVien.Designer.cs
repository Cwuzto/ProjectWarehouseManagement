namespace WarehouseManagement.Presentation
{
    partial class frmNhanVien
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
            this.cbLoaiNV = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkGT = new System.Windows.Forms.CheckBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.txtMaNV_temp = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.qLKHOQUANCFDataSet = new WarehouseManagement.Presentation.QLKHOQUANCFDataSet();
            this.loaiNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiNVTableAdapter = new WarehouseManagement.Presentation.QLKHOQUANCFDataSetTableAdapters.LoaiNVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHOQUANCFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiNVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLoaiNV
            // 
            this.cbLoaiNV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbLoaiNV.DataSource = this.loaiNVBindingSource;
            this.cbLoaiNV.DisplayMember = "TenLoaiNV";
            this.cbLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiNV.FormattingEnabled = true;
            this.cbLoaiNV.Location = new System.Drawing.Point(799, 100);
            this.cbLoaiNV.Name = "cbLoaiNV";
            this.cbLoaiNV.Size = new System.Drawing.Size(274, 28);
            this.cbLoaiNV.TabIndex = 35;
            this.cbLoaiNV.ValueMember = "TenLoaiNV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(648, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "Mã Nhân Viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(648, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 22);
            this.label8.TabIndex = 32;
            this.label8.Text = "Loại Nhân Viên:";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(799, 152);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(274, 27);
            this.txtUser.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(648, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "UserName:";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(799, 210);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(274, 27);
            this.txtPass.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(302, 213);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(306, 27);
            this.txtDiaChi.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(95, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(473, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giới Tính:";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(302, 153);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(152, 27);
            this.txtSDT.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(95, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(302, 104);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(306, 27);
            this.txtTen.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(95, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên (Lót) Nhân Viên:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(270, 320);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 53);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(827, 320);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 53);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(545, 320);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 53);
            this.btnSua.TabIndex = 38;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Location = new System.Drawing.Point(99, 393);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.Size = new System.Drawing.Size(974, 188);
            this.dgvDSNV.TabIndex = 39;
            this.dgvDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellClick);
            // 
            // txtHo
            // 
            this.txtHo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.Location = new System.Drawing.Point(302, 60);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(306, 27);
            this.txtHo.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(95, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 22);
            this.label10.TabIndex = 40;
            this.label10.Text = "Họ Nhân Viên:";
            // 
            // checkGT
            // 
            this.checkGT.AutoSize = true;
            this.checkGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGT.Location = new System.Drawing.Point(590, 158);
            this.checkGT.Name = "checkGT";
            this.checkGT.Size = new System.Drawing.Size(18, 17);
            this.checkGT.TabIndex = 42;
            this.checkGT.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(799, 53);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(274, 27);
            this.txtMaNV.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(558, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 44;
            this.label2.Text = "Sửa:";
            // 
            // txtOldValue
            // 
            this.txtOldValue.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtOldValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldValue.Location = new System.Drawing.Point(624, 262);
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.Size = new System.Drawing.Size(152, 27);
            this.txtOldValue.TabIndex = 45;
            // 
            // txtMaNV_temp
            // 
            this.txtMaNV_temp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMaNV_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV_temp.Location = new System.Drawing.Point(372, 262);
            this.txtMaNV_temp.Name = "txtMaNV_temp";
            this.txtMaNV_temp.Size = new System.Drawing.Size(168, 27);
            this.txtMaNV_temp.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(95, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 22);
            this.label11.TabIndex = 46;
            this.label11.Text = "Mã Nhân Viên Muốn Sửa/Xóa:";
            // 
            // txtNewValue
            // 
            this.txtNewValue.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtNewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewValue.Location = new System.Drawing.Point(921, 257);
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.Size = new System.Drawing.Size(152, 27);
            this.txtNewValue.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(823, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 22);
            this.label12.TabIndex = 48;
            this.label12.Text = "Thành:";
            // 
            // qLKHOQUANCFDataSet
            // 
            this.qLKHOQUANCFDataSet.DataSetName = "QLKHOQUANCFDataSet";
            this.qLKHOQUANCFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiNVBindingSource
            // 
            this.loaiNVBindingSource.DataMember = "LoaiNV";
            this.loaiNVBindingSource.DataSource = this.qLKHOQUANCFDataSet;
            // 
            // loaiNVTableAdapter
            // 
            this.loaiNVTableAdapter.ClearBeforeFill = true;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1258, 578);
            this.Controls.Add(this.txtNewValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaNV_temp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtOldValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.checkGT);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbLoaiNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHOQUANCFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiNVBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLoaiNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkGT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOldValue;
        private System.Windows.Forms.TextBox txtMaNV_temp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.Label label12;
        private QLKHOQUANCFDataSet qLKHOQUANCFDataSet;
        private System.Windows.Forms.BindingSource loaiNVBindingSource;
        private QLKHOQUANCFDataSetTableAdapters.LoaiNVTableAdapter loaiNVTableAdapter;
    }
}