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
    public partial class frmDonDatHang : Form
    {
        DonDatHangBUS nvBUS = new DonDatHangBUS();

        public frmDonDatHang()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            load_data();    
        }

        private void load_data()
        {
            DonDatHangBUS  nvBUS = new DonDatHangBUS();
            dgvDDH.DataSource = nvBUS.LayDSDonDatHang();
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
    }
}
