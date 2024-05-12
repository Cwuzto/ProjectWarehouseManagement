using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WarehouseManagement.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseManagement.Presentation
{
    public partial class frmDonDatHang : Form
    {

        DonDatHangBUS dhBUS = new DonDatHangBUS();
        private string maNV=frmLogin.UserID;
        public static string maDH { get; private set; }

        public frmDonDatHang()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            DonDatHangBUS dhBUS = new DonDatHangBUS();
            dgvDDH.DataSource = dhBUS.LayDSDonDatHang();
        }
        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            txtTinhTrang.Enabled = false;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaDon.Text))
            {
                DateTime ngaydat = dateTimeNgayDat.Value;

                if (dhBUS.JKDDH(txtMaDon.Text, ngaydat, maNV))
                {

                    load_data();
                    txtMaDon.Clear();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private string MaDonCu;
        private string TinhTrangCu;
        private void dgvDDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvDDH.Rows[e.RowIndex];
                txtMaDon.Text = row.Cells["MaDH"].Value.ToString();
                MaDonCu = txtMaDon.Text;
                txtTinhTrang.Enabled=true;
                txtTinhTrang.Text = row.Cells["TrangThai"].Value.ToString();
                TinhTrangCu = txtTinhTrang.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void txtTinhTrang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTinhTrang.Text))
            {
                txtTinhTrang.Enabled = false;
            }
            else
            {
                txtTinhTrang.Enabled = true;
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            maDH=txtMaDon.Text;
            frmCTDonHang frmCTDH = new frmCTDonHang();

            frmCTDH.WindowState = FormWindowState.Maximized;
            frmCTDH.ShowDialog();
        }
    }
}
