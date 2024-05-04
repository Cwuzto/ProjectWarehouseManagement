using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement.Presentation
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = this.BackColor;
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            this.Close();
        }

        private void menuitemQLNV_Click(object sender, EventArgs e)
        {
            frmNhanVien frmnv = new frmNhanVien();

            frmnv.MdiParent = this;
            frmnv.WindowState = FormWindowState.Maximized;
            frmnv.Show();
        }

        private void menuitemQLLNV_Click(object sender, EventArgs e)
        {
            frmQLLoaiNV frmLoaiNV = new frmQLLoaiNV();

            frmLoaiNV.MdiParent = this;
            frmLoaiNV.WindowState = FormWindowState.Maximized;
            frmLoaiNV.Show();
        }

        private void menuitemYCNhapHG_Click(object sender, EventArgs e)
        {
            frmDSYCNhapHang frmYCNhap = new frmDSYCNhapHang();

            frmYCNhap.MdiParent = this;
            frmYCNhap.WindowState = FormWindowState.Maximized;
            frmYCNhap.Show();
        }

        private void menuitemYCDatHg_Click(object sender, EventArgs e)
        {
            frmDSYCDatHang frmYCDat = new frmDSYCDatHang();

            frmYCDat.MdiParent = this;
            frmYCDat.WindowState = FormWindowState.Maximized;
            frmYCDat.Show();
        }

        private void menuitemDonDatHang_Click(object sender, EventArgs e)
        {
            frmDonDatHang frmDonDat = new frmDonDatHang();

            frmDonDat.MdiParent = this;
            frmDonDat.WindowState = FormWindowState.Maximized;
            frmDonDat.Show();
        }

        private void menuitemHgXuatKho_Click(object sender, EventArgs e)
        {
            frmDSHangXuatKho frmHgXuat = new frmDSHangXuatKho();

            frmHgXuat.MdiParent = this;
            frmHgXuat.WindowState = FormWindowState.Maximized;
            frmHgXuat.Show();
        }

        private void menuitemXemThongKeXuatHang_Click(object sender, EventArgs e)
        {
            frmThongKeXuatHang frmThongKeXuatHang = new frmThongKeXuatHang();

            frmThongKeXuatHang.MdiParent = this;
            frmThongKeXuatHang.WindowState = FormWindowState.Maximized;
            frmThongKeXuatHang.Show();
        }

        private void menuitemDSHangTrongKho_Click(object sender, EventArgs e)
        {
            frmQLHang frmHang = new frmQLHang();
            frmHang.MdiParent = this;
            frmHang.WindowState= FormWindowState.Maximized;
            frmHang.Show();
        }
    }
}
