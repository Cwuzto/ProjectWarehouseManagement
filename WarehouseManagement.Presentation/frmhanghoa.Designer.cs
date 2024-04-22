namespace WarehouseManagement.Presentation
{
    partial class frmHangHoa
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.btnalhh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmahh = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.btnsuahh = new System.Windows.Forms.Button();
            this.btnxoahh = new System.Windows.Forms.Button();
            this.btnthemhh = new System.Windows.Forms.Button();
            this.dtpngaycn = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(773, 38);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(217, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = " BảngHàng Hóa";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(683, 77);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 16);
            this.labelControl2.TabIndex = 1;
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Location = new System.Drawing.Point(50, 157);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.RowHeadersWidth = 51;
            this.dgvhanghoa.RowTemplate.Height = 24;
            this.dgvhanghoa.Size = new System.Drawing.Size(1025, 280);
            this.dgvhanghoa.TabIndex = 5;
            // 
            // btnalhh
            // 
            this.btnalhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalhh.Location = new System.Drawing.Point(50, 112);
            this.btnalhh.Name = "btnalhh";
            this.btnalhh.Size = new System.Drawing.Size(236, 39);
            this.btnalhh.TabIndex = 6;
            this.btnalhh.Text = " Xem tất cả hàng hóa";
            this.btnalhh.UseVisualStyleBackColor = true;
            this.btnalhh.Click += new System.EventHandler(this.btnalhh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1092, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1092, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1091, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1092, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Cập Nhật:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1091, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mô Tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1092, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mã Loại:";
            // 
            // txtmahh
            // 
            this.txtmahh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmahh.Location = new System.Drawing.Point(1267, 164);
            this.txtmahh.Name = "txtmahh";
            this.txtmahh.Size = new System.Drawing.Size(327, 30);
            this.txtmahh.TabIndex = 13;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Location = new System.Drawing.Point(1267, 359);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(327, 30);
            this.txtsoluong.TabIndex = 15;
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(1267, 312);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(327, 30);
            this.txtmota.TabIndex = 16;
            // 
            // txtmaloai
            // 
            this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaloai.Location = new System.Drawing.Point(1267, 259);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(327, 30);
            this.txtmaloai.TabIndex = 17;
            // 
            // txttenhh
            // 
            this.txttenhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenhh.Location = new System.Drawing.Point(1267, 211);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(327, 30);
            this.txttenhh.TabIndex = 18;
            // 
            // btnsuahh
            // 
            this.btnsuahh.BackColor = System.Drawing.Color.White;
            this.btnsuahh.Image = global::WarehouseManagement.Presentation.Properties.Resources.tải_xuống__2_up;
            this.btnsuahh.Location = new System.Drawing.Point(994, 443);
            this.btnsuahh.Name = "btnsuahh";
            this.btnsuahh.Size = new System.Drawing.Size(81, 78);
            this.btnsuahh.TabIndex = 4;
            this.btnsuahh.UseVisualStyleBackColor = false;
            // 
            // btnxoahh
            // 
            this.btnxoahh.Image = global::WarehouseManagement.Presentation.Properties.Resources.xóa2;
            this.btnxoahh.Location = new System.Drawing.Point(907, 443);
            this.btnxoahh.Name = "btnxoahh";
            this.btnxoahh.Size = new System.Drawing.Size(81, 78);
            this.btnxoahh.TabIndex = 3;
            this.btnxoahh.UseVisualStyleBackColor = true;
            this.btnxoahh.Click += new System.EventHandler(this.btnxoahh_Click);
            // 
            // btnthemhh
            // 
            this.btnthemhh.BackColor = System.Drawing.Color.White;
            this.btnthemhh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthemhh.Image = global::WarehouseManagement.Presentation.Properties.Resources.tải_xuống__4_;
            this.btnthemhh.Location = new System.Drawing.Point(818, 443);
            this.btnthemhh.Name = "btnthemhh";
            this.btnthemhh.Size = new System.Drawing.Size(83, 78);
            this.btnthemhh.TabIndex = 2;
            this.btnthemhh.UseVisualStyleBackColor = false;
            this.btnthemhh.Click += new System.EventHandler(this.btnthemhh_Click);
            // 
            // dtpngaycn
            // 
            this.dtpngaycn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaycn.Location = new System.Drawing.Point(1270, 405);
            this.dtpngaycn.Name = "dtpngaycn";
            this.dtpngaycn.Size = new System.Drawing.Size(324, 30);
            this.dtpngaycn.TabIndex = 19;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1787, 597);
            this.Controls.Add(this.dtpngaycn);
            this.Controls.Add(this.txttenhh);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmahh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnalhh);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.btnsuahh);
            this.Controls.Add(this.btnxoahh);
            this.Controls.Add(this.btnthemhh);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btnthemhh;
        private System.Windows.Forms.Button btnxoahh;
        private System.Windows.Forms.Button btnsuahh;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button btnalhh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmahh;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.DateTimePicker dtpngaycn;
    }
}