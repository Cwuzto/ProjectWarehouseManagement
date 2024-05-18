using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmQLHang : Form
    {
        QLHangBUS qlhanghoa = new QLHangBUS();

        public frmQLHang()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            QLHangBUS qlhb = new QLHangBUS();

            dgvdshang.DataSource = qlhb.laydshh();
        }



        private void btnxemallhh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtmahh.Text))
            {
                DateTime ngaycnh = ngaycn.Value;

                if (qlhanghoa.qlhang(txtmahh.Text, txttenhang.Text, txtmota.Text, txtsoluong.Text, ngaycnh, txtmaloai.Text))


                {
                    load_data();
                    txtmahh.Clear();
                    txttenhang.Clear();
                    txtmota.Clear();
                    txtsoluong.Clear();
                    txtmaloai.Clear();


                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            if (qlhanghoa.Deletehh(txtmahh.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtmahh.Clear();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmahh.Text))
            {                   

               if (!string.IsNullOrEmpty(txttenhang.Text) && (!string.IsNullOrEmpty(txtmota.Text) && (!string.IsNullOrEmpty(txtsoluong.Text))))
               {
                    if (qlhanghoa.CtTenHangHoa(txtmahh.Text, txttenhang.Text) && qlhanghoa.CtMoTa(txtmahh.Text, txtmota.Text)&& qlhanghoa.CtSoLuong(txtmahh.Text, txtsoluong.Text))
                    {
                        load_data();
                        txtmahh.Clear();
                        txttenhang.Clear();
                        txtmota.Clear();
                        txtsoluong.Clear();

                        MessageBox.Show("Cập nhật hàng hóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
          

            private string mahangcu;
            private string tenhangcu;
            private void dgvdshang_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow row = dgvdshang.Rows[e.RowIndex];
                    txtmahh.Text = row.Cells["MaHH"].Value.ToString();
                    txtmota.Text = row.Cells["MoTa"].Value.ToString();
                    txtsoluong.Text = row.Cells["MaLoai"].Value.ToString();
                txttenhang.Text = row.Cells["TenHH"].Value.ToString();
                    txtsoluong.Text = row.Cells["SoLuong"].Value.ToString();          
                txtmaloai.Text = row.Cells["MaLoai"].Value.ToString();

                }
            }

        private void frmQLHang_Load(object sender, EventArgs e)
        {
            dgvdshang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}  
    
    
