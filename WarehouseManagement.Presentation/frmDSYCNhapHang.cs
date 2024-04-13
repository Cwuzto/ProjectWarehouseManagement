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
            if (cbLoaiTimKiem.SelectedItem != null && !string.IsNullOrEmpty(txtSearch.Text))
            {
                string loaiTimKiem = cbLoaiTimKiem.SelectedItem.ToString();
                string keyword = txtSearch.Text;

                if (loaiTimKiem == "Ngày yêu cầu")
                    loaiTimKiem = "NgayYC";
                else if (loaiTimKiem == "Mã nhân viên")
                    loaiTimKiem = "MaNV";
                else if (loaiTimKiem == "Mã hàng hóa")
                    loaiTimKiem = "MaHH";
                else if (loaiTimKiem == "Trạng thái")
                    loaiTimKiem = "TrangThai";

                DataTable tb = dsYC.Search(loaiTimKiem, keyword);
                if (tb == null || tb.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Console.WriteLine(tb);
                dgvDSYC.DataSource = tb;
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
