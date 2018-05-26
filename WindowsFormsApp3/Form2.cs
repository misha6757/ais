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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet3.klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.bazaDataSet3.klient);
            



        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string idK = "";
                string FIO = "";
                string adress = "";
                string phone = "";
                string sum = "";
                idK = Convert.ToString(textBox1.Text);
                FIO = Convert.ToString(textBox2.Text);
                adress = Convert.ToString(textBox3.Text);
                phone = Convert.ToString(textBox4.Text);
                sum = "('" + idK + "', '" + FIO + "', '" + adress + "', '" + phone + "')";
                klientTableAdapter.Connection.Open();
                OleDbCommand command = klientTableAdapter.Connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO Klient (idklienta, fio, adress, phone) VALUES " + sum;
                command.ExecuteNonQuery();
                klientTableAdapter.Connection.Close();
                OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
                conn.Open();
                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("TI LOH");
                klientTableAdapter.Update(bazaDataSet3.klient);
                klientTableAdapter.Fill(bazaDataSet3.klient);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idK;
            idK = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            klientTableAdapter.Connection.Open();
            OleDbCommand command = klientTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Klient WHERE idklienta = " + idK;
            command.ExecuteNonQuery();
            klientTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM Klient WHERE idklienta = " + idK;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("DELETE OK");
            klientTableAdapter.Update(bazaDataSet3.klient);
            klientTableAdapter.Fill(bazaDataSet3.klient);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
           Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros = new
                OleDbDataAdapter("SELECT * FROM Klient ORDER BY [Klient.fio] ASC", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT * FROM Klient ORDER BY [Klient.fio] ASC", conn);
            zapros.SelectCommand = command;
            DataTable DTzap = new DataTable();
            zapros.Fill(DTzap);
            BindingSource BSzap = new BindingSource();
            BSzap.DataSource = DTzap;
            dataGridView1.DataSource = BSzap;
            //dataGridView1.Columns[0].HeaderCell.Value = "Количество по убыванию";
            conn.Close();
           // MessageBox.Show("товар добавлен");
        }
    } 
}
