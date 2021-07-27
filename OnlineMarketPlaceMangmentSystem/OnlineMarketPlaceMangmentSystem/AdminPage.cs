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


namespace OnlineMarketPlaceMangmentSystem
{
    public partial class AdminPage : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void loadinfo_btn_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl; User Id=scott;password=tiger;";
            string cmdstr = "";
            if (radioButton1.Checked)
                cmdstr = "select * from CUSTOMER";
            else if (radioButton2.Checked)
                cmdstr = "select * from COMPANY";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void searchcustomer_btn_Click(object sender, EventArgs e)
        {
            string constr = "User ID = scott; password = tiger; data source =orcl";
            string cmdstr = @"select F_NAME , L_NAME , E_MAIL , CPASSWORD , PHONE ,CITY , COUNTRY 
                              from CUSTOMER C
                              where C.CUSTOMER_ID=:n";

            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", textBox1.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void searchcompany_btn_Click(object sender, EventArgs e)
        {
            string constr = "User ID = scott; password = tiger; data source =orcl";
            string cmdstr = @"select name, E_MAIL , PASSWORD , PHONE  
                              from company C
                              where C.company_ID=:n";

            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", textBox2.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void showcrystalreport_btn_Click(object sender, EventArgs e)
        {
            crystal_report c_r = new crystal_report();
            this.Hide();
            c_r.Show();
        }
    }
}
