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
    public partial class frmCTDonHang : Form
    {
        CTDonHangBUS ctdh=new CTDonHangBUS();
        private string maDH=frmDonDatHang.maDH;
        public frmCTDonHang()
        {
            InitializeComponent();
        }

        private void frmCTDonHang_Load(object sender, EventArgs e)
        {
            dgvdschitiet.DataSource= ctdh.DSCTDHTheoMaDH(maDH);
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxemang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmaloai.Text))
            {
                dgvdschitiet.DataSource = ctdh.TimHang(txtmaloai.Text);
            }
            else
            {
                MessageBox.Show("Hãy nhập mã hàng hóa muốn tìm vào ô tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
