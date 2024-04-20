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

        private void menuitemYCNHG_Click(object sender, EventArgs e)
        {
            frmDSYCNhapHang frmYCNhap = new frmDSYCNhapHang();

            frmYCNhap.MdiParent = this;
            frmYCNhap.WindowState = FormWindowState.Maximized;
            frmYCNhap.Show();
        }

        private void menuitemYCNhapHg_Click(object sender, EventArgs e)
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
    }
}
