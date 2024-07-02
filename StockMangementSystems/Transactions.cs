using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StockMangementSystems
{
    internal class Transactions : StockItem
    {
        public DateTime Date { get; set; }

        MySqlConnection connection = new MySqlConnection("datasource=localhost;database=stockman;username=root;password=''");


        public Transactions(string stockCode, string name, int quan, DateTime date) : base(stockCode, name, quan)
        {
            Date = date;
        }

        public string Name { get; set; }
        

        public void AddItem(string code, string name, int quantity, string action)
        {
            try
            {
                connection.Open();
                string connectionview = "INSERT INTO view(`StockCode`, `StockName`, `StockQuantity`,`StockAction`) VALUES('" + code + "', '" + name + "', '" + quantity + "','" + action + "')";
                MySqlCommand cmd1 = new MySqlCommand(connectionview, connection);
                cmd1.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Stock code already exists");
            }
        }
    }
}
