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
    public partial class StartForm : Form
    {
       

        public StartForm()
        {
            InitializeComponent();
            LoginForm lgfm = new LoginForm();
            this.Dispose();
            lgfm.ShowDialog();
        }

        
    }
}
