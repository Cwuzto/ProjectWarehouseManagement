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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseManagement.Presentation
{
    public partial class frmDSHangXuatKho : Form
    {
        DSHangXuatKhoBUS dsHgBus = new DSHangXuatKhoBUS();
        public frmDSHangXuatKho()
        {
            InitializeComponent();
        }

        private void frmDSHangXuatKho_Load(object sender, EventArgs e)
        {
            dgvHgXuatKho.DataSource= dsHgBus.LayDSHgXuatKho();
            txtSearch.Visible = true;
            dtpSearch.Visible = false;
        }
        private void load_data()
        {
            DSHangXuatKhoBUS dsHgBus = new DSHangXuatKhoBUS();
            dgvHgXuatKho.DataSource = dsHgBus.LayDSHgXuatKho();
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
                    tb = dsHgBus.Search(loaiTimKiem, keyword);
                }
                else
                {
                    DateTime key=dtpSearch.Value;
                    tb = dsHgBus.Search(loaiTimKiem, key);
                }
                if (tb == null || tb.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvHgXuatKho.DataSource = tb;
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        
        private void cbLoaiTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbLoaiTimKiem.SelectedItem != null)
            {
                string selectedItem = cbLoaiTimKiem.SelectedItem.ToString();

                if (selectedItem == "Ngày xuất")
                {
                    txtSearch.Visible = false;
                    txtSearch.Clear();
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
