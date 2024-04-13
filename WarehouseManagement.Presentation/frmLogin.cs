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
            const string user = "123";
            const string password = "1";

            if (!validateData())
            {
                return;
            }

            if (user.Equals(txtUsername.Text) &&
                password.Equals(txtPassword.Text))
            {
                this.Close();

            }
            else
            {
                MessageBox.Show("Sai Username hoặc Password!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
