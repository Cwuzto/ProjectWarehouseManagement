using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmyeucaudathang : Form
    {
        yeucaunhaphangBUS ycnhBUS = new yeucaunhaphangBUS();

        public frmyeucaudathang()
        {
            InitializeComponent();
        }

        private void load_data()
        {
            dgvxemyc.DataSource = ycnhBUS.laydsyc();

        }







        private void btnxem_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btngui_Click_1(object sender, EventArgs e)
        {

              if (!string.IsNullOrEmpty(txtmahanghoa.Text) && !string.IsNullOrEmpty(txtmanhanvien.Text))
              {
              DateTime ngayycdh = ngayyc.Value;

              if (ycnhBUS.ycdhhoa(ngayycdh, txtmahanghoa.Text, txtmanhanvien.Text,txttrangthai.Text ))


                  {
                      load_data();
                      txtmahanghoa.Clear();
                    txttrangthai.Clear();

                    txtmanhanvien.Clear();
                      MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      return;
                  }
              }

              { MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
           


            }
        }
    }
}

