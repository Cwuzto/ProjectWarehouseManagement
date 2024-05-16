namespace WarehouseManagement.Presentation
{
    partial class frmCTDonHang
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label maLMTLabel;
            this.btntrove = new System.Windows.Forms.Button();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.btnxemang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdschitiet = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            maLMTLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdschitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.LightPink;
            label1.Location = new System.Drawing.Point(432, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(508, 51);
            label1.TabIndex = 46;
            label1.Text = "Xem Chi Tiết Hóa Đơn";
            // 
            // maLMTLabel
            // 
            maLMTLabel.AutoSize = true;
            maLMTLabel.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maLMTLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            maLMTLabel.Location = new System.Drawing.Point(197, 93);
            maLMTLabel.Name = "maLMTLabel";
            maLMTLabel.Size = new System.Drawing.Size(133, 45);
            maLMTLabel.TabIndex = 41;
            maLMTLabel.Text = "Mã loại";
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.LightCoral;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btntrove.Location = new System.Drawing.Point(0, -7);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(63, 67);
            this.btntrove.TabIndex = 45;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // txtmaloai
            // 
            this.txtmaloai.BackColor = System.Drawing.SystemColors.Info;
            this.txtmaloai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaloai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmaloai.Location = new System.Drawing.Point(205, 141);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(769, 34);
            this.txtmaloai.TabIndex = 42;
            // 
            // btnxemang
            // 
            this.btnxemang.BackColor = System.Drawing.Color.LightCoral;
            this.btnxemang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemang.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemang.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnxemang.Location = new System.Drawing.Point(980, 134);
            this.btnxemang.Name = "btnxemang";
            this.btnxemang.Size = new System.Drawing.Size(214, 50);
            this.btnxemang.TabIndex = 44;
            this.btnxemang.Text = "Xem hàng";
            this.btnxemang.UseVisualStyleBackColor = false;
            this.btnxemang.Click += new System.EventHandler(this.btnxemang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.dgvdschitiet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(205, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 360);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvdschitiet
            // 
            this.dgvdschitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgvdschitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdschitiet.Location = new System.Drawing.Point(6, 33);
            this.dgvdschitiet.Name = "dgvdschitiet";
            this.dgvdschitiet.RowHeadersWidth = 51;
            this.dgvdschitiet.RowTemplate.Height = 24;
            this.dgvdschitiet.Size = new System.Drawing.Size(961, 310);
            this.dgvdschitiet.TabIndex = 17;
            // 
            // frmCTDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1286, 528);
            this.Controls.Add(label1);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(maLMTLabel);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.btnxemang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCTDonHang";
            this.Text = "Chi tiết đơn hàng";
            this.Load += new System.EventHandler(this.frmCTDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdschitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Button btnxemang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdschitiet;
    }
}