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
    public partial class Nhân_Viên_Kho : Form
    {
        public Nhân_Viên_Kho()
        {
            InitializeComponent();
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form currentPresentation;
        private void OpenPresentation(Form Presentation)
        {
            if(currentPresentation != null)
            {
                currentPresentation.Close();
            }
            currentPresentation = Presentation;
            Presentation.TopLevel = false;
            Presentation.FormBorderStyle = FormBorderStyle.None;
            Presentation.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(Presentation);
            panel_Body.Tag = Presentation;
            Presentation.BringToFront();
            Presentation.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenPresentation(new Cap_nhat());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenPresentation(new frmDSYCNhapHang());
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenPresentation(new Xác_nhận());
            label1.Text = button3.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(currentPresentation != null)
            {
                currentPresentation.Close();
            }
            label1.Text = "HOME";
        }
    }
}
