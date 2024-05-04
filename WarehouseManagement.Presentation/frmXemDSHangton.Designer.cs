namespace WarehouseManagement.Presentation
{
    partial class frmXemDSHangton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDSHangton));
            this.label5 = new System.Windows.Forms.Label();
            this.btnxemallhh = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdshangton = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshangton)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("UVN Bach Tuyet Nang", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Plum;
            this.label5.Location = new System.Drawing.Point(348, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(643, 56);
            this.label5.TabIndex = 94;
            this.label5.Text = " Danh Sách Hàng Tồn Kho";
            // 
            // btnxemallhh
            // 
            this.btnxemallhh.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnxemallhh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxemallhh.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxemallhh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnxemallhh.Location = new System.Drawing.Point(10, 542);
            this.btnxemallhh.Name = "btnxemallhh";
            this.btnxemallhh.Size = new System.Drawing.Size(233, 47);
            this.btnxemallhh.TabIndex = 92;
            this.btnxemallhh.Text = "Xem Danh Sách ";
            this.btnxemallhh.UseVisualStyleBackColor = false;
            this.btnxemallhh.Click += new System.EventHandler(this.btnxemallhh_Click);
            // 
            // btntrove
            // 
            this.btntrove.BackColor = System.Drawing.Color.MediumOrchid;
            this.btntrove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btntrove.Location = new System.Drawing.Point(0, 1);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(63, 67);
            this.btntrove.TabIndex = 82;
            this.btntrove.Text = "↩️";
            this.btntrove.UseVisualStyleBackColor = false;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.dgvdshangton);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(10, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 360);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgvdshangton
            // 
            this.dgvdshangton.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvdshangton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvdshangton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdshangton.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvdshangton.Location = new System.Drawing.Point(6, 43);
            this.dgvdshangton.Name = "dgvdshangton";
            this.dgvdshangton.RowHeadersWidth = 51;
            this.dgvdshangton.RowTemplate.Height = 24;
            this.dgvdshangton.Size = new System.Drawing.Size(1123, 310);
            this.dgvdshangton.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 38);
            this.label1.TabIndex = 97;
            this.label1.Text = "Mã Hàng:";
            // 
            // txtmaloai
            // 
            this.txtmaloai.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmaloai.Location = new System.Drawing.Point(186, 95);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(300, 39);
            this.txtmaloai.TabIndex = 101;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(510, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 38);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmXemDSHangton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1469, 741);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnxemallhh);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXemDSHangton";
            this.Text = "frmXemDSHangton";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdshangton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnxemallhh;
        private System.Windows.Forms.Button btntrove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdshangton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.Button btnSearch;
    }
}