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
    public partial class CustomerRegister : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public CustomerRegister()
        {
            InitializeComponent();
            password_txt.UseSystemPasswordChar = true;
        }
        private void CustomerRegister_Load(object sender, EventArgs e)
        { 
            // to show the next available id to the new customer;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(*)+1 from customer";
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
            cmd.CommandText = "insert into customer values((select count(*)+1 from customer),:fname,:lname,:email,:password,:phone,:city,:country)";
            cmd.Parameters.Add("fname", fname_txt.Text);
            cmd.Parameters.Add("lname", lname_txt.Text);
            cmd.Parameters.Add("email", email_txt.Text);
            cmd.Parameters.Add("password", password_txt.Text);
            cmd.Parameters.Add("phone", phone_txt.Text);
            cmd.Parameters.Add("city", city_txt.Text);
            cmd.Parameters.Add("country", country_txt.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("New customer is added.");
                fname_txt.Text ="";
                lname_txt.Text ="";
                email_txt.Text = "";
                password_txt.Text = "";
                phone_txt.Text = "";
                city_txt.Text = "";
                country_txt.Text = "";
            }
            LoginForm lgfm = new LoginForm();
            this.Hide();
            lgfm.Show();
        }
      
        private void showhide_checkbox_CheckedChanged_1(object sender, EventArgs e)
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
