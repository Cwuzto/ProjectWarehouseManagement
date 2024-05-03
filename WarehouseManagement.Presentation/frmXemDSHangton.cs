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
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmXemDSHangton : Form
    {
       
            XemDSHangtonBUS danhsachhangton = new XemDSHangtonBUS();
            public frmXemDSHangton()
            {
                InitializeComponent();
            }

           
            private void load_data()
            {
                XemDSHangtonBUS danhsachhangton = new XemDSHangtonBUS();
                dgvdshangton.DataSource = danhsachhangton.Laydsht();
            }
         

       

       
        private void btnxemallhh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtmaloai.Text))
            {
                dgvdshangton.DataSource = danhsachhangton.timhang(txtmaloai.Text);
            }
            else
            {
                MessageBox.Show("chua nhap ma loai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
     
       