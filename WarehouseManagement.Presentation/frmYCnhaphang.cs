using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmYCnhaphang : Form
    { 
        YCnhaphangBUS ycnh = new YCnhaphangBUS(); 
        private String maNV=frmLogin.UserID;
        public frmYCnhaphang()
        {
            InitializeComponent();
        }
        
        private void load_data()
        {
            YCnhaphangBUS ycnhb = new YCnhaphangBUS();  
            dgvdsyc.DataSource=ycnhb.laydsyc();
            dgvdsyc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmahh.Text))
            {
                DateTime ngayycdh = ngayyc.Value;

                if (ycnh.ycdhhoa(maNV, txtmahh.Text, ngayycdh))
                {
                    load_data();    
                    txtmahh.Clear();

                    MessageBox.Show("Gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
             else
            {
                MessageBox.Show("Không thể gửi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void btnxemdsyc_Click(object sender, EventArgs e)
        {
            load_data() ;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (ycnh.Deleteycnhh(txtmahh.Text, ngayyc.Value, maNV))
            {
                MessageBox.Show("Hủy thành công yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtmahh.Clear();
                return;
            }

            MessageBox.Show("Không thể hủy yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdsyc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvdsyc.Rows[e.RowIndex];
                txtmahh.Text = row.Cells["MaHH"].Value.ToString();
                ngayyc.Value = DateTime.Parse(row.Cells["NgayYC"].Value.ToString());

            }
        }
    }
}
