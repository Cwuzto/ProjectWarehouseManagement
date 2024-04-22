namespace WarehouseManagement.Presentation
{
    partial class frmyeucaudathang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.txtmahanghoa = new System.Windows.Forms.TextBox();
            this.dgvxemyc = new System.Windows.Forms.DataGridView();
            this.btnxem = new System.Windows.Forms.Button();
            this.btngui = new System.Windows.Forms.Button();
            this.ngayyc = new System.Windows.Forms.DateTimePicker();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvxemyc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(463, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Yêu Cầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(463, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(40, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã hàng hóa";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanhanvien.Location = new System.Drawing.Point(228, 62);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(165, 34);
            this.txtmanhanvien.TabIndex = 5;
            // 
            // txtmahanghoa
            // 
            this.txtmahanghoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahanghoa.Location = new System.Drawing.Point(228, 107);
            this.txtmahanghoa.Name = "txtmahanghoa";
            this.txtmahanghoa.Size = new System.Drawing.Size(165, 34);
            this.txtmahanghoa.TabIndex = 8;
            // 
            // dgvxemyc
            // 
            this.dgvxemyc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvxemyc.Location = new System.Drawing.Point(45, 239);
            this.dgvxemyc.Name = "dgvxemyc";
            this.dgvxemyc.RowHeadersWidth = 51;
            this.dgvxemyc.RowTemplate.Height = 24;
            this.dgvxemyc.Size = new System.Drawing.Size(1026, 272);
            this.dgvxemyc.TabIndex = 9;
            // 
            // btnxem
            // 
            this.btnxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(45, 182);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(283, 51);
            this.btnxem.TabIndex = 10;
            this.btnxem.Text = "xem danh sách yêu cầu";
            this.btnxem.UseVisualStyleBackColor = false;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btngui
            // 
            this.btngui.BackColor = System.Drawing.Color.Blue;
            this.btngui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngui.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btngui.Location = new System.Drawing.Point(924, 151);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(166, 52);
            this.btngui.TabIndex = 11;
            this.btngui.Text = "Gửi yêu cầu";
            this.btngui.UseVisualStyleBackColor = false;
            this.btngui.Click += new System.EventHandler(this.btngui_Click_1);
            // 
            // ngayyc
            // 
            this.ngayyc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayyc.Location = new System.Drawing.Point(669, 53);
            this.ngayyc.Name = "ngayyc";
            this.ngayyc.Size = new System.Drawing.Size(421, 34);
            this.ngayyc.TabIndex = 12;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrangthai.Location = new System.Drawing.Point(669, 95);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(421, 34);
            this.txttrangthai.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(-6, -4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 69);
            this.label7.TabIndex = 40;
            this.label7.Text = "↺";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // frmyeucaudathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1211, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.ngayyc);
            this.Controls.Add(this.btngui);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.dgvxemyc);
            this.Controls.Add(this.txtmahanghoa);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmyeucaudathang";
            this.Text = "frmyeucaudathang";
            this.Load += new System.EventHandler(this.frmyeucaudathang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvxemyc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.TextBox txtmahanghoa;
        private System.Windows.Forms.DataGridView dgvxemyc;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.DateTimePicker ngayyc;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}