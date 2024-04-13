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
    public partial class frmDSYCDatHang : Form
    {
        DSYCDatHagBUS dsYCDat = new DSYCDatHagBUS();
        private int checkboxColumnIndex1=0;
        private int checkboxColumnIndex2 = 1;

        public frmDSYCDatHang()
        {
            InitializeComponent();
        }

        private void frmDSYCDatHang_Load(object sender, EventArgs e)
        {
            dgvDSYC.DataSource= dsYCDat.LayDSYCDat();
        }
        private void load_data()
        {
            DSYCDatHagBUS dsYC = new DSYCDatHagBUS();
            dgvDSYC.DataSource = dsYC.LayDSYCDat();
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

                DataTable tb = dsYCDat.Search(loaiTimKiem, keyword);
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

        private void dgvDSYC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == checkboxColumnIndex1|| e.ColumnIndex == checkboxColumnIndex2) 
            {
                string trangThaiHienTai = dgvDSYC.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
                if (trangThaiHienTai == "Chờ xử lý")
                {
                    string maYC = dgvDSYC.Rows[e.RowIndex].Cells["MaYC"].Value.ToString();
                    string trangThaiMoi = dgvDSYC.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (dsYCDat.CapNhatTrangThaiYeuCau(maYC, trangThaiMoi))
                    {
                        load_data();
                        MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không thể cập nhật trạng thái vì yêu cầu đã được xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
