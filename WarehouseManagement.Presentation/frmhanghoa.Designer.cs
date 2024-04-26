namespace WarehouseManagement.Presentation
{
    partial class frmhanghoa
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
            System.Windows.Forms.Label maLMTLabel;
            System.Windows.Forms.Label label1;
            this.dgvdshanghoa = new System.Windows.Forms.DataGridView();
            this.btnxemang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxemtatcahang = new System.Windows.Forms.Button();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.btntrove = new System.Windows.Forms.Button();
            maLMTLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshanghoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maLMTLabel
            // 
            maLMTLabel.AutoSize = true;
            maLMTLabel.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maLMTLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            maLMTLabel.Location = new System.Drawing.Point(94, 86);
            maLMTLabel.Name = "maLMTLabel";
            maLMTLabel.Size = new System.Drawing.Size(138, 46);
            maLMTLabel.TabIndex = 1;
            maLMTLabel.Text = "Mã loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.LightPink;
            label1.Location = new System.Drawing.Point(496, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(344, 51);
            label1.TabIndex = 40;
            label1.Text = "Xem Hàng Hóa";
            // 
            // dgvdshanghoa
            // 
            this.dgvdshanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshanghoa.Location = new System.Drawing.Point(6, 33);
            this.dgvdshanghoa.Name = "dgvdshanghoa";
            this.dgvdshanghoa.RowHeadersWidth = 51;
            this.dgvdshanghoa.RowTemplate.Height = 24;
            this.dgvdshanghoa.Size = new System.Drawing.Size(961, 310);
            this.dgvdshanghoa.TabIndex = 17;
            // 
            // btnxemang
            // 
            this.btnxemang.BackColor = System.Drawing.Color.LightCoral;
            this.btnxemang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxemang.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemang.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnxemang.Location = new System.Drawing.Point(877, 125);
            this.btnxemang.Name = "btnxemang";
            this.btnxemang.Size = new System.Drawing.Size(214, 50);
            this.btnxemang.TabIndex = 35;
            this.btnxemang.Text = "Xem hàng";
            this.btnxemang.UseVisualStyleBackColor = false;
            this.btnxemang.Click += new System.EventHandler(this.btnxemang_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.dgvdshanghoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.Location = new System.Drawing.Point(102, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 360);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // btnxemtatcahang
            // 
            this.btnxemtatcahang.BackColor = System.Drawing.Color.LightCoral;
            this.btnxemtatcahang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxemtatcahang.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemtatcahang.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnxemtatcahang.Location = new System.Drawing.Point(102, 556);
            this.btnxemtatcahang.Name = "btnxemtatcahang";
            this.btnxemtatcahang.Size = new System.Drawing.Size(263, 50);
            this.btnxemtatcahang.TabIndex = 38;
            this.btnxemtatcahang.Text = "Xem Tất Cả Hàng";
            this.btnxemtatcahang.UseVisualStyleBackColor = false;
            this.btnxemtatcahang.Click += new System.EventHandler(this.btnxemtatcahang_Click);
            // 
            // txtmaloai
            // 
            this.txtmaloai.BackColor = System.Drawing.SystemColors.Info;
            this.txtmaloai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaloai.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmaloai.Location = new System.Drawing.Point(102, 135);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(769, 34);
            this.txtmaloai.TabIndex = 2;
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.LightCoral;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btntrove.Location = new System.Drawing.Point(-2, 0);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(63, 67);
            this.btntrove.TabIndex = 39;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // frmhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1144, 612);
            this.Controls.Add(this.btnxemtatcahang);
            this.Controls.Add(label1);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(maLMTLabel);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.btnxemang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmhanghoa";
            this.Text = "frmhanghoa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshanghoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdshanghoa;
        private System.Windows.Forms.Button btnxemang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxemtatcahang;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Button btntrove;
    }
}