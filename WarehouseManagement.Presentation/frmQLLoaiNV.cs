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
        private bool validateData()
        {
            errorProvider1.SetError(txtLoaiNV, (txtLoaiNV.Text == "") ? "Hãy nhập mã loại nhân viên" : "");
            errorProvider2.SetError(txtTenLoai, (txtTenLoai.Text == "") ? "Hãy nhập tên loại nhân viên" : "");
            return (txtLoaiNV.Text != "" && txtTenLoai.Text != "");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!validateData())
            {
                MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loaiNVBUS.ThemLoaiNV(txtLoaiNV.Text,txtTenLoai.Text))
            {
                load_data();
                txtLoaiNV.Clear();
                txtTenLoai.Clear();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtLoaiNV.Text == "" && txtTenLoai.Text == "" )
            {
                errorProvider1.SetError(txtLoaiNV, (txtLoaiNV.Text == "") ? "Hãy chọn một loại nhân viên" : "");
                errorProvider2.SetError(txtTenLoai, (txtTenLoai.Text == "") ? "Hãy chọn một loại nhân viên" : "");
                MessageBox.Show("Không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loaiNVBUS.Update(oldMaLoai,txtLoaiNV.Text,txtTenLoai.Text))
            {

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtLoaiNV.Clear();
                txtTenLoai.Clear();
                return;
            }
        }
       private string oldMaLoai;
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
            if (txtLoaiNV.Text == "" )
            {
                errorProvider1.SetError(txtLoaiNV, (txtLoaiNV.Text == "") ? "Hãy chọn một loại nhân viên" : "");
                MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loaiNVBUS.DeleteLoaiNV(txtLoaiNV.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtLoaiNV.Clear();
                txtTenLoai.Clear();
                return;
            }
        }
    }
}
