using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;


namespace OnlineMarketPlaceMangmentSystem
{
    public partial class crystal_report : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        CrystalReport1 cr;
        CrystalReport2 cr1;
        CrystalReport3 cry;
        public crystal_report()
        {
            InitializeComponent();
        }

        private void crystal_report_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport1();
            cr1 = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr1.ParameterFields[0].DefaultValues)
                comboBox2.Items.Add(v.Value);
            cry = new CrystalReport3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr1.SetParameterValue(0, comboBox2.Text);
            crystalReportViewer1.ReportSource = cr1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cry;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Hide();
            l.Show();
        }
    }
}
