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
    { YCnhaphangBUS ycnh = new YCnhaphangBUS(); 
        public frmYCnhaphang()
        {
            InitializeComponent();
        }
        
        private void load_data()
        {
            YCnhaphangBUS ycnhb = new YCnhaphangBUS();  
            dgvdsyc.DataSource=ycnhb.laydsyc();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmahh.Text) && !string.IsNullOrEmpty(txtmanv.Text))
            {
                DateTime ngayycdh = ngayyc.Value;

                if (ycnh.ycdhhoa(txtmanv.Text, txtmahh.Text, ngayycdh,txttrangthai.Text))


                {
                    load_data();
                    txtmanv.Clear();    
                    txtmahh.Clear();
                    txttrangthai.Clear();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            {
                MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void btnxemdsyc_Click(object sender, EventArgs e)
        {
            load_data() ;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (ycnh.Deleteycnhh(txtmahh.Text))
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
                txtmanv.Text = row.Cells["MaNV"].Value.ToString();
                txttrangthai.Text = row.Cells["TrangThai"].Value.ToString();
               

            }
        }
    }
}
