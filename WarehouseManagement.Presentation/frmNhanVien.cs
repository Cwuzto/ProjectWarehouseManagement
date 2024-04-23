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
            dgvDSNV.DataSource = nvBUS.LayDSNhanVien();
            cbLoaiNV.DataSource=nvBUS.GetDSLoaiNV();
            cbLoaiNV.DisplayMember = "TenLoaiNV";
            cbLoaiNV.ValueMember = "MaLoaiNV";
        }
        private void load_data()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            dgvDSNV.DataSource = nvBUS.LayDSNhanVien();
        }
        private bool validateData()
        {
            errorProvider1.SetError(txtHo, (txtHo.Text == "") ? "Hãy nhập Họ": "");
            errorProvider2.SetError(txtTen, (txtTen.Text == "") ? "Hãy nhập Tên(Lót)": "");
            errorProvider3.SetError(txtSDT, (txtSDT.Text == "") ? "Hãy nhập số điện thoại": "");
            errorProvider4.SetError(txtDiaChi, (txtDiaChi.Text == "") ? "Hãy nhập đia chỉ": "");
            errorProvider5.SetError(txtMaNV, (txtMaNV.Text == "") ? "Hãy nhập mã nhân viên": "");
            errorProvider6.SetError(txtUser, (txtUser.Text == "") ? "Hãy nhập username" : "");
            errorProvider7.SetError(txtPass, (txtPass.Text == "") ? "Hãy nhập password": "");
            return (txtHo.Text != "" && txtTen.Text != ""&& txtSDT.Text!=""&& txtPass.Text!=""&& txtMaNV.Text!=""&& txtDiaChi.Text!="");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int gt;
            if (checkGT.Checked)
                gt = 1;
            else
                gt = 0;
            if (!validateData())
            {
                MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbLoaiNV.SelectedItem != null)
            {
                string loaiNV = cbLoaiNV.SelectedValue.ToString();

                if (nvBUS.AddEmployee(txtHo.Text, txtTen.Text, txtSDT.Text, txtDiaChi.Text, txtPass.Text, txtUser.Text, txtMaNV.Text, gt, loaiNV))
                {
                    load_data();
                    txtHo.Clear();
                    txtTen.Clear();
                    txtSDT.Clear();
                    txtUser.Clear();
                    txtPass.Clear();
                    txtMaNV.Clear();
                    txtDiaChi.Clear();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV_temp.Text==""&& txtOldValue.Text == ""&& txtNewValue.Text == "")
            {
                errorProvider8.SetError(txtMaNV_temp, (txtMaNV_temp.Text == "") ? "Hãy chọn một nhân viên" : "");
                errorProvider9.SetError(txtOldValue, (txtOldValue.Text == "") ? "Hãy chọn thông tin muốn sửa" : "");
                errorProvider10.SetError(txtNewValue, (txtNewValue.Text == "") ? "Hãy nhập thông tin sửa" : "");
                MessageBox.Show("Không thể sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nvBUS.UpdateNV(tenCot,txtOldValue.Text, txtNewValue.Text, txtMaNV_temp.Text))
            {
                
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtMaNV_temp.Clear();
                txtOldValue.Clear();
                txtNewValue.Clear();
                return;
            }

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
            if (txtMaNV_temp.Text == "")
            {
                errorProvider8.SetError(txtMaNV_temp, (txtMaNV_temp.Text == "") ? "Hãy chọn một nhân viên" : "");
                MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nvBUS.DeleteNV(txtMaNV_temp.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtMaNV_temp.Clear();
                txtOldValue.Clear();
                return;
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int passwordLength = 8;
            string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < passwordLength; i++)
            {

                int randomIndex = random.Next(0, allowedChars.Length);
                char randomChar = allowedChars[randomIndex];
                password.Append(randomChar);
            }
            txtPass.Text = password.ToString();
        }
    }
}
