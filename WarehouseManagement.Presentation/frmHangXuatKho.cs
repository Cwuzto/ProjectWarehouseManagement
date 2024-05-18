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
    public partial class frmHangXuatKho : Form
    {
        DSHangXuatKhoBUS dsHgBus = new DSHangXuatKhoBUS();
        private string maNV = frmLogin.UserID;
        public frmHangXuatKho()
        {
            InitializeComponent();
        }

        private void frmHangXuatKho_Load(object sender, EventArgs e)
        {
            dgvdshangxuatkho.DataSource = dsHgBus.LayDSHgXuatKho();
            dgvdshangxuatkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void load_data()
        {
            DSHangXuatKhoBUS dsHgBus = new DSHangXuatKhoBUS();
            dgvdshangxuatkho.DataSource = dsHgBus.LayDSHgXuatKho();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtmahang.Text))
            {
                MessageBox.Show("Mã hàng hóa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nbrSL.Value==0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime ngayxuathang=dtpNgayXuat.Value;
            if(dsHgBus.ThemHang(txtmahang.Text,maNV,ngayxuathang,Convert.ToInt32( nbrSL.Value)))
            {
                load_data();
                txtmahang.Clear();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmahang.Text))
            {
                MessageBox.Show("Hãy chọn một hàng hóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nbrSL.Value == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dsHgBus.SuaTT(id, txtmahang.Text,dtpNgayXuat.Value, Convert.ToInt32(nbrSL.Value)))
            {

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                return;
            }
            MessageBox.Show("Lỗi! Không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private int id;
        private void dgvdshangxuatkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvdshangxuatkho.Rows[e.RowIndex];
                id = int.Parse(row.Cells["IDHg"].Value.ToString());
                txtmahang.Text = row.Cells["MaHH"].Value.ToString();
                dtpNgayXuat.Value = DateTime.Parse(row.Cells["NgayXuat"].Value.ToString());
                nbrSL.Value= int.Parse(row.Cells["SoLuong"].Value.ToString());
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
