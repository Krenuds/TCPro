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
    public partial class CentralStation : Form
    {
        MySqlConnection myConnection;
        MySqlDataAdapter myAdapter;
        MySqlCommand myCommand;
        MySqlDataReader myReader;
        DataTable myDataTable;
        BindingSource myBinder;

        public CentralStation(MySqlConnection _myConnection)
        {
            InitializeComponent();
            myConnection = _myConnection;
           
        }

        private void PopulateTableSelection()
        {
            try
            {
                myCommand.CommandText = "SHOW TABLES FROM tcpro";
                myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    string tableName = myReader.GetString(0);
                    tableMenuList.Items.Add(tableName);
                }
                tableMenuList.SelectedIndex = 0;
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }

        private void retrieve_data_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = this.sqlCommand_txt.Text;
                myAdapter.SelectCommand = myCommand;
                myDataTable.Clear();
                myDataTable.Columns.Clear();
                myAdapter.Fill(myDataTable);
               
                myBinder.DataSource = myDataTable;
                dataGridView1.DataSource = myBinder;
                myAdapter.Update(myDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.CommandText = "SELECT * FROM tcpro." + this.tableMenuList.Text + ";";
                myAdapter.SelectCommand = myCommand;
                myDataTable.Clear();
                myDataTable.Columns.Clear();
                myAdapter.Fill(myDataTable);
                myBinder.DataSource = null;
                myBinder.DataSource = myDataTable;
                dataGridView1.DataSource = myBinder;
                myAdapter.Update(myDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
        private void CentralStation_FormClosing(object sender, FormClosingEventArgs e) 
        {
            myConnection.Close();
            Application.Exit();
        }

        private void CentralStation_Load(object sender, EventArgs e)
        {
            this.FormClosing += CentralStation_FormClosing;
            myAdapter = new MySqlDataAdapter();
            myCommand = new MySqlCommand(" ", myConnection);
            myDataTable = new DataTable();
            myBinder = new BindingSource();

            PopulateTableSelection();
        }
    }
}
