using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Exmo
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        void Cancel()
        {
            string rez = new API().ApiQuery("order_cancel", new Dictionary<string, string> { { "order_id", textBox1.Text } });
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 client = new Form7();
            client.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 client = new Form4();
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 client = new Form5();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 client = new Form9();
            client.ShowDialog();
            this.Close();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            Cancel();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Cancel();
        }
    }
}
