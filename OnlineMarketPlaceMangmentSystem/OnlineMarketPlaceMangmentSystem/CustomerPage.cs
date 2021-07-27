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
    public partial class CustomerPage : Form
    {

        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
           
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GET_CUSTOMER_DATA";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32,LoginForm.id_register ,ParameterDirection.Input);
            cmd.Parameters.Add("fname",OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("lname",OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("email", OracleDbType.Varchar2,20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("password", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("phone", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("city", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("country", OracleDbType.Varchar2, 20).Direction = ParameterDirection.Output;
            
            cmd.ExecuteNonQuery();
             
            Id_txt.Text = LoginForm.id_register.ToString();
            fname_txt.Text = cmd.Parameters["fname"].Value.ToString();
            lname_txt.Text = cmd.Parameters["lname"].Value.ToString();
            email_txt.Text = cmd.Parameters["email"].Value.ToString();
            password_txt.Text = cmd.Parameters["password"].Value.ToString();
            phone_txt.Text = cmd.Parameters["phone"].Value.ToString();
            city_txt.Text = cmd.Parameters["city"].Value.ToString();
            country_txt.Text = cmd.Parameters["country"].Value.ToString();

            conn.Close();
        }
    }
}
