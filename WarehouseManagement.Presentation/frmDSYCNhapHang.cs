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
    public partial class frmDSYCNhapHang : Form
    {
        DSYCNhapHgBUS dsYC = new DSYCNhapHgBUS(); 
        public frmDSYCNhapHang()
        {
            InitializeComponent();
        }

        private void frmDSYCNhapHang_Load(object sender, EventArgs e)
        {
            dgvDSYC.DataSource = dsYC.LayDSYCNhap();
            txtSearch.Visible = true;
            dtpSearch.Visible = false;
        }
        private void load_data()
        {
            DSYCNhapHgBUS dsYC = new DSYCNhapHgBUS();
            dgvDSYC.DataSource = dsYC.LayDSYCNhap();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbLoaiTimKiem.SelectedItem != null)
            {
                string loaiTimKiem = cbLoaiTimKiem.SelectedItem.ToString();
                DataTable tb;
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    string keyword = txtSearch.Text;
                    tb = dsYC.Search(loaiTimKiem, keyword);
                }
                else
                {
                    DateTime key = dtpSearch.Value;
                    tb = dsYC.Search(loaiTimKiem, key);
                }
                if (tb == null || tb.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvDSYC.DataSource = tb;
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void cbLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiTimKiem.SelectedItem != null)
            {
                string selectedItem = cbLoaiTimKiem.SelectedItem.ToString();

                if (selectedItem == "Ngày yêu cầu")
                {
                    txtSearch.Visible = false;
                    dtpSearch.Visible = true;
                }
                else
                {
                    txtSearch.Visible = true;
                    dtpSearch.Visible = false;
                }
            }
        }
    }
}
