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
    public partial class frmDonDatHang : Form
    {

        DonDatHangBUS dhBUS = new DonDatHangBUS();

        public frmDonDatHang()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void load_data()
        {
            DonDatHangBUS dhBUS = new DonDatHangBUS();
            dgvDDH.DataSource = dhBUS.LayDSDonDatHang();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void frmDonDatHang_Load(object sender, EventArgs e)
        {

        }

        private void dgvDDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDon.Text) && !string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                DateTime ngaydat = dateTimeNgayDat.Value;

                if (dhBUS.JKDDH(txtMaDon.Text, ngaydat, txtTinhTrang.Text, txtMaNhanVien.Text))
                {

                    load_data();
                    txtMaDon.Clear();
                    txtTinhTrang.Clear();
                    txtMaNhanVien.Clear();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dhBUS.DeleteDonDatHang(txtMaDon.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtMaDon.Clear();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapnhat_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDon.Text) && !string.IsNullOrEmpty(txtTinhTrang.Text))
            {
                if (dhBUS.UpdateDonDatHang(txtMaDon.Text, txtTinhTrang.Text, MaDonCu, TinhTrangCu))
                {

                    load_data();
                    txtMaDon.Clear();
                    txtTinhTrang.Clear();
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            MessageBox.Show("Không thể cập nhật tình trạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        string MaDonCu;
        string TinhTrangCu;
        private void dgvDDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvDDH.Rows[e.RowIndex];
                txtMaDon.Text = row.Cells["MaDH"].Value.ToString();
                MaDonCu = txtMaDon.Text;

                txtTinhTrang.Text = row.Cells["TrangThai"].Value.ToString();
                TinhTrangCu = txtTinhTrang.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        
    }
}
