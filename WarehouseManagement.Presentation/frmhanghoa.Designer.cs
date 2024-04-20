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
            this.dgvdshanghoa = new System.Windows.Forms.DataGridView();
            this.btnxemang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            maLMTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshanghoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maLMTLabel
            // 
            maLMTLabel.AutoSize = true;
            maLMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            maLMTLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            maLMTLabel.Location = new System.Drawing.Point(65, 54);
            maLMTLabel.Name = "maLMTLabel";
            maLMTLabel.Size = new System.Drawing.Size(113, 32);
            maLMTLabel.TabIndex = 1;
            maLMTLabel.Text = "Mã loại";
            // 
            // dgvdshanghoa
            // 
            this.dgvdshanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshanghoa.Location = new System.Drawing.Point(6, 39);
            this.dgvdshanghoa.Name = "dgvdshanghoa";
            this.dgvdshanghoa.RowHeadersWidth = 51;
            this.dgvdshanghoa.RowTemplate.Height = 24;
            this.dgvdshanghoa.Size = new System.Drawing.Size(1009, 310);
            this.dgvdshanghoa.TabIndex = 17;
            // 
            // btnxemang
            // 
            this.btnxemang.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnxemang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxemang.Location = new System.Drawing.Point(880, 95);
            this.btnxemang.Name = "btnxemang";
            this.btnxemang.Size = new System.Drawing.Size(218, 46);
            this.btnxemang.TabIndex = 35;
            this.btnxemang.Text = "Xem hàng";
            this.btnxemang.UseVisualStyleBackColor = false;
            this.btnxemang.Click += new System.EventHandler(this.btnxemang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdshanghoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(64, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 371);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(64, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 47);
            this.button1.TabIndex = 38;
            this.button1.Text = "Ấn để xem tất cả hàng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmaloai
            // 
            this.txtmaloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtmaloai.Location = new System.Drawing.Point(64, 99);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(769, 34);
            this.txtmaloai.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 69);
            this.label1.TabIndex = 39;
            this.label1.Text = "↺";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1241, 599);
            this.Controls.Add(this.label1);
            this.Controls.Add(maLMTLabel);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnxemang);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmhanghoa";
            this.Text = "frmhanghoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshanghoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvdshanghoa;
        private System.Windows.Forms.Button btnxemang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Label label1;
    }
}