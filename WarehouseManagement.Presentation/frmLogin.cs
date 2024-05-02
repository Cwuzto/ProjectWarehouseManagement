﻿using System;
using System.Windows.Forms;
using WarehouseManagement.Bussiness;

namespace WarehouseManagement.Presentation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool validateData()
        {
            errorProvider1.SetError(txtUsername, (txtUsername.Text == "") ? "Hãy nhập UserName" : "");
            errorProvider2.SetError(txtPassword, (txtPassword.Text == "") ? "Hãy nhập Password" : "");
            return (txtUsername.Text != "" && txtPassword.Text != "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord = txtPassword.Text;

            if (!validateData())
            {
                return;
            }

            LoginBUS loginBUS = new LoginBUS();

            if (loginBUS.Login(userName, passWord))
            {
                string maLoai = loginBUS.GetMaLoai(userName);

                switch (maLoai)
                {
                    case "L01":
                        frmQuanLy frmQuanLy = new frmQuanLy();
                        this.Hide();
                        frmQuanLy.ShowDialog();
                        this.Close();
                        break;
                    case "L02":
                        Nhân_Viên_Kho frmNhanVienKho = new Nhân_Viên_Kho();
                        this.Hide();
                        frmNhanVienKho.ShowDialog();
                        this.Close();
                        break;
                    case "L03":
                        frmNhanVien frmNhanVien = new frmNhanVien();
                        this.Hide();
                        frmNhanVien.ShowDialog();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Loại tài khoản không được hỗ trợ!",
                                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi phương thức xử lý đăng nhập
                btnLogin_Click(sender, e);// Gọi phương thức xử lý đăng nhập khi nhấn Enter
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Gọi phương thức xử lý đăng nhập
                btnLogin_Click(sender, e); // Gọi phương thức xử lý đăng nhập khi nhấn Enter
            }
        }
    }
}
