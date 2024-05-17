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
    public partial class frmThongKeNhapHang : Form
    {
        ThongKeNhapHangBUS thongKeNhapBUS;
        public frmThongKeNhapHang()
        {
            InitializeComponent();
            this.thongKeNhapBUS = new ThongKeNhapHangBUS();
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date.AddDays(1).AddSeconds(-1); // Đảm bảo ngày kết thúc bao gồm cả ngày cuối cùng

            dgvHangNhapKho.DataSource = thongKeNhapBUS.ThongKeHangNhapTheoNgay(ngayBatDau, ngayKetThuc);
        }
        private void frmThongKeNhapHang_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeNhapBUS.ThongKeHangNhapTheoNgay(DateTime.Parse("1753-01-01"), DateTime.Parse("9999-12-31"));

            // Thiết lập nguồn dữ liệu cho DataGridView
            dgvHangNhapKho.DataSource = data;

            // Thiết lập kích thước DataGridView để hiển thị tất cả dữ liệu mà không cần cuộn
            dgvHangNhapKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
