using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WarehouseManagement.Presentation
{
    public partial class frmNVBanhang : Form
    {
        public frmNVBanhang()
        {
            InitializeComponent();

        }

        
        private void xdmhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhanghoa frmhanghoa = new frmhanghoa();
            this.Show();
        }

        private void xemHàngHóaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmhanghoa frmhh = new frmhanghoa();
            frmhh.FormBorderStyle = FormBorderStyle.None;
            frmhh.WindowState = FormWindowState.Normal;

            frmhh.MdiParent = this.MdiParent;
            frmhh.ShowDialog();
        }

        private void yêuCầuNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmYCnhaphang frmnh = new frmYCnhaphang();

            frmnh.MdiParent = this;
            frmnh.WindowState = FormWindowState.Maximized;
            frmnh.Show();
            
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLHang  frmnh = new frmQLHang ();
            frmnh.MdiParent = this;
            frmnh.WindowState = FormWindowState.Maximized;
            frmnh.Show();
        }
    }
    }
