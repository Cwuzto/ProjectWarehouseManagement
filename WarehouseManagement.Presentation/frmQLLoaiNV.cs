using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Business;

namespace WarehouseManagement.Presentation
{
    public partial class frmQLLoaiNV : Form
    {
        LoaiNVBUS loaiNVBUS = new LoaiNVBUS();
        public frmQLLoaiNV()
        {
            InitializeComponent();
        }

        private void frmQLLoaiNV_Load(object sender, EventArgs e)
        {
            dgvDSLoaiNV.DataSource = loaiNVBUS.LayDSLoaiNV();
        }
        private void load_data()
        {
            LoaiNVBUS loaiNVBUS = new LoaiNVBUS();
            dgvDSLoaiNV.DataSource = loaiNVBUS.LayDSLoaiNV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (loaiNVBUS.ThemLoaiNV(txtLoaiNV.Text,txtTenLoai.Text))
            {
                load_data();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (loaiNVBUS.Update(oldMaLoai,txtLoaiNV.Text,txtTenLoai.Text))
            {

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                return;
            }

            MessageBox.Show("Không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        string oldMaLoai;
        private void dgvDSLoaiNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvDSLoaiNV.Rows[e.RowIndex];
                txtLoaiNV.Text = row.Cells["MaLoaiNV"].Value.ToString();
                oldMaLoai= row.Cells["MaLoaiNV"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoaiNV"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (loaiNVBUS.DeleteLoaiNV(txtLoaiNV.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
