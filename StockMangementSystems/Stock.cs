using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

class StockItem
{
    private string StockCode;
    private string Name;
    private int Quantity;

    public StockItem(string stockCode, string name, int quan)
    {
        StockCode = stockCode;
        Name = name;
        Quantity = quan;
    }

    public string getcode()
    {
        return StockCode;
    }

    public string getname()
    {
        return Name;
    }

    public int getquan()
    {
        return Quantity;
    }

    MySqlConnection connection = new MySqlConnection("datasource=localhost;database=stockman;username=root;password=''");


    public void AddItem()
    {
        string connectio = "INSERT INTO tabstock(`StockCode`, `StockName`, `StockQuantity`) VALUES('" + getcode() + "', '" + getname() + "', '" + getquan() + "')";
        connection.Open();
        MySqlCommand cmd = new MySqlCommand(connectio, connection);
        try
        {
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Data is saved");
            }
            else
            {
                MessageBox.Show("Data is not saved");
            }
            connection.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Data is already inserted");
        }       
    }
}