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

namespace WarehouseManagement.Presentation
{
    public partial class frmXemDSHangton : Form
    {
       
            XemDSHangtonBUS danhsachhangton = new XemDSHangtonBUS();
            public frmXemDSHangton()
            {
                InitializeComponent();
            }

           
            private void load_data()
            {
                XemDSHangtonBUS danhsachhangton = new XemDSHangtonBUS();
                dgvdshangton.DataSource = danhsachhangton.Laydsht();
                dgvdshangton.ReadOnly = true;
                dgvdshangton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
         

       

       
        private void btnxemallhh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtmaloai.Text))
            {
                dgvdshangton.DataSource = danhsachhangton.timhang(txtmaloai.Text);
            }
            else
            {
                MessageBox.Show("chua nhap ma loai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            dgvdshangton.ReadOnly = false;
            dgvdshangton.Columns["MaHH"].ReadOnly = true;
            dgvdshangton.Columns["TenHH"].ReadOnly = true;
            dgvdshangton.Columns["MoTa"].ReadOnly = true;
            dgvdshangton.Columns["NgayCapNhat"].ReadOnly = true;
            dgvdshangton.Columns["MaLoai"].ReadOnly = true;
            dgvdshangton.Columns["SoLuong"].ReadOnly = false;
        }

        private void frmXemDSHangton_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<Tuple<string, int>> data = new List<Tuple<string, int>>();
            foreach (DataGridViewRow row in dgvdshangton.Rows)
            {
                if (row.IsNewRow) continue;
                string mahh = row.Cells["MaHH"].Value?.ToString();
                int sl = int.Parse(row.Cells["SoLuong"].Value?.ToString());
                data.Add(new Tuple<string, int>(mahh, sl));
            }
            DateTime ngaycapnhat= DateTime.Now;
            if(danhsachhangton.CapNhapSLHH(data, ngaycapnhat))
            {
                load_data();
                MessageBox.Show("Cập nhật số lượng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Không thể cập nhật số lượng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
     
       