using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TCPro
{
    public partial class TCPro : Form
    {
        public TCPro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                string user = this.username_txt.Text;
                string password = this.password_txt.Text;
                string myConnectionString = "datasource=localhost; port=3306; username = " + user + "; password = "+ password;
                MySqlConnection myConnection = new MySqlConnection(myConnectionString);
                myConnection.Open();
                this.Hide();

                CentralStation cs = new CentralStation(myConnection);
                cs.ShowDialog();
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
