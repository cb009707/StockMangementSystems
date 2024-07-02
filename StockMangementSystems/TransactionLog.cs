using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMangementSystems
{
    public partial class TransactionLog : Form
    {
        string connect = $"datasource=localhost;database=stockman;username=root;password=''";
        DataTable table = new DataTable();
        public TransactionLog()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void TransactionLog_Load(object sender, EventArgs e)
        {

            using (MySqlConnection sqltab = new MySqlConnection(connect))
            {

                sqltab.Open();
                MySqlDataAdapter sql = new MySqlDataAdapter("SELECT * FROM view", sqltab);
                sql.Fill(table);

                dataGridView1.DataSource = table;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
