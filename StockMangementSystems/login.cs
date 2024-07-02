using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StockMangementSystems
{
    public partial class login : Form
    {
        string loginDB = $"datasource=localhost;database=stockman;username=root;password=''";
        public login()
        {
            InitializeComponent();
        }

        private void logbt_Click(object sender, EventArgs e)
        {
            //if (UserBox.Text == "admin" && PassBox.Text == "admin")
            //{
            //    this.Hide();
            //    Form1 form = new Form1();
            //    form.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password");
            //}            
            using (MySqlConnection tablog = new MySqlConnection(loginDB))
            {
                string UserName = UserBox.Text;
                string Password = PassBox.Text;

                tablog.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM logindatatable", tablog);
                MySqlDataReader identify = command.ExecuteReader();
                bool infolog = false;
                try
                {
                    while (identify.Read())
                    {
                        if (UserName == identify.GetString("USERNAME") && Password == identify.GetString("PASSWORD"))
                        {
                            infolog = true;
                            break;
                        }

                    }
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
                if (infolog == true)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid User Details");
                }
            }
        }
    }
    }

