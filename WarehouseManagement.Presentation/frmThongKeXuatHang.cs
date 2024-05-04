using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmThongKeXuatHang : Form
    {
        ThongKeXuatHangBUS thongKeBUS;
        public frmThongKeXuatHang()
        {
            InitializeComponent();
            this.thongKeBUS = new ThongKeXuatHangBUS();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date.AddDays(1).AddSeconds(-1); // Đảm bảo ngày kết thúc bao gồm cả ngày cuối cùng

            dgvHangXuatKho.DataSource = thongKeBUS.ThongKeHangXuatTheoNgay(ngayBatDau, ngayKetThuc);

        }

        private void frmThongKeXuatHang_Load(object sender, EventArgs e)
        {
            DataTable data = thongKeBUS.ThongKeHangXuatTheoNgay(DateTime.Parse("1753-01-01"), DateTime.Parse("9999-12-31"));

            // Thiết lập nguồn dữ liệu cho DataGridView
            dgvHangXuatKho.DataSource = data;

            // Thiết lập kích thước DataGridView để hiển thị tất cả dữ liệu mà không cần cuộn
            dgvHangXuatKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}