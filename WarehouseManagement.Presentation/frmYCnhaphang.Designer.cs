namespace WarehouseManagement.Presentation
{
    partial class frmYCnhaphang
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
            this.dgvdsyc = new System.Windows.Forms.DataGridView();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.ngayyc = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnxemdsyc = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsyc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvdsyc
            // 
            this.dgvdsyc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsyc.Location = new System.Drawing.Point(21, 37);
            this.dgvdsyc.Name = "dgvdsyc";
            this.dgvdsyc.RowHeadersWidth = 51;
            this.dgvdsyc.RowTemplate.Height = 24;
            this.dgvdsyc.Size = new System.Drawing.Size(907, 310);
            this.dgvdsyc.TabIndex = 17;
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.LightCoral;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btntrove.Location = new System.Drawing.Point(2, 6);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(63, 67);
            this.btntrove.TabIndex = 46;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.dgvdsyc);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(952, 360);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // txtmanv
            // 
            this.txtmanv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Location = new System.Drawing.Point(1200, 162);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(282, 30);
            this.txtmanv.TabIndex = 47;
            // 
            // txtmahh
            // 
            this.txtmahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahh.Location = new System.Drawing.Point(1200, 208);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(282, 30);
            this.txtmahh.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label1.Location = new System.Drawing.Point(981, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(981, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 38);
            this.label2.TabIndex = 50;
            this.label2.Text = "Trạng Thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(981, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 38);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ngày Yêu Cầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LemonChiffon;
            this.label4.Location = new System.Drawing.Point(981, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 38);
            this.label4.TabIndex = 52;
            this.label4.Text = "Mã Hàng Hóa:";
            // 
            // txttrangthai
            // 
            this.txttrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrangthai.Location = new System.Drawing.Point(1200, 319);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(282, 30);
            this.txttrangthai.TabIndex = 54;
            // 
            // ngayyc
            // 
            this.ngayyc.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayyc.Location = new System.Drawing.Point(1201, 270);
            this.ngayyc.Name = "ngayyc";
            this.ngayyc.Size = new System.Drawing.Size(281, 22);
            this.ngayyc.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(1016, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 47);
            this.button1.TabIndex = 57;
            this.button1.Text = "Gửi Yêu Cầu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnxemdsyc
            // 
            this.btnxemdsyc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnxemdsyc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxemdsyc.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemdsyc.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnxemdsyc.Location = new System.Drawing.Point(18, 507);
            this.btnxemdsyc.Name = "btnxemdsyc";
            this.btnxemdsyc.Size = new System.Drawing.Size(233, 47);
            this.btnxemdsyc.TabIndex = 58;
            this.btnxemdsyc.Text = "Xem Danh Sách ";
            this.btnxemdsyc.UseVisualStyleBackColor = false;
            this.btnxemdsyc.Click += new System.EventHandler(this.btnxemdsyc_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.BackColor = System.Drawing.Color.Crimson;
            this.btnhuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnhuy.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnhuy.Location = new System.Drawing.Point(1287, 389);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(203, 47);
            this.btnhuy.TabIndex = 59;
            this.btnhuy.Text = "Hủy Yêu Cầu";
            this.btnhuy.UseVisualStyleBackColor = false;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Pink;
            this.label5.Location = new System.Drawing.Point(594, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(448, 51);
            this.label5.TabIndex = 61;
            this.label5.Text = "Yêu Cầu Nhập Hàng";
            // 
            // frmYCnhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1494, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxemdsyc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ngayyc);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmahh);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmYCnhaphang";
            this.Text = "frmYCnhaphang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsyc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdsyc;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.DateTimePicker ngayyc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnxemdsyc;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label5;
    }
}