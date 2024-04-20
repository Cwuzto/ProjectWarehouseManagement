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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseManagement.Presentation
{
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHOQUANCFDataSet.LoaiNV' table. You can move, or remove it, as needed.
            this.loaiNVTableAdapter.Fill(this.qLKHOQUANCFDataSet.LoaiNV);
            dgvDSNV.DataSource = nvBUS.LayDSNhanVien();
        }
        private void load_data()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            dgvDSNV.DataSource = nvBUS.LayDSNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int gt;
            if (checkGT.Checked)
                gt = 1;
            else
                gt = 0;
            if (cbLoaiNV.SelectedItem != null)
            {
                string loaiNV = cbLoaiNV.SelectedValue.ToString();

                if (nvBUS.AddEmployee(txtHo.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text, txtPass.Text, txtUser.Text, txtMaNV.Text, gt, loaiNV))
                {
                    load_data();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(nvBUS.UpdateNV(tenCot,txtOldValue.Text, txtNewValue.Text, txtMaNV_temp.Text))
            {
                
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                return;
            }

                MessageBox.Show("Không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        string tenCot;
        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
                txtMaNV_temp.Text = row.Cells["MaNV"].Value.ToString();
                DataGridViewCell oDuocChon = dgvDSNV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                txtOldValue.Text = oDuocChon.Value.ToString();
                DataGridViewColumn cotDuocChon = dgvDSNV.Columns[e.ColumnIndex];
                tenCot = cotDuocChon.HeaderText;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nvBUS.DeleteNV(txtMaNV_temp.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
