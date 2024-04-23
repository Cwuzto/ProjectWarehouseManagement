using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            //txtUsername.Clear();
            //txtPassword.Clear();
            //txtUsername.Focus();
        }

        private bool validateData()
        {
            errorProvider1.SetError(txtUsername, (txtUsername.Text == "") ? "Hãy nhập UserName" : "");
            errorProvider2.SetError(txtPassword, (txtPassword.Text == "") ? "Hãy nhập Password" : "");
            return (txtUsername.Text != "" && txtPassword.Text != "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text;
            string matKhau = txtPassword.Text;

            if (!validateData())
            {
                return;
            }

            string query = "Select * from NhanVien where UserName = '" + tenDangNhap + "' and Password = '" + matKhau + "'";

            Modify modify = new Modify();

            if (modify.TaiKhoans(query).Count != 0)
            {
                MessageBox.Show("Login Successful!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmQuanLy frmQuanLy = new frmQuanLy();
                frmQuanLy.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai Username hoặc Password!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
            }
        }
    }
}
