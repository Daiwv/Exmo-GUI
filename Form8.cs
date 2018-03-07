using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        void CreatePayment()
        {
            string rez = new API().ApiQuery("withdraw_crypt", new Dictionary<string, string> { { "amount", textBox1.Text }, { "currency", comboBox1.SelectedItem.ToString() }, { "address", textBox5.Text }, { "invoice", textBox7.Text } });
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            }
            else
            {
                MessageBox.Show("Successful");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            CreatePayment();
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            CreatePayment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 client = new Form4();
            client.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 client = new Form7();
            client.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 client = new Form10();
            client.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 client = new Form9();
            client.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 client = new Form5();
            client.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 client = new Form6();
            client.ShowDialog();
            this.Close();
        }
    }
}
