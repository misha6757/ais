using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet3.shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.bazaDataSet3.shop);
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string idP = "";
                string pro = "";
                string kol = "";
                string har = "";
                string sum = "";
                idP = Convert.ToString(textBox1.Text);
                pro = Convert.ToString(textBox2.Text);
                kol = Convert.ToString(textBox3.Text);
                har = Convert.ToString(textBox4.Text);
                sum = "('" + idP + "', '" + pro + "', '" + kol + "', '" + har + "')";
                shopTableAdapter.Connection.Open();
                OleDbCommand command = shopTableAdapter.Connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO shop (productid, product, kolichestvo, harakteristika) VALUES " + sum;
                command.ExecuteNonQuery();
                shopTableAdapter.Connection.Close();
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("продукт добавлен");
                shopTableAdapter.Update(bazaDataSet3.shop);
                shopTableAdapter.Fill(bazaDataSet3.shop);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idS;
            idS = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            shopTableAdapter.Connection.Open();
            OleDbCommand command = shopTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM shop WHERE productid = " + idS;
            command.ExecuteNonQuery();
            shopTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM shop WHERE productid = " + idS;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("продукт удален");
            shopTableAdapter.Update(bazaDataSet3.shop);
            shopTableAdapter.Fill(bazaDataSet3.shop);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
           Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros = new
                OleDbDataAdapter("SELECT * FROM shop ORDER BY [shop.kolichestvo] ASC", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT * FROM shop ORDER BY [shop.kolichestvo] ASC", conn);
            zapros.SelectCommand = command;
            DataTable DTzap = new DataTable();
            zapros.Fill(DTzap);
            BindingSource BSzap = new BindingSource();
            BSzap.DataSource = DTzap;
            dataGridView1.DataSource = BSzap;
            //dataGridView1.Columns[0].HeaderCell.Value = "Количество по убыванию";
            conn.Close();
            MessageBox.Show("товар добавлен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
           Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros2 = new
                OleDbDataAdapter("SELECT [shop.product] FROM shop WHERE [shop.kolichestvo] <> 0;'", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT [shop.product] FROM shop WHERE [shop.kolichestvo] <> 0;", conn);
            zapros2.SelectCommand = command;
            DataTable DTzap2 = new DataTable();
            zapros2.Fill(DTzap2);
            BindingSource BSzap2 = new BindingSource();
            BSzap2.DataSource = DTzap2;
            dataGridView2.DataSource = BSzap2;
            //dataGridView1.Columns[0].HeaderCell.Value = "Количество по убыванию";
            conn.Close();
            MessageBox.Show("обратите внимание на отсутствие");
        }
    } 
}
