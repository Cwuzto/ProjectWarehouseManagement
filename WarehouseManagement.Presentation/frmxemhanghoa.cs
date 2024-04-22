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
    public partial class frmxemhanghoa : Form
    {         
        xemhanghoaBUS hhBUS = new xemhanghoaBUS();

        public frmxemhanghoa()
        {
            InitializeComponent();
        }
    
        
            private void load_data()
            {
                xemhanghoaBUS HH= new xemhanghoaBUS();
                dgvdshanghoa.DataSource = HH.Laydshanghoa();
            }
          
        private void button1_Click(object sender, EventArgs e)
        {
            load_data();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmNVbanhang otherForm = new frmNVbanhang();
            

            otherForm.Show();
        }
private void btnxemang_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmaloai.Text))
            {
                dgvdshanghoa.DataSource = hhBUS.timhang(txtmaloai.Text);
            }
            else
            {
                MessageBox.Show("chua nhap ma loai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }

