﻿using System;
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
    public partial class frmNVbanhang : Form
    {
        public frmNVbanhang()
        {
            InitializeComponent();
        }

        private void btnxemdanhsach_Click(object sender, EventArgs e)
        {
            frmxemhanghoa otherForm = new frmxemhanghoa();
            otherForm.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmyeucaudathang otherForm = new frmyeucaudathang();
            otherForm.Show();
        }
    }
}
