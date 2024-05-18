namespace WarehouseManagement.Presentation
{
    partial class frmHangXuatKho
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtmahang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdshangxuatkho = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nbrSL = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshangxuatkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Crimson;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(854, 169);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 47);
            this.btnThem.TabIndex = 112;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCapNhat.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(1045, 169);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(132, 47);
            this.btnCapNhat.TabIndex = 111;
            this.btnCapNhat.Text = "Sửa";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtmahang
            // 
            this.txtmahang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahang.Location = new System.Drawing.Point(418, 99);
            this.txtmahang.Name = "txtmahang";
            this.txtmahang.Size = new System.Drawing.Size(345, 34);
            this.txtmahang.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 108;
            this.label1.Text = "Mã Hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Plum;
            this.label5.Location = new System.Drawing.Point(452, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(534, 46);
            this.label5.TabIndex = 107;
            this.label5.Text = " Danh Sách Hàng Xuất Kho";
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.MediumOrchid;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntrove.Location = new System.Drawing.Point(1, -2);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(63, 67);
            this.btntrove.TabIndex = 105;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.dgvdshangxuatkho);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(170, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 360);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvdshangxuatkho
            // 
            this.dgvdshangxuatkho.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvdshangxuatkho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdshangxuatkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshangxuatkho.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvdshangxuatkho.Location = new System.Drawing.Point(6, 43);
            this.dgvdshangxuatkho.Name = "dgvdshangxuatkho";
            this.dgvdshangxuatkho.RowHeadersWidth = 51;
            this.dgvdshangxuatkho.RowTemplate.Height = 24;
            this.dgvdshangxuatkho.Size = new System.Drawing.Size(1123, 310);
            this.dgvdshangxuatkho.TabIndex = 17;
            this.dgvdshangxuatkho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdshangxuatkho_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 38);
            this.label2.TabIndex = 113;
            this.label2.Text = "Ngày xuất hàng:";
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Location = new System.Drawing.Point(418, 176);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(345, 30);
            this.dtpNgayXuat.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(810, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 38);
            this.label3.TabIndex = 115;
            this.label3.Text = "Số lượng:";
            // 
            // nbrSL
            // 
            this.nbrSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbrSL.Location = new System.Drawing.Point(966, 100);
            this.nbrSL.Name = "nbrSL";
            this.nbrSL.Size = new System.Drawing.Size(281, 30);
            this.nbrSL.TabIndex = 116;
            // 
            // frmHangXuatKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1332, 637);
            this.Controls.Add(this.nbrSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtmahang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHangXuatKho";
            this.Text = "frmHangXuatKho";
            this.Load += new System.EventHandler(this.frmHangXuatKho_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshangxuatkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbrSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtmahang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdshangxuatkho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbrSL;
    }
}