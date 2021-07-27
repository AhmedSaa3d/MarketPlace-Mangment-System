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
    public partial class CompanyPage : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public CompanyPage()
        {
            InitializeComponent();
        }

        private void CompanyPage_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from company where company_id =:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id",LoginForm.id_register);
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Id_txt.Text = dr[0].ToString();
                name_txt.Text = dr[1].ToString();
                email_txt.Text = dr[2].ToString();
                password_txt.Text = dr[3].ToString();
                phone_txt.Text = dr[4].ToString();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "update company set name =:name, e_mail =:email, password=:password, phone =:phone where company_id =:id";
            c.Parameters.Add("name",name_txt.Text);
            c.Parameters.Add("email", email_txt.Text);
            c.Parameters.Add("password", password_txt.Text);
            c.Parameters.Add("phone", phone_txt.Text);
            c.Parameters.Add("id", LoginForm.id_register);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Your Data modified.");
            }
        }

        private void addproduct_btn_Click(object sender, EventArgs e)
        {
            AddProdcuts addpr = new AddProdcuts();
            this.Hide();
            addpr.Show();
        }

       
    }
}
