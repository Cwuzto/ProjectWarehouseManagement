using DevExpress.Utils.Gesture;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WarehouseManagement.Presentation
{
    public partial class frmYeuCauDatHang : Form
    {

        YeuCauDatHangBUS ycdhBUS = new YeuCauDatHangBUS();

        public frmYeuCauDatHang()
        {
            InitializeComponent();
        }



        private void load_data()
        {
            YeuCauDatHangBUS ycdhBUS = new YeuCauDatHangBUS();
            dgvYCDH.DataSource = ycdhBUS.LayDSYeuCauDatHang();
        }
       

        private void frmYeuCauDatHang_Load(object sender, EventArgs e)
        {

        }

        
        String TrangThai = "Chờ xử lý ";
        
        DateTime ngayhientai = DateTime.Now;
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHH.Text) && !string.IsNullOrEmpty(txtMaNV.Text))
            {
                

                if (ycdhBUS.JKYCDH(ngayhientai, txtMaNV.Text, txtMaHH.Text, TrangThai))
                {
                    load_data();
                    txtMaNV.Clear();
                    txtMaHH.Clear();
                   
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (ycdhBUS.DeleteYeuCauDatHang(txtMaHH.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                txtMaHH.Clear();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCapnhat_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHH.Text))
            {
                if (ycdhBUS.UpdateYeuCauDatHang(txtMaHH.Text, txtMaNV.Text, MaHHCu, ngayhientai))
                {

                    load_data();
                    txtMaHH.Clear();
                   
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            MessageBox.Show("Không cập nhật được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        string MaHHCu;
        string TinhTrangCu;
        private void dgvYCDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvYCDH.Rows[e.RowIndex];
                txtMaHH.Text = row.Cells["MaHH"].Value.ToString();
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                MaHHCu = txtMaHH.Text;

               
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            load_data();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }


}
