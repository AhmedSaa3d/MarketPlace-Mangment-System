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
    public partial class AddProdcuts : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OpenFileDialog openFD;
        int productid = 0;
        public AddProdcuts()
        {
            InitializeComponent();
        }

        private void uploadphoto_btn_Click(object sender, EventArgs e)
        {
            openFD = new OpenFileDialog();
            openFD.Filter = "Image Files(*.jpg; *.jpeg; *.gif ; *.bmp) |*.jpg; *.jpeg; *.gif ; *.bmp";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFD.FileName);
            }
        }

        private void AddProdcuts_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            /*cmd.CommandText = "GetProductsCount";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.ExecuteNonQuery();
            productid = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
            */////////////////show distinct available category
            cmd.CommandText = "select distinct category_name from category";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                category_combox.Items.Add(dr[0]);
            }
            cmd.CommandText = "select * from product where company_id =:cid";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("cid",LoginForm.id_register);
             dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id_combox.Items.Add(dr[0]);
            }
        }
        private void id_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            //show id,name,price,quantity
            c.CommandText = "select * from product where prodcut_id =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", id_combox.SelectedItem);
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                name_txt.Text = dr[1].ToString();
                price_txt.Text = dr[2].ToString();
                quantity_txt.Text = dr[3].ToString();
                 pictureBox1.ImageLocation = dr[5].ToString();
                 category_combox.Text = dr[6].ToString();
            }
            dr.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT_PRODUCT_TO_COMPANY";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("id", productid);
            cmd.Parameters.Add("name", name_txt.Text);
            cmd.Parameters.Add("price", Convert.ToInt16(price_txt.Text));
            cmd.Parameters.Add("qunatity", Convert.ToInt16(quantity_txt.Text));
            cmd.Parameters.Add("company_id", LoginForm.id_register);
            cmd.Parameters.Add("img", openFD.FileName);
            cmd.Parameters.Add("category", category_combox.SelectedItem);

            cmd.ExecuteNonQuery();
            MessageBox.Show("New Product is added");
            CompanyPage compage = new CompanyPage();
            this.Hide();
            compage.Show();
          
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "UPDATE_PRODUCT_TO_COMPANY";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id", id_combox.SelectedItem);
            c.Parameters.Add("name", name_txt.Text);
            c.Parameters.Add("price", Convert.ToInt16(price_txt.Text));
            c.Parameters.Add("qunatity", Convert.ToInt16(quantity_txt.Text));
            //c.Parameters.Add("companyid", LoginForm.id_register);
            c.Parameters.Add("img", openFD.FileName);
            c.Parameters.Add("category", category_combox.SelectedItem);
            c.ExecuteNonQuery();
            MessageBox.Show("Your Data modified.");
            
        }

        
        private void delete_btn_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "DELETE_PRODUCT_TO_COMPANY";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("id",id_combox.SelectedItem);
            c.ExecuteNonQuery();
            MessageBox.Show("Your product is deleted.");
            CompanyPage cmp = new CompanyPage();
            this.Hide();
            cmp.Show();
        }


    }
}
