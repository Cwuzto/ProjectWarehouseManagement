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
    public partial class frmhanghoa : Form
    {         
        hanghoaBUS hhBUS = new hanghoaBUS();

        public frmhanghoa()
        {
            InitializeComponent();
        }
    
        
            private void load_data()
            {
                hanghoaBUS HH= new hanghoaBUS();
                dgvdshanghoa.DataSource = HH.Laydshanghoa();
            }




          
        private void button1_Click(object sender, EventArgs e)
        {
            load_data();

        }
        /*  private void btntim_Click(object sender, EventArgs e)
  {
      if (cbbtimkiem.SelectedItem != null && !string.IsNullOrEmpty(txttim.Text))
      {
          string loaiTimKiem = cbbtimkiem.SelectedItem.ToString();
          string keyword = txttim.Text;

          if (loaiTimKiem == "Mã loại")
              loaiTimKiem = "MaLoai"; // Assuming "Mã loại" is the display name in the ComboBox

          DataTable tb = ((DataTable)dgvdshanghoa.DataSource);
          if (tb != null)
          {
              tb.DefaultView.RowFilter = $"{loaiTimKiem} = '{keyword}'";
              dgvdshanghoa.DataSource = tb.DefaultView.ToTable();
          }
          else
          {
              MessageBox.Show("Data source is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
      }
      else
      {
          MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
  }*/




    }
    }

