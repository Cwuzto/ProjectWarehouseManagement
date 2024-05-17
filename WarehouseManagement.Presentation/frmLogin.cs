using System;
using System.Windows.Forms;
using WarehouseManagement.Business;
using WarehouseManagement.Bussiness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WarehouseManagement.Presentation
{
    public partial class frmLogin : Form
    {
        public static string UserID { get; private set; }
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
                string maNV=loginBUS.GetMaNV(userName, passWord);
                UserID = maNV;

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
                        frmNVBanhang frmNVBanhang = new frmNVBanhang();
                        this.Hide();
                        frmNVBanhang.ShowDialog();
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
                txtUsername.Clear();
                txtUsername.Focus();
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
                e.Handled = true; // Ngăn chặn kí tự Enter được hiển thị trong ô mật khẩu
                // Gọi phương thức xử lý đăng nhập
                btnLogin_Click(sender, e);// Gọi phương thức xử lý đăng nhập khi nhấn Enter
                // Xóa kí tự xuống dòng (\n) từ chuỗi mật khẩu
                txtPassword.Text = txtPassword.Text.Replace("\n", "");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn kí tự Enter được hiển thị trong ô mật khẩu
                // Gọi phương thức xử lý đăng nhập
                btnLogin_Click(sender, e); // Gọi phương thức xử lý đăng nhập khi nhấn Enter
                // Xóa kí tự xuống dòng (\n) từ chuỗi mật khẩu
                txtUsername.Text = txtUsername.Text.Replace("\n", "");
            }
        }
    }
}
