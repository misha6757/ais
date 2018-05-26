using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //первый элемент списка
            {
                if (textBox1.Text == "admin")
                {
                    if (textBox2.Text == "admin")
                    {
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("логин не правильный");

            }
            if (comboBox1.SelectedIndex == 1 )//второй элемент списка
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (comboBox1.SelectedIndex == 2) //первый элемент списка
            {
                if (textBox1.Text == "admin")
                {
                    if (textBox2.Text == "admin")
                    {
                        Form4 f4 = new Form4();
                        f4.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("логин не правильный");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
           ;
        }
    }
    }

