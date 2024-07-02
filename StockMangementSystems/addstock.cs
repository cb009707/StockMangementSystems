using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace StockMangementSystems
{
    public partial class addstock : Form
    {
        MySqlConnection connectionstring = new MySqlConnection("datasource=localhost;database=stockman;username=root;password=''");

        DataTable stocktable1 = new DataTable();
        public addstock()
        {
            InitializeComponent();
        }

        //Save button
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string action = "Item Added";
                string code = Code.Text;
                string name = Name.Text;


                int quantity = Convert.ToInt32(Quantity.Text);

                bool errors = false;

                if (code == "")
                {
                    MessageBox.Show("Enter stock code");
                    errors = true;
                }

                if (name == "")
                {
                    MessageBox.Show("Enter stock name");
                    errors = true;
                }

                //if (Quantity.Text == "")
                //{
                //    MessageBox.Show("Enter stock quantity");
               //     errors = true;
                //}

                if (errors == false)
                {

                    stocktable1.Rows.Add(code, name, quantity);


                    StockItem stocky = new StockItem(code, name, quantity);
                    stocky.AddItem();



                    Transactions trans = new Transactions(code, name, quantity, DateTime.Now);
                    trans.AddItem(stocky.getcode(), stocky.getname(), stocky.getquan(), action);
                }
            }


            catch (Exception ew)
            {
                MessageBox.Show("Enter a value which is a whole number");
            }
            /*
            string connectio = "INSERT INTO tabstock(`StockCode`, `StockName`, `StockQuantity`) VALUES('" + stocky.getcode() + "', '" + stocky.getname() + "', '" + stocky.getquan() + "')";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(connectio,connection);
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data is saved");
            }
            else
            {
                MessageBox.Show("Data is not saved");
            }
            connection.Close();
            */



            /*
            connection.Open();
            string connectionview = "INSERT INTO view(`StockCode`, `StockName`, `StockQuantity`,`StockAction`) VALUES('" + stocky.getcode() + "', '" + stocky.getname() + "', '" + stocky.getquan() + "','"+action+"')";
            MySqlCommand cmd1 = new MySqlCommand(connectionview, connection);
            cmd1.ExecuteNonQuery();
            connection.Close();
            */
        }

        //Home button
        private void Home_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        //Reset button
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            Code.Text = "";
            Name.Text = "";
            Quantity.Text = "";
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stocktable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Code.Text = stocktable1.Rows[stocktable.CurrentCell.RowIndex].ItemArray[0].ToString();
                Name.Text = stocktable1.Rows[stocktable.CurrentCell.RowIndex].ItemArray[1].ToString();
                Quantity.Text = stocktable1.Rows[stocktable.CurrentCell.RowIndex].ItemArray[2].ToString();

            }

            catch (Exception error)
            {
                Console.WriteLine("Error" + error);
            }
        }

        private void addstock_Load(object sender, EventArgs e)
        {
            stocktable1.Columns.Add("Code");
            stocktable1.Columns.Add("Name");
            stocktable1.Columns.Add("Quantity");

            stocktable.DataSource = stocktable1;
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
