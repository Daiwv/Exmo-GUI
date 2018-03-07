using System;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        void Sell()
        {
            string rez = new API().ApiQuery("order_create", new Dictionary<string, string> { { "pair", comboBox2.SelectedItem.ToString() }, { "quantity", textBox4.Text }, { "price", checkBox2.Checked ? "0" : textBox3.Text }, { "type", checkBox2.Checked ? "sell" : "market_sell" } });
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            } else {
                MessageBox.Show("Successful");
            }
        }

        void Buy()
        {
            string rez = new API().ApiQuery("order_create", new Dictionary<string, string> { { "pair", comboBox1.SelectedItem.ToString() }, { "quantity", textBox1.Text }, { "price", checkBox1.Checked ? "0" : textBox2.Text }, { "type", checkBox1.Checked ? "buy" : "market_buy" } });
            if (rez.Contains("false"))
            {
                string[] temp = rez.Split('"');
                MessageBox.Show(temp[5], "Error");
            } else {
                MessageBox.Show("Successful");
            }
        }

        void GetPrice()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            string price = new WebClient().DownloadString("https://api.exmo.com/v1/ticker/");
            string[] tm = price.Split('"');

            int c_name = 1;
            int c_price0 = 5;
            int c_price1 = 9;

            for (int i = 0; i != 45; i++)
            {
                dataGridView2.Rows.Add(tm[c_name], tm[c_price0], tm[c_price1]);
                c_name += 36;
                c_price0 += 36;
                c_price1 += 36;
            }

            price = null;
            tm = null;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GetPrice();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetPrice();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form9 client = new Form9();
            client.ShowDialog();
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

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 client = new Form8();
            client.ShowDialog();
            this.Close();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            Buy();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Sell();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.Enabled = false;
            }
            else
            {
                textBox3.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Buy();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Sell();
        }
    }
}
