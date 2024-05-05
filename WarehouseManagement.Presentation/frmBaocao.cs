using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace WarehouseManagement.Presentation
{
    public partial class FrmBaocao : Form
    {
        string strCon = @"Data Source=CUBO\SQLEXPRESS;Initial Catalog=QLKHOQUANCF;Integrated Security=True";
        SqlConnection sqlCon = null;
        public FrmBaocao()
        {
            InitializeComponent();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            string sql = "select * from HangHoa";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "HangHoa");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WarehouseManagement.Presentation.ReportBaocao.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["HangHoa"];

            this.reportViewer1.LocalReport.DataSources.Add(rds);


            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
