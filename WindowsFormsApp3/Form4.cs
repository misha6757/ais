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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet3.shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter1.Fill(this.bazaDataSet3.shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet2.shop". При необходимости она может быть перемещена или удалена.
            this.shopTableAdapter.Fill(this.bazaDataSet2.shop);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet2.dogovor". При необходимости она может быть перемещена или удалена.
            this.dogovorTableAdapter.Fill(this.bazaDataSet2.dogovor);
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
            string up = "";
            string loh = "";
            string down = "";
            string pol = "";
            string sum = "";
            id = Convert.ToString(textBox1.Text);
            up = Convert.ToString(textBox2.Text);
            loh = Convert.ToString(textBox3.Text);
            down = Convert.ToString(textBox4.Text);
            pol = Convert.ToString(textBox5.Text);
            sum = "('" + id + "', '" + up + "', '" + loh + "', '" + down + "', '" + pol + "')";
            dogovorTableAdapter.Connection.Open();
            OleDbCommand command = dogovorTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO dogovor (nomerdogovora, klient, chena, product, vidacha) VALUES " + sum;
            command.ExecuteNonQuery();
            dogovorTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("заказ добавлен");
            dogovorTableAdapter.Update(bazaDataSet2.dogovor);
            dogovorTableAdapter.Fill(bazaDataSet2.dogovor);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a, b, xui;
            string t = textBox6.Text, y = textBox7.Text;
            int.TryParse(t, out a);
            int.TryParse(y, out b);
            xui = a * b;
            label1.Text = xui.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idS;
            idS = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            shopTableAdapter.Connection.Open();
            OleDbCommand command = shopTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM dogovor WHERE nomerdogovora = " + idS;
            command.ExecuteNonQuery();
            shopTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp3\WindowsFormsApp3\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM dogovor WHERE nomerdogovora = " + idS;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("договор удален");
            dogovorTableAdapter.Update(bazaDataSet2.dogovor);
            dogovorTableAdapter.Fill(bazaDataSet2.dogovor);
        }
    }
}
