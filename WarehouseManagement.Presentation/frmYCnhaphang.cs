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
    public partial class frmYCnhaphang : Form
    { YCnhaphangBUS ycnh = new YCnhaphangBUS(); 
        public frmYCnhaphang()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            YCnhaphangBUS  ycnhaphangb = new YCnhaphangBUS ();

            dgvdsyc.DataSource = ycnh.laydsyc();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtmahh.Text) && !string.IsNullOrEmpty(txtmanv.Text))
            {
                DateTime ngayycdh = ngayyc.Value;

                if (ycnh.ycdhhoa(txtmanv.Text, txtmahh.Text, ngayycdh,txttrangthai.Text))


                {
                    load_data();
                    txtmanv.Clear();    
                    txtmahh.Clear();
                    txttrangthai.Clear();

                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            {
                MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }

        private void btnxemdsyc_Click(object sender, EventArgs e)
        {
            load_data() ;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmanv.Clear();
            txtmahh.Clear();
            txttrangthai.Clear();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
