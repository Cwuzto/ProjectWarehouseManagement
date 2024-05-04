namespace WarehouseManagement.Presentation
{
    partial class frmQLHang
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
            this.dgvdshang = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnxemallhh = new System.Windows.Forms.Button();
            this.ngaycn = new System.Windows.Forms.DateTimePicker();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.txttenhang = new System.Windows.Forms.TextBox();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdshang
            // 
            this.dgvdshang.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvdshang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdshang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshang.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvdshang.Location = new System.Drawing.Point(18, 36);
            this.dgvdshang.Name = "dgvdshang";
            this.dgvdshang.RowHeadersWidth = 51;
            this.dgvdshang.RowTemplate.Height = 24;
            this.dgvdshang.Size = new System.Drawing.Size(907, 310);
            this.dgvdshang.TabIndex = 17;
            this.dgvdshang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdshang_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightPink;
            this.label5.Location = new System.Drawing.Point(637, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 56);
            this.label5.TabIndex = 75;
            this.label5.Text = "Hàng Hóa";
            // 
            // btnxemallhh
            // 
            this.btnxemallhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnxemallhh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxemallhh.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemallhh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxemallhh.Location = new System.Drawing.Point(16, 501);
            this.btnxemallhh.Name = "btnxemallhh";
            this.btnxemallhh.Size = new System.Drawing.Size(233, 47);
            this.btnxemallhh.TabIndex = 73;
            this.btnxemallhh.Text = "Xem Danh Sách ";
            this.btnxemallhh.UseVisualStyleBackColor = false;
            this.btnxemallhh.Click += new System.EventHandler(this.btnxemallhh_Click);
            // 
            // ngaycn
            // 
            this.ngaycn.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaycn.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.ngaycn.CalendarTrailingForeColor = System.Drawing.Color.Silver;
            this.ngaycn.Location = new System.Drawing.Point(1243, 406);
            this.ngaycn.Name = "ngaycn";
            this.ngaycn.Size = new System.Drawing.Size(269, 22);
            this.ngaycn.TabIndex = 71;
            // 
            // txtmaloai
            // 
            this.txtmaloai.BackColor = System.Drawing.Color.Gray;
            this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaloai.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmaloai.Location = new System.Drawing.Point(1242, 350);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(270, 34);
            this.txtmaloai.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(1003, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 38);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mã Hàng Hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(1003, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 38);
            this.label3.TabIndex = 68;
            this.label3.Text = "Ngày Cập Nhật:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(1005, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 38);
            this.label2.TabIndex = 67;
            this.label2.Text = "Mã loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(1003, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tên Hàng Hóa:";
            // 
            // txtmahh
            // 
            this.txtmahh.BackColor = System.Drawing.Color.Gray;
            this.txtmahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahh.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmahh.Location = new System.Drawing.Point(1242, 152);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(270, 34);
            this.txtmahh.TabIndex = 65;
            // 
            // txttenhang
            // 
            this.txttenhang.BackColor = System.Drawing.Color.Gray;
            this.txttenhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenhang.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txttenhang.Location = new System.Drawing.Point(1241, 204);
            this.txttenhang.Name = "txttenhang";
            this.txttenhang.Size = new System.Drawing.Size(270, 34);
            this.txttenhang.TabIndex = 64;
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.LightCoral;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntrove.Location = new System.Drawing.Point(0, 0);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(63, 67);
            this.btntrove.TabIndex = 63;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.dgvdshang);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(10, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 360);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(1004, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 38);
            this.label6.TabIndex = 79;
            this.label6.Text = "Mô Tả:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(1003, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 38);
            this.label7.TabIndex = 78;
            this.label7.Text = "Số Lượng:";
            // 
            // txtmota
            // 
            this.txtmota.BackColor = System.Drawing.Color.Gray;
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtmota.Location = new System.Drawing.Point(1242, 252);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(270, 34);
            this.txtmota.TabIndex = 77;
            // 
            // txtsoluong
            // 
            this.txtsoluong.BackColor = System.Drawing.Color.Gray;
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtsoluong.Location = new System.Drawing.Point(1241, 299);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(270, 34);
            this.txtsoluong.TabIndex = 76;
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.White;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncapnhat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncapnhat.Image = global::WarehouseManagement.Presentation.Properties.Resources.cap_nhat3;
            this.btncapnhat.Location = new System.Drawing.Point(1350, 447);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(80, 67);
            this.btncapnhat.TabIndex = 80;
            this.btncapnhat.UseVisualStyleBackColor = false;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxoa.Image = global::WarehouseManagement.Presentation.Properties.Resources.xóa2;
            this.btnxoa.Location = new System.Drawing.Point(1035, 447);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 67);
            this.btnxoa.TabIndex = 74;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.White;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnthem.Image = global::WarehouseManagement.Presentation.Properties.Resources.tải_xuống__2_up;
            this.btnthem.Location = new System.Drawing.Point(1205, 447);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(80, 67);
            this.btnthem.TabIndex = 72;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // frmQLHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1749, 708);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnxemallhh);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.ngaycn);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmahh);
            this.Controls.Add(this.txttenhang);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLHang";
            this.Text = "frmQLHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdshang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnxemallhh;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker ngaycn;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.TextBox txttenhang;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button btncapnhat;
    }
}