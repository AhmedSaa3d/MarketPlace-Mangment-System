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
    public partial class LoginForm : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        string whoregister = null;
        public static int id_register = 0;
        public LoginForm()
        {
            InitializeComponent();
            password_txt.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //First check for customers
            cmd.CommandText = "select * from customer";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[3].ToString() == email_txt.Text && dr[4].ToString() == password_txt.Text)
                {
                    id_register = Convert.ToInt32(dr[0]);
                    whoregister = "customer";

                    CustomerPage cstpg = new CustomerPage();
                    this.Hide();
                    cstpg.Show();


                    break;
                }
            }
            //second check for companys
            cmd.CommandText = "select * from company";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[2].ToString() == email_txt.Text && dr[3].ToString() == password_txt.Text)
                {
                    id_register = Convert.ToInt32(dr[0]);
                    whoregister = "company";

                    CompanyPage cmpg = new CompanyPage();
                    this.Hide();
                    cmpg.Show();
                    break;
                }
            }
            //third check for admins
            cmd.CommandText = "select * from admin";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[1].ToString() == email_txt.Text && dr[2].ToString() == password_txt.Text)
                {
                    id_register = Convert.ToInt32(dr[0]);
                    whoregister = "admin";

                    AdminPage ad = new AdminPage();
                    this.Hide();
                    ad.Show();

                    break;
                }
            }
            dr.Close();
            if (id_register == 0)
            {
                MessageBox.Show("E_Mail OR Password Isn't Correct.");
                email_txt.Text = "";
                password_txt.Text = "";
            }
        }

        private void NewCustomer_btn_Click(object sender, EventArgs e)
        {
            CustomerRegister customer_reg = new CustomerRegister();
            this.Hide();
            customer_reg.Show();
        }

        private void NewCompany_btn_Click(object sender, EventArgs e)
        {
            CompanyRegister company_reg = new CompanyRegister();
            this.Hide();
            company_reg.Show();
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
