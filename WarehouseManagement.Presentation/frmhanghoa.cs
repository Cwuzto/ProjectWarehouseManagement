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
    public partial class frmHangHoa : Form
    {
        HangHoaBUS  HHBUS = new HangHoaBUS();

        public frmHangHoa()
        {
            InitializeComponent();
        }
        private void load_data()
        {
            HangHoaBUS hanghoa = new HangHoaBUS();
            dgvhanghoa.DataSource = hanghoa.danhsachhh();
        }
       

        private void btnalhh_Click(object sender, EventArgs e)
        {
            load_data();    
        }

        private void btnthemhh_Click(object sender, EventArgs e)
        {
           if (!string.IsNullOrEmpty(txtmahh.Text) && !string.IsNullOrEmpty(txtmaloai.Text))
            {
                DateTime ngaycn = dtpngaycn.Value;

                if (HHBUS.adhang(txtmahh.Text, txttenhh.Text, txtmota.Text, txtsoluong.Text , ngaycn, txtmaloai.Text))


                {
                    load_data();
                    txtmahh.Clear();
                    txttenhh.Clear();
                    txtmaloai.Clear();
                    txtsoluong.Clear(); 
                    txtmota.Clear();    
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            {
                MessageBox.Show("Không thể thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void btnxoahh_Click(object sender, EventArgs e)
        {
            if (HHBUS.deletehang(txtmahh.Text))
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_data();
                return;
            }

            MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
