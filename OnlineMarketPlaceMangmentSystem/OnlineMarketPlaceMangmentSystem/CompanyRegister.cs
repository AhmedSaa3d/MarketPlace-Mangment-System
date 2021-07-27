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
    public partial class CompanyRegister : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public CompanyRegister()
        {
            InitializeComponent();
            password_txt.UseSystemPasswordChar = true;
        }

        private void CompanyRegister_Load(object sender, EventArgs e)
        {
            // to show the new id for the new company
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*)+1 from company";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id_txt.Text = dr[0].ToString();
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into company values((select count(*)+1 from company),:name,:email,:password,:phone)";
            cmd.Parameters.Add("lname", name_txt.Text);
            cmd.Parameters.Add("email", email_txt.Text);
            cmd.Parameters.Add("password", password_txt.Text);
            cmd.Parameters.Add("phone", phone_txt.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New company is added");
                name_txt.Text = "";
                email_txt.Text = "";
                password_txt.Text = "";
                phone_txt.Text = "";
            }
            LoginForm lgfm = new LoginForm();
            this.Hide();
            lgfm.Show();
        }

        private void showhide_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showhide_checkbox.Checked)
            {
                password_txt.UseSystemPasswordChar = false;
            }
            else
            {
                password_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
